using Newtonsoft.Json;
using Sulakore.Communication;
using Sulakore.Modules;
using Sulakore.Protocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangine;

namespace SonicScript
{
    [Module("SonicScript", "Script for playing the sonic game automaticly")]
    [Author("Yonas")]
    public partial class SonicScript : ExtensionForm
    {
        #region something
        private Config _config = new Config();
        private ushort _useFurnitureId = 0;
        private ushort _itemExtraDataId;
        private ScriptState p_scriptState;
        private string colorTile1Data = "-3";
        private string colorTile2Data = "-4";
        private ScriptState scriptState
        {
            get
            {
                return p_scriptState;
            }
            set { p_scriptState = value; StateChanged(); }
        }
        #endregion

        public SonicScript()
        {
            InitializeComponent();
            StateChanged();
            AllocConsole();
        }

        private void StateChanged()
        {
            _statusLabel.Text = $"Status: {scriptState}";
            _configLabel.Text = $"Config:";
            var newline = Environment.NewLine;
            var t =
                $"Config:{newline}" +
                $"HendelId: {_config.SwitchId} {newline}" +
                $"ColorTile1: {_config.ColorTile1} {newline}" +
                $"ColorTile2: {_config.ColorTile2} {newline}" +
                $"ColorTile1Data: {colorTile1Data} {newline}" +
                $"ColorTile2Data: {colorTile2Data} {newline}" +
                $"State: {scriptState} {newline}" +

                "";
            _configLabel.Text = t;
        }

        #region Triggers
        private void CheckState()
        {
            Console.WriteLine($"ExtraDataUpdate->CheckState: Tile1: {colorTile1Data} - Tile2: {colorTile2Data}");
            StateChanged();
            if (colorTile1Data != "0" && colorTile1Data == colorTile2Data)
            {
                Console.WriteLine($"ExtraDataUpdate->CheckState->Working: Tile1: {colorTile1Data} - Tile2: {colorTile2Data}");
                UseItem(_config.SwitchId);
            }
        }
      
        private void OnExtraDataUpdate(DataInterceptedEventArgs e)
        {
            string itemId = e.Packet.ReadString();
            int extraDataType = e.Packet.ReadInteger();

            switch (scriptState)
            {
                case ScriptState.started:
                    {
                        if (itemId == _config.ColorTile1.ToString())
                        {
                            colorTile1Data = e.Packet.ReadString();
                            CheckState();
                        }
                        else if (itemId == _config.ColorTile2.ToString())
                        {
                            colorTile2Data = e.Packet.ReadString();
                            CheckState();
                        }
                        break;
                    }
            }
        }

        private void OnUseFunriture(DataInterceptedEventArgs e)
        {
            int itemID = e.Packet.ReadInteger();
            int state = e.Packet.ReadInteger();
            Console.WriteLine($"Trigger->UseFurniture: ItemId: {itemID}");

            switch (scriptState)
            {
                case ScriptState.SelectSwitch:
                    {

                        scriptState = ScriptState.none;
                        _config.SwitchId = itemID;
                        Console.WriteLine($"Config->SwitchID set to: {itemID}");
                        break;
                    }
                case ScriptState.SelectColorTile1:
                    {

                        scriptState = ScriptState.none;
                        _config.ColorTile1 = itemID;
                        Console.WriteLine($"Config->ColorTile1 set to: {itemID}");
                        break;
                    }
                case ScriptState.SelectColorTile2:
                    {

                        scriptState = ScriptState.none;
                        _config.ColorTile2 = itemID;
                        Console.WriteLine($"Config->ColorTile2 set to: {itemID}");
                        break;
                    }

            }
        }
        private void UseItem(int itemId)
        {
            Console.WriteLine($"UseSwitch itemid: {itemId}");
            //{l}{u:1294}{i:274071115}{i:0}
            HMessage message = new HMessage(_useFurnitureId);
            message.WriteInteger(itemId);
            message.WriteInteger(0);
            this.Connection.SendToServerAsync(message);
        }

        #endregion

        #region Initialize

        private void InitializeTriggers()
        {
            _useFurnitureId = this.Out.GetId("UseFurniture");
            _itemExtraDataId = this.In.GetId("ItemExtraData");

            this.Triggers.OutAttach(_useFurnitureId, (e) => OnUseFunriture(e));
            this.Triggers.InAttach(_itemExtraDataId, (e) => OnExtraDataUpdate(e));

        }

        private void OnConnected()
        {
            InitializeTriggers();
        }

        private bool _connected;
        public bool Connected
        {
            get { return _connected; }
            set
            {
                if (value && !_connected)
                {
                    OnConnected();
                }
                _connected = value;
            }
        }
        public override void HandleIncoming(DataInterceptedEventArgs e)
        {
            Connected = true;
            base.HandleIncoming(e);
        }
        #endregion


        #region Buttons 
        private void _startStopBtn_Click(object sender, EventArgs e)
        {
            scriptState = scriptState == ScriptState.started ? ScriptState.none : ScriptState.started;
        }

        private void _selectSwitchBtn_Click(object sender, EventArgs e)
        {
            scriptState = ScriptState.SelectSwitch;
        }

        private void _selectColorTileBtn_Click(object sender, EventArgs e)
        {
            scriptState = ScriptState.SelectColorTile1;
        }
        private void _selectColorTile2Btn_Click(object sender, EventArgs e)
        {
            scriptState = ScriptState.SelectColorTile2;
        }

        private void _loadSaveBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON|*.json";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName != "")
                {
                    var settingString = File.ReadAllText(openFileDialog.FileName);
                    _config = JsonConvert.DeserializeObject<Config>(settingString);
                }
            }
            StateChanged();
        }

        private void _saveConfigBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON|*.json";
            saveFileDialog1.Title = "Save the settings";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                var jsonSave = JsonConvert.SerializeObject(_config);
                File.WriteAllText(saveFileDialog1.FileName, jsonSave);
            }
        }


        #region logging
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        #endregion



        #endregion


    }
}

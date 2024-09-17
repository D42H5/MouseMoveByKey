using System;
using System.Windows.Forms;

namespace MouseMoveByKey {
    public partial class MainForm : Form {

        private Timer checkKeyDown = null;

        public MainForm() {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e) {
            //load the key bindings from the current JSON config, if any
            KeyboardHelper.CurrentKeyBindings = ConfigHelper.LoadKeyBindingsFromConfig();

            //load mouse settings from current JSON config, if any
            var mouseSettings = ConfigHelper.LoadMouseSettingsFromConfig();
            sliderSensitivity.Value = mouseSettings.Sensitivity;

            //setup low level keyboard hook to detect keypresses
            KeyboardHelper.StartLowLevelHook();

            //start thread to check key-down flags
            checkKeyDown = new Timer();
            checkKeyDown.Interval = 5; //millisecond resolution for checking keydown state
            checkKeyDown.Tick += CheckKeyDown_Tick;
            checkKeyDown.Start();
        }

        private void CheckKeyDown_Tick(object sender, EventArgs e) {
            if(chkActivate.Checked) {
                //
                // Move mouse direction handling
                //
                if(KeyboardHelper.LeftPressed) {
                    MouseHelper.MouseEventHandler(MouseEvent.Left, sliderSensitivity.Value);
                }
                if(KeyboardHelper.RightPressed) {
                    MouseHelper.MouseEventHandler(MouseEvent.Right, sliderSensitivity.Value);
                }
                if (KeyboardHelper.UpPressed)
                {
                    MouseHelper.MouseEventHandler(MouseEvent.Up, sliderSensitivity.Value);
                }
                if (KeyboardHelper.DownPressed) {
                    MouseHelper.MouseEventHandler(MouseEvent.Down, sliderSensitivity.Value);
                }

                //
                // Left mouse button handling
                //
                if (KeyboardHelper.LButtonPressed && MouseHelper.lButtonCurrentlyPressed == false) {
                    MouseHelper.MouseEventHandler(MouseEvent.LButton, 0);
                }
                else if (!KeyboardHelper.LButtonPressed && MouseHelper.lButtonCurrentlyPressed == true) {
                    MouseHelper.MouseEventHandler(MouseEvent.LButton, 0);
                }

                //  
                // Right mouse button handling
                //
                if (KeyboardHelper.RButtonPressed && MouseHelper.rButtonCurrentlyPressed == false)
                {
                    MouseHelper.MouseEventHandler(MouseEvent.RButton, 0);
                }
                else if (!KeyboardHelper.RButtonPressed && MouseHelper.rButtonCurrentlyPressed == true)
                {
                    MouseHelper.MouseEventHandler(MouseEvent.RButton, 0);
                }
            }
        }
        
        private void chkActivate_CheckedChanged(object sender, EventArgs e) {
            sliderSensitivity.Enabled = (!chkActivate.Checked);
            btnEditKeyBindings.Enabled = (!chkActivate.Checked);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            if(checkKeyDown != null)
                checkKeyDown.Dispose();
            KeyboardHelper.StopLowLevelHook();
        }

        private void btnEditKeyBindings_Click(object sender, EventArgs e) {
            using(var keyDialog = new KeyBindingForm()) {
                keyDialog.KeyBindings = KeyboardHelper.CurrentKeyBindings;
                keyDialog.ShowDialog();
                KeyboardHelper.CurrentKeyBindings = keyDialog.KeyBindings;
                //save the config file with the new bindings
                ConfigHelper.SaveKeyBindingsToConfig(KeyboardHelper.CurrentKeyBindings);
            }
        }

        private void sliderSensitivity_Scroll(object sender, EventArgs e) {
            ConfigHelper.SaveMouseSettingsToConfig(new MouseSettings { Sensitivity = sliderSensitivity.Value });
        }
    }
}

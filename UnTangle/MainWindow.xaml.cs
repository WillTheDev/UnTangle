using Microsoft.Win32;
using Newtonsoft.Json;
using System.IO;
using System.Windows;
using UnTangle.Core.Models;

namespace UnTangle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadPresetFileButton_Click(object sender, RoutedEventArgs e)
        {
            PresetFile presetData = new PresetFile();

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Helix Preset File (*.hlx)|*.hlx";
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == true)
            {
                using (FileStream fs = new FileStream(fileDialog.FileName, FileMode.Open))
                {
                    presetData = JsonConvert.DeserializeObject<PresetFile>(new StreamReader(fs).ReadToEnd());
                }
                
                // Saving.
                //using (FileStream fs = new FileStream("C:\\Temp\\U All Delay.hlx", FileMode.Create))
                //{
                //    string jsonString = JsonConvert.SerializeObject(presetData, Formatting.Indented);
                //    byte[] jsonArray = Encoding.ASCII.GetBytes(jsonString);
                //    fs.Write(jsonArray, 0, jsonArray.Length);
                //    fs.Flush();
                //}
            }

        }
    }
}

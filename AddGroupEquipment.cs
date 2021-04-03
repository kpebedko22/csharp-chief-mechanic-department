using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OGM.Models;

namespace OGM
{
    public partial class AddGroupEquipment : Form
    {
        private EquipmentGroup EditEquipmentGroup = null;
        public AddGroupEquipment(EquipmentGroup equipmentGroup = null)
        {
            InitializeComponent();

            this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            List<Workshop> workshops = Program.db.Workshops.ToList();
            this.comboBox1.DataSource = workshops;
            this.comboBox1.AutoCompleteCustomSource.AddRange(workshops.Select(i => i.name).ToArray());
            

            if (equipmentGroup != null)
            {
                this.Text = "Справочник - Редактировать группу оборудования";
                this.button_AddGroupEquipment.Text = "Изменить";
                this.button_AddGroupEquipmentAndClose.Text = "Изменить и закрыть";
                this.textBox_NameEquipment.Text = equipmentGroup.name;
                this.textBox_Cipher.Text = equipmentGroup.сipher;

                Workshop workshop = Program.db.Workshops.Find(equipmentGroup.PK_Workshop);
                if (workshop != null)
                    comboBox1.SelectedItem = workshop;
                else
                    comboBox1.Text = "Указанный цех не существует...";


                this.EditEquipmentGroup = equipmentGroup;
            }

        }


        // метод добавления/редактирования группы оборудования
        private void add_edit_equipment_group()
        {

            if (String.IsNullOrWhiteSpace(this.textBox_NameEquipment.Text) 
                || String.IsNullOrWhiteSpace(this.textBox_Cipher.Text)
                || comboBox1.SelectedItem == null || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Чтобы добавить или изменить запись заполните все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            // если добавляем
            if (this.EditEquipmentGroup == null)
            {
                EquipmentGroup newEquipmentGroup = new EquipmentGroup();

                newEquipmentGroup.name = this.textBox_NameEquipment.Text;
                newEquipmentGroup.сipher = this.textBox_Cipher.Text;

                int PK_Workshop = -1;
                if (comboBox1.SelectedItem != null && comboBox1.SelectedIndex != -1)
                    PK_Workshop = ((Workshop)this.comboBox1.SelectedItem).PK_Workshop;


                if (PK_Workshop != -1)
                {
                    Program.db.EquipmentGroups.Add(newEquipmentGroup);
                    MessageBox.Show("Успешно добавлено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    newEquipmentGroup.PK_Workshop = PK_Workshop;
                }
                else
                {
                    MessageBox.Show("Выберите цех!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            // редактируем
            else
            {

                this.EditEquipmentGroup.name = this.textBox_NameEquipment.Text;
                this.EditEquipmentGroup.сipher = this.textBox_Cipher.Text;

                // это плохо, хз как сделать нормально
                Workshop temp = null;
                foreach (Workshop item in Program.db.Workshops.ToList())
                    if (item.name == this.comboBox1.Text)
                    {
                        temp = item;
                        break;
                    }

                this.EditEquipmentGroup.PK_Workshop = temp.PK_Workshop;

                MessageBox.Show("Успешно изменено!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Program.db.SaveChanges();

        }


        private void button_AddGroupEquipment_Click(object sender, EventArgs e)
        {
            add_edit_equipment_group();
        }

        private void button_AddGroupEquipmentAndClose_Click(object sender, EventArgs e)
        {
            add_edit_equipment_group();
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

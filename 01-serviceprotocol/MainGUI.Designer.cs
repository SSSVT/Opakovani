namespace ServiceProtocol
{
    partial class MainGUI
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_general_measurement_date = new System.Windows.Forms.Label();
            this.lbl_general_protocol_no = new System.Windows.Forms.Label();
            this.btn_general_edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_customer_edit = new System.Windows.Forms.Button();
            this.lbl_customer_ic = new System.Windows.Forms.Label();
            this.lbl_customer_postal_code = new System.Windows.Forms.Label();
            this.lbl_customer_address = new System.Windows.Forms.Label();
            this.lbl_customer_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_device_edit = new System.Windows.Forms.Button();
            this.lbl_device_serial_number = new System.Windows.Forms.Label();
            this.lbl_device_model = new System.Windows.Forms.Label();
            this.lbl_device_manufacturer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_measurement_delete = new System.Windows.Forms.Button();
            this.btn_measurement_edit = new System.Windows.Forms.Button();
            this.btn_measurement_add = new System.Windows.Forms.Button();
            this.dgv_measurements = new System.Windows.Forms.DataGridView();
            this.btn_form_save = new System.Windows.Forms.Button();
            this.btn_form_load = new System.Windows.Forms.Button();
            this.btn_form_export = new System.Windows.Forms.Button();
            this.btn_form_preview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_measurements)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_general_measurement_date);
            this.groupBox1.Controls.Add(this.lbl_general_protocol_no);
            this.groupBox1.Controls.Add(this.btn_general_edit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Základní informace";
            // 
            // lbl_general_measurement_date
            // 
            this.lbl_general_measurement_date.AutoSize = true;
            this.lbl_general_measurement_date.Location = new System.Drawing.Point(107, 52);
            this.lbl_general_measurement_date.Name = "lbl_general_measurement_date";
            this.lbl_general_measurement_date.Size = new System.Drawing.Size(13, 13);
            this.lbl_general_measurement_date.TabIndex = 4;
            this.lbl_general_measurement_date.Text = "?";
            // 
            // lbl_general_protocol_no
            // 
            this.lbl_general_protocol_no.AutoSize = true;
            this.lbl_general_protocol_no.Location = new System.Drawing.Point(107, 27);
            this.lbl_general_protocol_no.Name = "lbl_general_protocol_no";
            this.lbl_general_protocol_no.Size = new System.Drawing.Size(13, 13);
            this.lbl_general_protocol_no.TabIndex = 3;
            this.lbl_general_protocol_no.Text = "?";
            // 
            // btn_general_edit
            // 
            this.btn_general_edit.Location = new System.Drawing.Point(530, 19);
            this.btn_general_edit.Name = "btn_general_edit";
            this.btn_general_edit.Size = new System.Drawing.Size(112, 46);
            this.btn_general_edit.TabIndex = 2;
            this.btn_general_edit.Text = "Upravit";
            this.btn_general_edit.UseVisualStyleBackColor = true;
            this.btn_general_edit.Click += new System.EventHandler(this.btn_general_edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum měření:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Číslo protokolu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_customer_edit);
            this.groupBox2.Controls.Add(this.lbl_customer_ic);
            this.groupBox2.Controls.Add(this.lbl_customer_postal_code);
            this.groupBox2.Controls.Add(this.lbl_customer_address);
            this.groupBox2.Controls.Add(this.lbl_customer_name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zákazník";
            // 
            // btn_customer_edit
            // 
            this.btn_customer_edit.Location = new System.Drawing.Point(240, 125);
            this.btn_customer_edit.Name = "btn_customer_edit";
            this.btn_customer_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_customer_edit.TabIndex = 8;
            this.btn_customer_edit.Text = "Upravit";
            this.btn_customer_edit.UseVisualStyleBackColor = true;
            this.btn_customer_edit.Click += new System.EventHandler(this.btn_customer_edit_Click);
            // 
            // lbl_customer_ic
            // 
            this.lbl_customer_ic.AutoSize = true;
            this.lbl_customer_ic.Location = new System.Drawing.Point(107, 102);
            this.lbl_customer_ic.Name = "lbl_customer_ic";
            this.lbl_customer_ic.Size = new System.Drawing.Size(13, 13);
            this.lbl_customer_ic.TabIndex = 7;
            this.lbl_customer_ic.Text = "?";
            // 
            // lbl_customer_postal_code
            // 
            this.lbl_customer_postal_code.AutoSize = true;
            this.lbl_customer_postal_code.Location = new System.Drawing.Point(107, 77);
            this.lbl_customer_postal_code.Name = "lbl_customer_postal_code";
            this.lbl_customer_postal_code.Size = new System.Drawing.Size(13, 13);
            this.lbl_customer_postal_code.TabIndex = 6;
            this.lbl_customer_postal_code.Text = "?";
            // 
            // lbl_customer_address
            // 
            this.lbl_customer_address.AutoSize = true;
            this.lbl_customer_address.Location = new System.Drawing.Point(107, 52);
            this.lbl_customer_address.Name = "lbl_customer_address";
            this.lbl_customer_address.Size = new System.Drawing.Size(13, 13);
            this.lbl_customer_address.TabIndex = 5;
            this.lbl_customer_address.Text = "?";
            // 
            // lbl_customer_name
            // 
            this.lbl_customer_name.AutoSize = true;
            this.lbl_customer_name.Location = new System.Drawing.Point(107, 27);
            this.lbl_customer_name.Name = "lbl_customer_name";
            this.lbl_customer_name.Size = new System.Drawing.Size(13, 13);
            this.lbl_customer_name.TabIndex = 4;
            this.lbl_customer_name.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "IČ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "PSČ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Název:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_device_edit);
            this.groupBox3.Controls.Add(this.lbl_device_serial_number);
            this.groupBox3.Controls.Add(this.lbl_device_model);
            this.groupBox3.Controls.Add(this.lbl_device_manufacturer);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(339, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zařízení";
            // 
            // btn_device_edit
            // 
            this.btn_device_edit.Location = new System.Drawing.Point(240, 125);
            this.btn_device_edit.Name = "btn_device_edit";
            this.btn_device_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_device_edit.TabIndex = 11;
            this.btn_device_edit.Text = "Upravit";
            this.btn_device_edit.UseVisualStyleBackColor = true;
            this.btn_device_edit.Click += new System.EventHandler(this.btn_device_edit_Click);
            // 
            // lbl_device_serial_number
            // 
            this.lbl_device_serial_number.AutoSize = true;
            this.lbl_device_serial_number.Location = new System.Drawing.Point(107, 77);
            this.lbl_device_serial_number.Name = "lbl_device_serial_number";
            this.lbl_device_serial_number.Size = new System.Drawing.Size(13, 13);
            this.lbl_device_serial_number.TabIndex = 10;
            this.lbl_device_serial_number.Text = "?";
            // 
            // lbl_device_model
            // 
            this.lbl_device_model.AutoSize = true;
            this.lbl_device_model.Location = new System.Drawing.Point(107, 52);
            this.lbl_device_model.Name = "lbl_device_model";
            this.lbl_device_model.Size = new System.Drawing.Size(13, 13);
            this.lbl_device_model.TabIndex = 9;
            this.lbl_device_model.Text = "?";
            // 
            // lbl_device_manufacturer
            // 
            this.lbl_device_manufacturer.AutoSize = true;
            this.lbl_device_manufacturer.Location = new System.Drawing.Point(107, 27);
            this.lbl_device_manufacturer.Name = "lbl_device_manufacturer";
            this.lbl_device_manufacturer.Size = new System.Drawing.Size(13, 13);
            this.lbl_device_manufacturer.TabIndex = 8;
            this.lbl_device_manufacturer.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Výrobce:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sériové číslo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Model:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_measurement_delete);
            this.groupBox4.Controls.Add(this.btn_measurement_edit);
            this.groupBox4.Controls.Add(this.btn_measurement_add);
            this.groupBox4.Controls.Add(this.dgv_measurements);
            this.groupBox4.Location = new System.Drawing.Point(12, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 261);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Měření";
            // 
            // btn_measurement_delete
            // 
            this.btn_measurement_delete.Location = new System.Drawing.Point(567, 232);
            this.btn_measurement_delete.Name = "btn_measurement_delete";
            this.btn_measurement_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_measurement_delete.TabIndex = 3;
            this.btn_measurement_delete.Text = "Smazat";
            this.btn_measurement_delete.UseVisualStyleBackColor = true;
            this.btn_measurement_delete.Click += new System.EventHandler(this.btn_measurement_delete_Click);
            // 
            // btn_measurement_edit
            // 
            this.btn_measurement_edit.Location = new System.Drawing.Point(486, 232);
            this.btn_measurement_edit.Name = "btn_measurement_edit";
            this.btn_measurement_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_measurement_edit.TabIndex = 2;
            this.btn_measurement_edit.Text = "Upravit";
            this.btn_measurement_edit.UseVisualStyleBackColor = true;
            this.btn_measurement_edit.Click += new System.EventHandler(this.btn_measurement_edit_Click);
            // 
            // btn_measurement_add
            // 
            this.btn_measurement_add.Location = new System.Drawing.Point(405, 232);
            this.btn_measurement_add.Name = "btn_measurement_add";
            this.btn_measurement_add.Size = new System.Drawing.Size(75, 23);
            this.btn_measurement_add.TabIndex = 1;
            this.btn_measurement_add.Text = "Přidat";
            this.btn_measurement_add.UseVisualStyleBackColor = true;
            this.btn_measurement_add.Click += new System.EventHandler(this.btn_measurement_add_Click);
            // 
            // dgv_measurements
            // 
            this.dgv_measurements.AllowUserToAddRows = false;
            this.dgv_measurements.AllowUserToDeleteRows = false;
            this.dgv_measurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_measurements.Location = new System.Drawing.Point(6, 19);
            this.dgv_measurements.MultiSelect = false;
            this.dgv_measurements.Name = "dgv_measurements";
            this.dgv_measurements.ReadOnly = true;
            this.dgv_measurements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_measurements.Size = new System.Drawing.Size(636, 207);
            this.dgv_measurements.TabIndex = 0;
            // 
            // btn_form_save
            // 
            this.btn_form_save.Location = new System.Drawing.Point(12, 522);
            this.btn_form_save.Name = "btn_form_save";
            this.btn_form_save.Size = new System.Drawing.Size(75, 23);
            this.btn_form_save.TabIndex = 4;
            this.btn_form_save.Text = "Uložit";
            this.btn_form_save.UseVisualStyleBackColor = true;
            this.btn_form_save.Click += new System.EventHandler(this.btn_form_save_Click);
            // 
            // btn_form_load
            // 
            this.btn_form_load.Location = new System.Drawing.Point(93, 522);
            this.btn_form_load.Name = "btn_form_load";
            this.btn_form_load.Size = new System.Drawing.Size(75, 23);
            this.btn_form_load.TabIndex = 5;
            this.btn_form_load.Text = "Načíst";
            this.btn_form_load.UseVisualStyleBackColor = true;
            this.btn_form_load.Click += new System.EventHandler(this.btn_form_load_Click);
            // 
            // btn_form_export
            // 
            this.btn_form_export.Location = new System.Drawing.Point(504, 522);
            this.btn_form_export.Name = "btn_form_export";
            this.btn_form_export.Size = new System.Drawing.Size(75, 23);
            this.btn_form_export.TabIndex = 6;
            this.btn_form_export.Text = "Export";
            this.btn_form_export.UseVisualStyleBackColor = true;
            this.btn_form_export.Click += new System.EventHandler(this.btn_form_export_Click);
            // 
            // btn_form_preview
            // 
            this.btn_form_preview.Location = new System.Drawing.Point(585, 522);
            this.btn_form_preview.Name = "btn_form_preview";
            this.btn_form_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_form_preview.TabIndex = 7;
            this.btn_form_preview.Text = "Náhled";
            this.btn_form_preview.UseVisualStyleBackColor = true;
            this.btn_form_preview.Click += new System.EventHandler(this.btn_form_preview_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 557);
            this.Controls.Add(this.btn_form_preview);
            this.Controls.Add(this.btn_form_export);
            this.Controls.Add(this.btn_form_load);
            this.Controls.Add(this.btn_form_save);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servisní protokol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_measurements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_general_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_general_measurement_date;
        private System.Windows.Forms.Label lbl_general_protocol_no;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_customer_ic;
        private System.Windows.Forms.Label lbl_customer_postal_code;
        private System.Windows.Forms.Label lbl_customer_address;
        private System.Windows.Forms.Label lbl_customer_name;
        private System.Windows.Forms.Label lbl_device_serial_number;
        private System.Windows.Forms.Label lbl_device_model;
        private System.Windows.Forms.Label lbl_device_manufacturer;
        private System.Windows.Forms.Button btn_measurement_delete;
        private System.Windows.Forms.Button btn_measurement_edit;
        private System.Windows.Forms.Button btn_measurement_add;
        private System.Windows.Forms.DataGridView dgv_measurements;
        private System.Windows.Forms.Button btn_customer_edit;
        private System.Windows.Forms.Button btn_device_edit;
        private System.Windows.Forms.Button btn_form_save;
        private System.Windows.Forms.Button btn_form_load;
        private System.Windows.Forms.Button btn_form_export;
        private System.Windows.Forms.Button btn_form_preview;
    }
}


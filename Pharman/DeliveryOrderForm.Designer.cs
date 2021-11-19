
namespace Pharman
{
    partial class DeliveryOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.drugComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conclusionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.expirationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.loginLabel.Location = new System.Drawing.Point(26, 207);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(135, 21);
            this.loginLabel.TabIndex = 69;
            this.loginLabel.Text = "Количество (шт)";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(475, 322);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 21);
            this.passwordLabel.TabIndex = 68;
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.orderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderButton.Location = new System.Drawing.Point(30, 291);
            this.orderButton.Margin = new System.Windows.Forms.Padding(0);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(206, 41);
            this.orderButton.TabIndex = 65;
            this.orderButton.Text = "ЗАКАЗАТЬ";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // drugComboBox
            // 
            this.drugComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drugComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.drugComboBox.FormattingEnabled = true;
            this.drugComboBox.Location = new System.Drawing.Point(30, 170);
            this.drugComboBox.Name = "drugComboBox";
            this.drugComboBox.Size = new System.Drawing.Size(206, 29);
            this.drugComboBox.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(265, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 72;
            this.label1.Text = "Начало поставок";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conclusionDateTimePicker
            // 
            this.conclusionDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.conclusionDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conclusionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.conclusionDateTimePicker.Location = new System.Drawing.Point(269, 109);
            this.conclusionDateTimePicker.Name = "conclusionDateTimePicker";
            this.conclusionDateTimePicker.Size = new System.Drawing.Size(206, 29);
            this.conclusionDateTimePicker.TabIndex = 73;
            this.conclusionDateTimePicker.Value = new System.DateTime(2021, 6, 27, 13, 46, 51, 0);
            this.conclusionDateTimePicker.ValueChanged += new System.EventHandler(this.conclusionDateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 74;
            this.label3.Text = "Препарат";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // providerComboBox
            // 
            this.providerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(30, 109);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(206, 29);
            this.providerComboBox.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 76;
            this.label2.Text = "Поставщик";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expirationDateTimePicker
            // 
            this.expirationDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expirationDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expirationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expirationDateTimePicker.Location = new System.Drawing.Point(269, 170);
            this.expirationDateTimePicker.Name = "expirationDateTimePicker";
            this.expirationDateTimePicker.Size = new System.Drawing.Size(206, 29);
            this.expirationDateTimePicker.TabIndex = 78;
            this.expirationDateTimePicker.Value = new System.DateTime(2021, 6, 27, 13, 46, 51, 0);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(265, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 77;
            this.label4.Text = "Конец поставок";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(269, 291);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(206, 41);
            this.cancelButton.TabIndex = 79;
            this.cancelButton.Text = "ОТМЕНА";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(24, 30);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(451, 41);
            this.titleLabel.TabIndex = 80;
            this.titleLabel.Text = "Заказ поставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(265, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 82;
            this.label5.Text = "Цена за единицу";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.priceNumericUpDown.Location = new System.Drawing.Point(269, 231);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(206, 29);
            this.priceNumericUpDown.TabIndex = 83;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.amountNumericUpDown.Location = new System.Drawing.Point(30, 231);
            this.amountNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(206, 29);
            this.amountNumericUpDown.TabIndex = 84;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // DeliveryOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(505, 362);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.expirationDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conclusionDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drugComboBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.orderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliveryOrderForm";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharman";
            this.Load += new System.EventHandler(this.DeliveryOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ComboBox drugComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker conclusionDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox providerComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker expirationDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}
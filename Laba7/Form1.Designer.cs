
namespace Laba7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ellipseMode = new System.Windows.Forms.RadioButton();
            this.pentagonMode = new System.Windows.Forms.RadioButton();
            this.lineMode = new System.Windows.Forms.RadioButton();
            this.panel = new System.Windows.Forms.Panel();
            this.redUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fillButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.ellipseMode);
            this.groupBox1.Controls.Add(this.pentagonMode);
            this.groupBox1.Controls.Add(this.lineMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modes";
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(10, 180);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(108, 23);
            this.fillButton.TabIndex = 5;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.OnFillButtonClicked);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(10, 210);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.OnClearButtonClicked);
            // 
            // ellipseMode
            // 
            this.ellipseMode.AutoSize = true;
            this.ellipseMode.Location = new System.Drawing.Point(10, 100);
            this.ellipseMode.Name = "ellipseMode";
            this.ellipseMode.Size = new System.Drawing.Size(55, 17);
            this.ellipseMode.TabIndex = 2;
            this.ellipseMode.Text = "Ellipse";
            this.ellipseMode.UseVisualStyleBackColor = true;
            this.ellipseMode.CheckedChanged += new System.EventHandler(this.OnEllipseModeCheckedChanged);
            // 
            // pentagonMode
            // 
            this.pentagonMode.AutoSize = true;
            this.pentagonMode.Location = new System.Drawing.Point(10, 70);
            this.pentagonMode.Name = "pentagonMode";
            this.pentagonMode.Size = new System.Drawing.Size(71, 17);
            this.pentagonMode.TabIndex = 1;
            this.pentagonMode.Text = "Pentagon";
            this.pentagonMode.UseVisualStyleBackColor = true;
            this.pentagonMode.CheckedChanged += new System.EventHandler(this.OnPentagonModeCheckedChanged);
            // 
            // lineMode
            // 
            this.lineMode.AutoSize = true;
            this.lineMode.Checked = true;
            this.lineMode.Location = new System.Drawing.Point(10, 40);
            this.lineMode.Name = "lineMode";
            this.lineMode.Size = new System.Drawing.Size(45, 17);
            this.lineMode.TabIndex = 0;
            this.lineMode.TabStop = true;
            this.lineMode.Text = "Line";
            this.lineMode.UseVisualStyleBackColor = true;
            this.lineMode.CheckedChanged += new System.EventHandler(this.OnLineModeCheckedChanged);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.OldLace;
            this.panel.Location = new System.Drawing.Point(164, 63);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(815, 458);
            this.panel.TabIndex = 1;
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnPanelMouseClicked);
            // 
            // redUpDown
            // 
            this.redUpDown.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.redUpDown.Location = new System.Drawing.Point(6, 31);
            this.redUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redUpDown.Name = "redUpDown";
            this.redUpDown.Size = new System.Drawing.Size(129, 20);
            this.redUpDown.TabIndex = 2;
            this.redUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.redUpDown.ValueChanged += new System.EventHandler(this.OnUpDownValueChanged);
            // 
            // greenUpDown
            // 
            this.greenUpDown.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.greenUpDown.Location = new System.Drawing.Point(6, 58);
            this.greenUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenUpDown.Name = "greenUpDown";
            this.greenUpDown.Size = new System.Drawing.Size(129, 20);
            this.greenUpDown.TabIndex = 3;
            this.greenUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.greenUpDown.ValueChanged += new System.EventHandler(this.OnUpDownValueChanged);
            // 
            // blueUpDown
            // 
            this.blueUpDown.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.blueUpDown.Location = new System.Drawing.Point(6, 85);
            this.blueUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueUpDown.Name = "blueUpDown";
            this.blueUpDown.Size = new System.Drawing.Size(129, 20);
            this.blueUpDown.TabIndex = 4;
            this.blueUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.blueUpDown.ValueChanged += new System.EventHandler(this.OnUpDownValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.redUpDown);
            this.groupBox2.Controls.Add(this.blueUpDown);
            this.groupBox2.Controls.Add(this.greenUpDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 128);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(991, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pentagonMode;
        private System.Windows.Forms.RadioButton lineMode;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton ellipseMode;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.NumericUpDown redUpDown;
        private System.Windows.Forms.NumericUpDown greenUpDown;
        private System.Windows.Forms.NumericUpDown blueUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


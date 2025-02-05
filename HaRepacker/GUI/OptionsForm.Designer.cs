﻿using HaRepacker.GUI.Input;

namespace HaRepacker.GUI
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.sortBox = new System.Windows.Forms.CheckBox();
            this.loadRelated = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lineBreakBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apngIncompEnable = new System.Windows.Forms.CheckBox();
            this.defXmlFolderEnable = new System.Windows.Forms.CheckBox();
            this.defXmlFolderBox = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.autoAssociateBox = new System.Windows.Forms.CheckBox();
            this.themeColor__comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.indentBox = new HaRepacker.GUI.Input.IntegerInput();
            this.SuspendLayout();
            // 
            // sortBox
            // 
            resources.ApplyResources(this.sortBox, "sortBox");
            this.sortBox.Name = "sortBox";
            this.sortBox.UseVisualStyleBackColor = true;
            // 
            // loadRelated
            // 
            resources.ApplyResources(this.loadRelated, "loadRelated");
            this.loadRelated.Name = "loadRelated";
            this.loadRelated.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lineBreakBox
            // 
            this.lineBreakBox.FormattingEnabled = true;
            this.lineBreakBox.Items.AddRange(new object[] {
            resources.GetString("lineBreakBox.Items"),
            resources.GetString("lineBreakBox.Items1"),
            resources.GetString("lineBreakBox.Items2")});
            resources.ApplyResources(this.lineBreakBox, "lineBreakBox");
            this.lineBreakBox.Name = "lineBreakBox";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // apngIncompEnable
            // 
            resources.ApplyResources(this.apngIncompEnable, "apngIncompEnable");
            this.apngIncompEnable.Name = "apngIncompEnable";
            this.apngIncompEnable.UseVisualStyleBackColor = true;
            // 
            // defXmlFolderEnable
            // 
            resources.ApplyResources(this.defXmlFolderEnable, "defXmlFolderEnable");
            this.defXmlFolderEnable.Name = "defXmlFolderEnable";
            this.defXmlFolderEnable.UseVisualStyleBackColor = true;
            this.defXmlFolderEnable.CheckedChanged += new System.EventHandler(this.defXmlFolderEnable_CheckedChanged);
            // 
            // defXmlFolderBox
            // 
            resources.ApplyResources(this.defXmlFolderBox, "defXmlFolderBox");
            this.defXmlFolderBox.Name = "defXmlFolderBox";
            // 
            // browse
            // 
            resources.ApplyResources(this.browse, "browse");
            this.browse.Name = "browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // autoAssociateBox
            // 
            resources.ApplyResources(this.autoAssociateBox, "autoAssociateBox");
            this.autoAssociateBox.Name = "autoAssociateBox";
            this.autoAssociateBox.UseVisualStyleBackColor = true;
            // 
            // themeColor__comboBox
            // 
            this.themeColor__comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.themeColor__comboBox, "themeColor__comboBox");
            this.themeColor__comboBox.FormattingEnabled = true;
            this.themeColor__comboBox.Items.AddRange(new object[] {
            resources.GetString("themeColor__comboBox.Items"),
            resources.GetString("themeColor__comboBox.Items1")});
            this.themeColor__comboBox.Name = "themeColor__comboBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // indentBox
            // 
            resources.ApplyResources(this.indentBox, "indentBox");
            this.indentBox.Name = "indentBox";
            this.indentBox.Value = 0;
            // 
            // OptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.indentBox);
            this.Controls.Add(this.themeColor__comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadRelated);
            this.Controls.Add(this.autoAssociateBox);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.defXmlFolderBox);
            this.Controls.Add(this.defXmlFolderEnable);
            this.Controls.Add(this.apngIncompEnable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lineBreakBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sortBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox sortBox;
        private System.Windows.Forms.CheckBox loadRelated;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private IntegerInput indentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lineBreakBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox apngIncompEnable;
        private System.Windows.Forms.CheckBox defXmlFolderEnable;
        private System.Windows.Forms.TextBox defXmlFolderBox;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.CheckBox autoAssociateBox;
        private System.Windows.Forms.ComboBox themeColor__comboBox;
        private System.Windows.Forms.Label label3;
    }
}
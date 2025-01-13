namespace CrealityPrintUtil
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.combFilamets1 = new CrealityPrintUtil.CombFilamets();
			this.presetListBox1 = new CrealityPrintUtil.PresetListBox();
			this.SuspendLayout();
			// 
			// combFilamets1
			// 
			this.combFilamets1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.combFilamets1.Location = new System.Drawing.Point(12, 13);
			this.combFilamets1.Name = "combFilamets1";
			this.combFilamets1.PresetType = CrealityPrintUtil.PresetType.System;
			this.combFilamets1.Size = new System.Drawing.Size(776, 20);
			this.combFilamets1.TabIndex = 11;
			// 
			// presetListBox1
			// 
			this.presetListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.presetListBox1.CombFilamets = this.combFilamets1;
			this.presetListBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.presetListBox1.Location = new System.Drawing.Point(12, 41);
			this.presetListBox1.Name = "presetListBox1";
			this.presetListBox1.Size = new System.Drawing.Size(776, 397);
			this.presetListBox1.TabIndex = 10;
			this.presetListBox1.Text = "presetListBox1";
			// 
			// Form1
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.combFilamets1);
			this.Controls.Add(this.presetListBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "CrealityPrintUtil profile view";
			this.ResumeLayout(false);

		}

		#endregion
		private PresetListBox presetListBox1;
		private CombFilamets combFilamets1;
	}
}


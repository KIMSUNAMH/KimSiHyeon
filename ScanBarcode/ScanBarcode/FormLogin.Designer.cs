
namespace ScanBarcode
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.edtBoxLoginPw = new DevExpress.XtraEditors.TextEdit();
            this.btnLoginSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LookUpEditLogin = new DevExpress.XtraEditors.SearchLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.edtBoxLoginPw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditLogin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(42, 121);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "아이디 :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 164);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "비밀번호 :";
            // 
            // edtBoxLoginPw
            // 
            this.edtBoxLoginPw.Location = new System.Drawing.Point(97, 161);
            this.edtBoxLoginPw.Name = "edtBoxLoginPw";
            this.edtBoxLoginPw.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.edtBoxLoginPw.Properties.Appearance.Options.UseFont = true;
            this.edtBoxLoginPw.Properties.PasswordChar = '*';
            this.edtBoxLoginPw.Size = new System.Drawing.Size(100, 20);
            this.edtBoxLoginPw.TabIndex = 2;
            // 
            // btnLoginSubmit
            // 
            this.btnLoginSubmit.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoginSubmit.Appearance.Options.UseFont = true;
            this.btnLoginSubmit.Image = global::ScanBarcode.Properties.Resources._164705___accept_allow_apply_check_dialog_good_green_mark_ok_32;
            this.btnLoginSubmit.Location = new System.Drawing.Point(214, 111);
            this.btnLoginSubmit.Name = "btnLoginSubmit";
            this.btnLoginSubmit.Size = new System.Drawing.Size(93, 34);
            this.btnLoginSubmit.TabIndex = 4;
            this.btnLoginSubmit.Text = "로그인";
            this.btnLoginSubmit.Click += new System.EventHandler(this.btnLoginSubmit_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = global::ScanBarcode.Properties.Resources._164847___delete_entry_no_vote_32;
            this.simpleButton2.Location = new System.Drawing.Point(214, 154);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(93, 34);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "취소";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // LookUpEditLogin
            // 
            this.LookUpEditLogin.EditValue = "";
            this.LookUpEditLogin.Location = new System.Drawing.Point(97, 118);
            this.LookUpEditLogin.Name = "LookUpEditLogin";
            this.LookUpEditLogin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEditLogin.Properties.DisplayMember = "성명";
            this.LookUpEditLogin.Properties.ValueMember = "아이디";
            this.LookUpEditLogin.Properties.View = this.searchLookUpEdit1View;
            this.LookUpEditLogin.Size = new System.Drawing.Size(100, 20);
            this.LookUpEditLogin.TabIndex = 3;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(326, 208);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnLoginSubmit);
            this.Controls.Add(this.LookUpEditLogin);
            this.Controls.Add(this.edtBoxLoginPw);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            ((System.ComponentModel.ISupportInitialize)(this.edtBoxLoginPw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEditLogin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit edtBoxLoginPw;
        private DevExpress.XtraEditors.SimpleButton btnLoginSubmit;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit LookUpEditLogin;
    }
}
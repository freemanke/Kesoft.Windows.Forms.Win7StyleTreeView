namespace Kesoft.Windows.Forms.Win7StyleTreeView.Tests
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("中华人民共和国");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("美国");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("英国");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("澳大利亚");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("国家和地区", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.win7StyleTreeView1 = new Kesoft.Windows.Forms.Win7StyleTreeView.Win7StyleTreeView(this.components);
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // win7StyleTreeView1
            // 
            this.win7StyleTreeView1.FullRowSelect = true;
            this.win7StyleTreeView1.HotTracking = true;
            this.win7StyleTreeView1.ItemHeight = 24;
            this.win7StyleTreeView1.Location = new System.Drawing.Point(13, 12);
            this.win7StyleTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.win7StyleTreeView1.Name = "win7StyleTreeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "中华人民共和国";
            treeNode2.Name = "Node2";
            treeNode2.Text = "美国";
            treeNode3.Name = "Node3";
            treeNode3.Text = "英国";
            treeNode4.Name = "Node4";
            treeNode4.Text = "澳大利亚";
            treeNode5.Name = "Node0";
            treeNode5.Text = "国家和地区";
            this.win7StyleTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.win7StyleTreeView1.ShowLines = false;
            this.win7StyleTreeView1.Size = new System.Drawing.Size(198, 348);
            this.win7StyleTreeView1.TabIndex = 0;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(218, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(424, 348);
            this.propertyGrid1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 374);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.win7StyleTreeView1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Win7StyleTreeView Tests";
            this.ResumeLayout(false);

        }

        #endregion

        private Win7StyleTreeView win7StyleTreeView1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}


﻿namespace pkl_app_1_jude.SpaceInvaders
{
    partial class SpaceInvadersForm
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
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.ActorMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruActorTimer = new System.Windows.Forms.Timer(this.components);
            this.PeluruEnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyBulletPic = new System.Windows.Forms.PictureBox();
            this.ExplosionPic = new System.Windows.Forms.PictureBox();
            this.PeluruPic = new System.Windows.Forms.PictureBox();
            this.ActorPic = new System.Windows.Forms.PictureBox();
            this.Enemy3Pic = new System.Windows.Forms.PictureBox();
            this.Enemy2Pic = new System.Windows.Forms.PictureBox();
            this.Enemy1Pic = new System.Windows.Forms.PictureBox();
            this.SpaceBoard = new System.Windows.Forms.PictureBox();
            this.PeluruEnemyTembakTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBulletPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeluruPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Enabled = true;
            this.EnemyMoveTimer.Interval = 500;
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMoveTimer_Tick);
            // 
            // ActorMoveTimer
            // 
            this.ActorMoveTimer.Enabled = true;
            this.ActorMoveTimer.Interval = 50;
            this.ActorMoveTimer.Tick += new System.EventHandler(this.ActorMoveTimer_Tick);
            // 
            // PeluruActorTimer
            // 
            this.PeluruActorTimer.Enabled = true;
            this.PeluruActorTimer.Interval = 25;
            this.PeluruActorTimer.Tick += new System.EventHandler(this.PeluruActorTimer_Tick);
            // 
            // PeluruEnemyMoveTimer
            // 
            this.PeluruEnemyMoveTimer.Enabled = true;
            this.PeluruEnemyMoveTimer.Interval = 200;
            this.PeluruEnemyMoveTimer.Tick += new System.EventHandler(this.PeluruEnemyTimer_Tick);
            // 
            // EnemyBulletPic
            // 
            this.EnemyBulletPic.Image = global::pkl_app_1_jude.Properties.Resources.EnemyBullet;
            this.EnemyBulletPic.Location = new System.Drawing.Point(296, 418);
            this.EnemyBulletPic.Name = "EnemyBulletPic";
            this.EnemyBulletPic.Size = new System.Drawing.Size(47, 46);
            this.EnemyBulletPic.TabIndex = 7;
            this.EnemyBulletPic.TabStop = false;
            this.EnemyBulletPic.Visible = false;
            // 
            // ExplosionPic
            // 
            this.ExplosionPic.Image = global::pkl_app_1_jude.Properties.Resources.Explosion48;
            this.ExplosionPic.Location = new System.Drawing.Point(243, 418);
            this.ExplosionPic.Name = "ExplosionPic";
            this.ExplosionPic.Size = new System.Drawing.Size(47, 46);
            this.ExplosionPic.TabIndex = 6;
            this.ExplosionPic.TabStop = false;
            this.ExplosionPic.Visible = false;
            // 
            // PeluruPic
            // 
            this.PeluruPic.Image = global::pkl_app_1_jude.Properties.Resources.Bullet1;
            this.PeluruPic.Location = new System.Drawing.Point(216, 418);
            this.PeluruPic.Name = "PeluruPic";
            this.PeluruPic.Size = new System.Drawing.Size(21, 32);
            this.PeluruPic.TabIndex = 5;
            this.PeluruPic.TabStop = false;
            this.PeluruPic.Visible = false;
            // 
            // ActorPic
            // 
            this.ActorPic.Image = global::pkl_app_1_jude.Properties.Resources.PlayerBlue;
            this.ActorPic.Location = new System.Drawing.Point(150, 418);
            this.ActorPic.Name = "ActorPic";
            this.ActorPic.Size = new System.Drawing.Size(60, 32);
            this.ActorPic.TabIndex = 4;
            this.ActorPic.TabStop = false;
            this.ActorPic.Visible = false;
            // 
            // Enemy3Pic
            // 
            this.Enemy3Pic.Image = global::pkl_app_1_jude.Properties.Resources.Enemy3Yellow;
            this.Enemy3Pic.Location = new System.Drawing.Point(104, 418);
            this.Enemy3Pic.Name = "Enemy3Pic";
            this.Enemy3Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy3Pic.TabIndex = 3;
            this.Enemy3Pic.TabStop = false;
            this.Enemy3Pic.Visible = false;
            // 
            // Enemy2Pic
            // 
            this.Enemy2Pic.Image = global::pkl_app_1_jude.Properties.Resources.Enemy2Green;
            this.Enemy2Pic.Location = new System.Drawing.Point(58, 418);
            this.Enemy2Pic.Name = "Enemy2Pic";
            this.Enemy2Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy2Pic.TabIndex = 2;
            this.Enemy2Pic.TabStop = false;
            this.Enemy2Pic.Visible = false;
            // 
            // Enemy1Pic
            // 
            this.Enemy1Pic.Image = global::pkl_app_1_jude.Properties.Resources.Enemy1Red;
            this.Enemy1Pic.Location = new System.Drawing.Point(12, 418);
            this.Enemy1Pic.Name = "Enemy1Pic";
            this.Enemy1Pic.Size = new System.Drawing.Size(40, 32);
            this.Enemy1Pic.TabIndex = 1;
            this.Enemy1Pic.TabStop = false;
            this.Enemy1Pic.Visible = false;
            // 
            // SpaceBoard
            // 
            this.SpaceBoard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SpaceBoard.Location = new System.Drawing.Point(12, 12);
            this.SpaceBoard.Name = "SpaceBoard";
            this.SpaceBoard.Size = new System.Drawing.Size(800, 400);
            this.SpaceBoard.TabIndex = 0;
            this.SpaceBoard.TabStop = false;
            this.SpaceBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.SpaceBoard_Paint);
            // 
            // PeluruEnemyTembakTimer
            // 
            this.PeluruEnemyTembakTimer.Enabled = true;
            this.PeluruEnemyTembakTimer.Interval = 4000;
            this.PeluruEnemyTembakTimer.Tick += new System.EventHandler(this.PeluruEnemyTembakTimer_Tick);
            // 
            // SpaceInvadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 469);
            this.Controls.Add(this.EnemyBulletPic);
            this.Controls.Add(this.ExplosionPic);
            this.Controls.Add(this.PeluruPic);
            this.Controls.Add(this.ActorPic);
            this.Controls.Add(this.Enemy3Pic);
            this.Controls.Add(this.Enemy2Pic);
            this.Controls.Add(this.Enemy1Pic);
            this.Controls.Add(this.SpaceBoard);
            this.KeyPreview = true;
            this.Name = "SpaceInvadersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SpaceInvadersForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceInvadersForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SpaceInvadersForm_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.SpaceInvadersForm_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBulletPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeluruPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceBoard;
        private System.Windows.Forms.PictureBox Enemy1Pic;
        private System.Windows.Forms.PictureBox Enemy2Pic;
        private System.Windows.Forms.PictureBox Enemy3Pic;
        private System.Windows.Forms.PictureBox ActorPic;
        private System.Windows.Forms.Timer EnemyMoveTimer;
        private System.Windows.Forms.Timer ActorMoveTimer;
        private System.Windows.Forms.Timer PeluruActorTimer;
        private System.Windows.Forms.PictureBox PeluruPic;
        private System.Windows.Forms.PictureBox ExplosionPic;
        private System.Windows.Forms.Timer PeluruEnemyMoveTimer;
        private System.Windows.Forms.PictureBox EnemyBulletPic;
        private System.Windows.Forms.Timer PeluruEnemyTembakTimer;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Animation
{
    public partial class AnimationCtrl : UserControl
    {
        CharacterCtrl characterCtrl;

        List<Bitmap> listBitmap;
        private int currentFrame;
        private int loopCount;
        private int loopCounter;
        private int frameCount;
        private Timer fTimer;
        public int leftOffset = 0;
        public int upOffset = 0;
        bool isCharacter = true;

        public AnimationCtrl()
        {
            InitializeComponent();
            characterCtrl = new CharacterCtrl();
            fTimer = new Timer();
            fTimer.Tick += new System.EventHandler(this.timer1_Tick);
        }

        public void Start()
        {
            characterCtrl.IdleAnimation(this);
        }

        public void InputImg(string folderLocation)
        {
            listBitmap = new List<Bitmap>();
            for (int i = 1; ; i++)
            {
                string path = Path.Combine(folderLocation, i + ".png");
                if (File.Exists(path))
                {
                    listBitmap.Add(new Bitmap(path));
                }
                else break;
            }
        }

        public void StartAnimation(int DelayInterval, int LoopCount)
        {
            leftOffset = 0;
            upOffset = 0;
            this.picBox.Location = this.Location;
            this.Size = new Size(listBitmap[0].Width, listBitmap[0].Height);
            loopCount = LoopCount;
            loopCounter = 0;
            frameCount = listBitmap.Count;
            fTimer.Interval = DelayInterval;
            fTimer.Enabled = true;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (loopCount == -1)
            {
                this.DrawFrame();
            }
            else
            {
                if (loopCount == loopCounter)
                {
                    fTimer.Enabled = false;
                    if (isCharacter)
                        characterCtrl.IdleAnimation(this);
                    else
                    {
                        //characterCtrl.SkillBumb(this);
                        //System.Threading.Thread.Sleep(1000);
                        //picBox.Visible = false;
                    }
                }
                else
                    this.DrawFrame();
            }
        }

        private void DrawFrame()
        {
            if (currentFrame < frameCount - 1)
            {
                currentFrame++;
            }
            else
            {
                loopCounter++;
                currentFrame = 0;
            }
            Draw(currentFrame);
        }

        private void Draw(int iframe)
        {
            picBox.Refresh();
            picBox.Left += leftOffset;
            picBox.Top += upOffset;
            picBox.Image = listBitmap[iframe];
        }

        public void ChooseAnimation(Keys keyCode)
        {
            //fTimer.Enabled = false;
            characterCtrl.Animation(keyCode, this);
        }

        public void AnimationSkill()
        {
            isCharacter = false;
            picBox.Visible = true;
            characterCtrl.SkillFly(this);
        }
    }
}

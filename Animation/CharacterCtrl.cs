using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    class CharacterCtrl
    {
        public void Animation(Keys keyCode, AnimationCtrl animationCtrl)
        {
            switch (keyCode)
            {
                case Keys.Left:
                    MoveLeftAnimation(animationCtrl);
                    break;

                case Keys.Right:
                    MoveRightAnimation(animationCtrl);
                    break;

                case Keys.A:
                    PunchAnimation(animationCtrl);
                    break;

                case Keys.Space:
                    JumpAnimation(animationCtrl);
                    break;

                case Keys.S:
                    SkillAnimation(animationCtrl);
                    break;

                default:
                    IdleAnimation(animationCtrl);
                    break;
            }
        }

        public void MoveLeftAnimation(AnimationCtrl animationCtrl)
        {
            animationCtrl.StartAnimation(100, 1);
            animationCtrl.leftOffset = -1;
        }

        public void MoveRightAnimation(AnimationCtrl animationCtrl)
        {
            animationCtrl.StartAnimation(100, 1);
            animationCtrl.leftOffset = 1;
        }
        
        public void IdleAnimation(AnimationCtrl animationCtrl)
        {
            animationCtrl.InputImg(@"..\..\Animation\Idle\");
            animationCtrl.StartAnimation(100, 100);
        }

        public void PunchAnimation(AnimationCtrl animationCtrl)
        {
            animationCtrl.InputImg(@"..\..\Animation\Punch\");
            animationCtrl.StartAnimation(100, 1);
        }

        public void JumpAnimation(AnimationCtrl animationCtrl)
        {
            animationCtrl.InputImg(@"..\..\Animation\Jump\");
            animationCtrl.StartAnimation(100, 1);
        }

        public void SkillAnimation(AnimationCtrl animationCtrl)
        {
            animationCtrl.InputImg(@"..\..\Animation\Skill\");
            animationCtrl.StartAnimation(100, 1);
        }

        public void SkillFly(AnimationCtrl animationCtrl)
        {
            animationCtrl.InputImg(@"..\..\Animation\Kamehameha\Fly");
            animationCtrl.StartAnimation(100, 20);
            animationCtrl.leftOffset = 5;
        }

        public void SkillBumb(AnimationCtrl animationCtrl)
        {
            animationCtrl.InputImg(@"..\..\Animation\Kamehameha\Bumb");
            animationCtrl.StartAnimation(100, 1);
        }
    }
}

using ThirdPersonScripts;
using UnityEngine;

namespace Skills
{
    public class EnemiesFlash : Skill
    {
        public override SkillsEnum GetSkillName()
        {
            return SkillsEnum.EnemiesFlash;
        }

        protected override void Action(GameObject enemy)
        {
        }

        protected override void StartAnimation()
        {
            throw new System.NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Question3
{
    class Humanoid
    {
        private Skills skills;
        public Humanoid()
        {
            skills = new Skills();
        }
        public Humanoid(Skills skills)
        {

            this.skills = skills;
        }
        public string ShowSkill()
        {
            return skills.get_skill_name();
        }
    }
}

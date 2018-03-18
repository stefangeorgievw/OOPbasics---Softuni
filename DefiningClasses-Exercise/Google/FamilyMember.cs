﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    class FamilyMember
    {
        private string name;
        private string birthday;

        public FamilyMember(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            return $"{this.name} {this.birthday}";
        }
    }
}

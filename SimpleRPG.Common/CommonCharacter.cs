﻿using SimpleRPG.Entity.Model.Character;
using SimpleRPG.Entity.Model.Character.Fabric;

namespace SimpleRPG.Common
{
    public class CommonCharacter
    {
        public Character Character { get; set; }

        public bool CreateCharacter(BasicSheet sheet )
        {
            NewCharacter newCharacter = new NewCharacter();
            
            Character = newCharacter.Get(sheet);

            return true;
        }
    }
}
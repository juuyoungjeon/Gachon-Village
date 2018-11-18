﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SQL_Library;
namespace MainServer
{
    static partial class Function
    {
        public static void NPC_Action(NPC npc, User user)
        {
            user.ToChatMessage(npc.function + "를 선택", ChatType.System);
            if (npc.function == "우편함 열기")
            {
                PostSystem.GetPage(user, 1);

            }
        }
    }
}

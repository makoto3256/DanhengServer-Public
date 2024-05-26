﻿using EggLink.DanhengServer.Proto;

namespace EggLink.DanhengServer.Server.Packet.Send.Scene
{
    public class PacketSetGroupCustomSaveDataScRsp : BasePacket
    {
        public PacketSetGroupCustomSaveDataScRsp(uint entryId, uint groupId) : base(CmdIds.SetGroupCustomSaveDataScRsp)
        {
            var proto = new SetGroupCustomSaveDataScRsp()
            {
                EntryId = entryId,
                GroupId = groupId
            };
            SetData(proto);
        }
    }
}

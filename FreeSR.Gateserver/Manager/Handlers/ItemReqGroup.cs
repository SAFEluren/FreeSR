﻿namespace FreeSR.Gateserver.Manager.Handlers
{
    using FreeSR.Gateserver.Manager.Handlers.Core;
    using FreeSR.Gateserver.Network;
    using FreeSR.Proto;
    internal static class ItemReqGroup
    {
        [Handler(CmdType.GetBagCsReq)]
        public static void OnGetBagCsReq(NetSession session, int cmdId, object _)
        {
            session.Send(CmdType.GetBagScRsp, new GetBagScRsp
            {
                Retcode = Retcode.RETCODE_RET_SUCC,
                MaterialList = new List<Material>
                {
                    new Material
                    {
                        Tid = 10,
                        Num = 101
                    },
                    new Material
                    {
                        Tid = 10,
                        Num = 102
                    }
                }
            });
        }
    }
}

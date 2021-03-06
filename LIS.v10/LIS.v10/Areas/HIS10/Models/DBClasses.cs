﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LIS.v10.Areas.HIS10.Models
{
    public class SmsNotificationItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public class SmsNotificationMsg
    {
        public int Id { get; set; }
        public string MessageBody { get; set; }
    }

    public class NotificationLog
    {
        public int Id { get; set; }
        public String HisNotificationId { get; set; }
        public string DtSending { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
    }



    public class DBClasses
    {
        private Models.His10DBContainer db = new His10DBContainer();
        public List<SmsNotificationItem> getList()
        {
            List<SmsNotificationItem> hisrequests = db.HisRequests
                .Select(s => new SmsNotificationItem { Id = s.Id, Description = s.Description })
                .ToList();

            return hisrequests;
        }

        public SmsNotificationMsg getAdminMessage(int id)
        {
            HisRequest request = db.HisRequests.Find(id);

            SmsNotificationMsg msg = new SmsNotificationMsg
            {
                    Id = request.Id,
                    MessageBody = request.Title
                };

            return msg;
        }

        public SmsNotificationMsg getClientMessage(int id)
        {
            HisRequest request = db.HisRequests.Find(id);
            SmsNotificationMsg msg = new SmsNotificationMsg
            {
                Id = request.Id,
                MessageBody = request.Title
            };

            return msg;
        }

        public int updateItemStatus(int status)
        {
            return 1;
        }

        public List<HisNotificationLog> getNotificationLogs(int? id)
        {
            string sSQL = @"
                SELECT TOP 1000 [Id]
                      ,[HisNotificationId]
                      ,[DtSending]
                      ,[Status]
                      ,[Remarks]
                  FROM [aspnet-LIS.v10-20170509105835].[dbo].[HisNotificationLogs]";

            var list = db.Database.SqlQuery<HisNotificationLog>(sSQL);

            if (id != null && id > 0)
                return list.Where(d => d.HisNotificationId == (int)id).ToList();

            return list.ToList();
        }
    }
}
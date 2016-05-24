using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MotoMy.Models;
using MotoMy.Globals;
using System.IO;
using System.Data.Objects;

namespace MotoMy.Controllers
{
    public class GeneralController : Controller
    {
        protected MOTOMYEntities db = null;

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            db = new MOTOMYEntities();
            base.Initialize(requestContext);
        }
    }
    public class AuthorizedController : GeneralController
    {
       
/*
        protected Custom_Request CreateCustomRequestProp(Custom_Request request)
        {
            request.RecordStatus = 1;
            request.AuditNumber = 1;
            request.CreationDate = SharedMethod.DateToInt(DateTime.Now);
            request.CreationTime = SharedProperty.MinutesOfDay;
            request.CreationUser = SessionHandler.ActiveUser.LotusNotesID;
            request.ModifyDate = SharedMethod.DateToInt(DateTime.Now);
            request.ModifyTime = SharedProperty.MinutesOfDay;
            request.ModifyUser = SessionHandler.ActiveUser.LotusNotesID;
            request.ModifyReason = "Created";
            return request;
        }


        [HttpGet]
        public FileContentResult OpenFile(string BLOBID)
        {
            BLOB rec = db.BLOBs.Single(x => x.BLOBID == BLOBID);
            return File(rec.Data, rec.BLOBText2, rec.Filename);
        }

        [HttpGet]
        public FileContentResult DownloadFile(string BLOBID)
        {
            BLOB rec = db.BLOBs.Single(x => x.BLOBID == BLOBID);
            string mimeType = rec.BLOBText2;
            Response.AppendHeader("Content-Disposition", "inline; filename=" + rec.Filename);
            return File(rec.Data, mimeType);
        }

        public void AddAttachment(HttpPostedFileBase attachment, string reqCode, string Text10, string SourceKey)
        {
            MemoryStream target = new MemoryStream();
            attachment.InputStream.CopyTo(target);
            byte[] data = target.ToArray();

            BLOB newBLOB = new BLOB();

            ObjectResult<string> blobCode = db.sp_GenerateCounter("BlobID");
            newBLOB.BLOBID = blobCode.First();
            newBLOB.BLOBText1 = reqCode;
            newBLOB.BLOBText10 = Text10;
            newBLOB.Data = data;
            newBLOB.AuditNumber = 1;
            newBLOB.SourceKey1 = SourceKey;
            newBLOB.SourceRefType = 29;
            newBLOB.BLOBStatus = 10;
            newBLOB.FileAttributesReadOnly = 0;
            newBLOB.FileAttributesHidden = 0;
            newBLOB.FileAttributesArchive = 0;
            newBLOB.FileAttributesSystem = 0;
            newBLOB.AuditFlag = 0;
            newBLOB.AssociatedApplication = "0";
            newBLOB.ReExported = 0;
            newBLOB.Filename = attachment.FileName;
            newBLOB.BLOBText2 = attachment.ContentType;
            db.BLOBs.Add(newBLOB);
        }

        public String AddAttachmentGetCode(HttpPostedFileBase attachment, string reqCode, string Text10, string SourceKey)
        {
            MemoryStream target = new MemoryStream();
            attachment.InputStream.CopyTo(target);
            byte[] data = target.ToArray();

            BLOB newBLOB = new BLOB();

            ObjectResult<string> blobCode = db.sp_GenerateCounter("BlobID");
            newBLOB.BLOBID = blobCode.First();
            newBLOB.BLOBText1 = reqCode;
            newBLOB.BLOBText10 = Text10;
            newBLOB.Data = data;
            newBLOB.AuditNumber = 1;
            newBLOB.SourceKey1 = SourceKey;
            newBLOB.SourceRefType = 29;
            newBLOB.BLOBStatus = 10;
            newBLOB.FileAttributesReadOnly = 0;
            newBLOB.FileAttributesHidden = 0;
            newBLOB.FileAttributesArchive = 0;
            newBLOB.FileAttributesSystem = 0;
            newBLOB.AuditFlag = 0;
            newBLOB.AssociatedApplication = "0";
            newBLOB.ReExported = 0;
            newBLOB.Filename = attachment.FileName;
            newBLOB.BLOBText2 = attachment.ContentType;
            db.BLOBs.Add(newBLOB);
            return newBLOB.BLOBID;
        }

        public ActionResult DeleteAttachment(string blobID)
        {
            BLOB rec = db.BLOBs.SingleOrDefault(x => x.BLOBID == blobID);
            db.BLOBs.Remove(rec);
            db.SaveChanges();
            return Redirect(HttpContext.Request.UrlReferrer.ToString());
        }
        */
    
      
    }
}

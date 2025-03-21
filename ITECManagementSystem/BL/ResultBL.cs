using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class ResultBL
    {
        ResultDL resultDL = new ResultDL();
        public List<ResultRecord> GetResults()
        {
            return resultDL.GetResults();
        }
        public bool SaveResult(ResultRecord result)
        {
            if (result == null)
                throw new Exception("Result cannot be null.");
            if (string.IsNullOrWhiteSpace(result.EventName))
                throw new Exception("Event name is required.");
            if (resultDL.InsertResult(result))
            {
                return true;
            }
            return false;
        }
        public bool UpdateResult(ResultRecord result)
        {
            if (result == null || result.ResultId <= 0)
                throw new Exception("Invalid result selection.");
            if (resultDL.UpdateResult(result))
            {
                return true;
            }
            return false;
        }
        public bool DeleteResult(int resultID)
        {
            if (resultID <= 0)
                throw new Exception("Invalid result selection.");
            if (resultDL.DeleteResult(resultID))
            {
                return true;
            }
            return false;
        }
    }
}

using DemoApplication.Base;
using DemoApplication.Entity;
using System;
using System.Collections.Generic;

namespace DemoApplication.Provider
{
    public class PersonProvider : DotNetTNBase
    {
        private DotNetTN.Connector.DotNetTNConnector DotNetTNConnector = new DotNetTN.Connector.DotNetTNConnector(GetInstance());

        public void Add(Person insertObj)
        {
            try
            {
                DotNetTNConnector.Insert(insertObj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Person> GetLists()
        {
            try
            {
                return DotNetTNConnector.GetList<Person>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
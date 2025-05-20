/*
' Copyright (c) 2025 TegnapraKV
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace Dnn.TegnapraKV.Dnn.TegnapraKV.RandomRecept.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Dnn.TegnapraKV.RandomRecept
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Dnn.TegnapraKV.RandomReceptInfo> colDnn.TegnapraKV.RandomRecepts = GetDnn.TegnapraKV.RandomRecepts(ModuleID);
        //if (colDnn.TegnapraKV.RandomRecepts.Count != 0)
        //{
        //    strXML += "<Dnn.TegnapraKV.RandomRecepts>";

        //    foreach (Dnn.TegnapraKV.RandomReceptInfo objDnn.TegnapraKV.RandomRecept in colDnn.TegnapraKV.RandomRecepts)
        //    {
        //        strXML += "<Dnn.TegnapraKV.RandomRecept>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnn.TegnapraKV.RandomRecept.Content) + "</content>";
        //        strXML += "</Dnn.TegnapraKV.RandomRecept>";
        //    }
        //    strXML += "</Dnn.TegnapraKV.RandomRecepts>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDnn.TegnapraKV.RandomRecepts = DotNetNuke.Common.Globals.GetContent(Content, "Dnn.TegnapraKV.RandomRecepts");
        //foreach (XmlNode xmlDnn.TegnapraKV.RandomRecept in xmlDnn.TegnapraKV.RandomRecepts.SelectNodes("Dnn.TegnapraKV.RandomRecept"))
        //{
        //    Dnn.TegnapraKV.RandomReceptInfo objDnn.TegnapraKV.RandomRecept = new Dnn.TegnapraKV.RandomReceptInfo();
        //    objDnn.TegnapraKV.RandomRecept.ModuleId = ModuleID;
        //    objDnn.TegnapraKV.RandomRecept.Content = xmlDnn.TegnapraKV.RandomRecept.SelectSingleNode("content").InnerText;
        //    objDnn.TegnapraKV.RandomRecept.CreatedByUser = UserID;
        //    AddDnn.TegnapraKV.RandomRecept(objDnn.TegnapraKV.RandomRecept);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Dnn.TegnapraKV.RandomReceptInfo> colDnn.TegnapraKV.RandomRecepts = GetDnn.TegnapraKV.RandomRecepts(ModInfo.ModuleID);

        //foreach (Dnn.TegnapraKV.RandomReceptInfo objDnn.TegnapraKV.RandomRecept in colDnn.TegnapraKV.RandomRecepts)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnn.TegnapraKV.RandomRecept.Content, objDnn.TegnapraKV.RandomRecept.CreatedByUser, objDnn.TegnapraKV.RandomRecept.CreatedDate, ModInfo.ModuleID, objDnn.TegnapraKV.RandomRecept.ItemId.ToString(), objDnn.TegnapraKV.RandomRecept.Content, "ItemId=" + objDnn.TegnapraKV.RandomRecept.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}

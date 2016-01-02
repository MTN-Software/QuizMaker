using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuizMaker
{
    /// <summary>
    /// Makes the document that contains the xml
    /// is a singleton so that one instance can be passed around.
    /// uses multithreaded implementation of a singleton just incase
    /// </summary>
    public sealed class DocumentMaker
    {
        #region Members
        const string docHeader = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> ";
        XDocument xDocument;
        private static volatile DocumentMaker instance; // volatile ensures that the 
                                                        // assignment to the instance 
                                                        // variable is completed before
                                                        // the instance variable can be
                                                        // accessed.

        private static object syncRoot = new object();  // lock on syncRoot instance, rather than
                                                        // the type itself to prevent deadlocks
        #endregion

        #region Constructor
        private DocumentMaker()
        {
            xDocument = null;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Opens the xml doc and sets the xDocument variable to the new XDocument.
        /// </summary>
        /// <param name="file">The location of the file.</param>
        public void Open(string file)
        {
            XDoc = XDocument.Load(file);
        }
        #endregion

        #region Properties
        /// <summary>
        /// The singleton instance of the class.
        /// </summary>
        public static DocumentMaker Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new DocumentMaker();
                    }
                    
                }
                return instance;
            }
        }

        /// <summary>
        /// The property for the xml document.
        /// </summary>
        public XDocument XDoc
        {
            get { return xDocument; }
            set
            {
                xDocument = value;
            }
        }
        #endregion

    }
}

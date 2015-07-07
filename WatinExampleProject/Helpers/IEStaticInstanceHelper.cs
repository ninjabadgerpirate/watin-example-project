using System.Threading;
using WatiN.Core;

namespace WatinExampleProject.Helpers
{
    public class IEStaticInstanceHelper
    {
        private IE _ie;
        private int _ieThread;

        public IE IE
        {
            get
            {
                var currentThreadId = GetCurrentThreadId();
                if (currentThreadId == _ieThread) return _ie;
                if (Browser.Exists<IE>(Find.Any))
                {
                    _ie = Browser.AttachTo<IE>(Find.Any);
                }
                else
                {
                    _ie = new IE();
                }

                _ieThread = currentThreadId;
                return _ie;
            }
            set
            {
                _ie = value;
                _ieThread = GetCurrentThreadId();
            }
        }

        private int GetCurrentThreadId()
        {
            return Thread.CurrentThread.GetHashCode();
        }
    }
}

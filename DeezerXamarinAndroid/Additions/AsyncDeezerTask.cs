using Android.OS;
using Deezer.Connect;
using Deezer.Network.Request.Event;
using Java.Lang;

namespace Deezer.Network.Request
{
    public class AsyncDeezerTask : AsyncTask<DeezerRequest, Void, string>
    {
        private DeezerConnect deezerConnect;
        private IRequestListener requestListener;
        private Object requestId;
        private Exception exception;

        public AsyncDeezerTask (DeezerConnect deezerConnect, IRequestListener requestListener)
        {
            this.deezerConnect = deezerConnect;
            this.requestListener = requestListener;
        }

        protected override string RunInBackground (params DeezerRequest [] requestList)
        {
            if (requestList == null || requestList.Length != 1 || requestList [0] == null)
            {
                throw new IllegalArgumentException ("AsyncDeezerTask executes only on request, and doesn't support null requests.");
            }

            DeezerRequest request = requestList [0];
            requestId = request.Id;
            exception = null;
            try
            {
                return deezerConnect.RequestSync (request);
            }
            catch (Exception localException)
            {
                exception = localException;
                return localException.ToString ();
            }
        }

        protected override void OnPostExecute (string response)
        {
            base.OnPostExecute (response);

            if (exception == null)
            {
                requestListener.OnComplete (response, requestId);
                return;
            }

            requestListener.OnException (exception, requestId);
        }
    }
}
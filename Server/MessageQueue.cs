using System.Collections.Concurrent;

namespace Server
{
    public class MessageQueue
    {
        private static readonly MessageQueue instance = new MessageQueue();

        public static MessageQueue Instance
        {
            get { return instance; }
        }

        public readonly ConcurrentQueue<string> MessageLog = new ConcurrentQueue<string>();
        public readonly ConcurrentQueue<string> DebugLog = new ConcurrentQueue<string>();
        public readonly ConcurrentQueue<string> ChatLog = new ConcurrentQueue<string>();
        public readonly ConcurrentQueue<string> ErrorLog = new ConcurrentQueue<string>();
        public readonly ConcurrentQueue<string> RechargeLog = new ConcurrentQueue<string>();
        public MessageQueue() { }

        public void Enqueue(string msg)
        {
            if (MessageLog.Count < 100)
                MessageLog.Enqueue(String.Format("[{0}]: {1}" + Environment.NewLine, DateTime.Now, msg));

            Logger.GetLogger(LogType.Server).Info(msg);
        }

        public void Enqueue(Exception ex)
        {
            if (MessageLog.Count < 100)
                MessageLog.Enqueue(String.Format("[{0}]: {1} - {2}" + Environment.NewLine, DateTime.Now, ex.TargetSite, ex));

            Logger.GetLogger(LogType.Server).Error(ex);
        }

        public void EnqueueDebugging(string msg)
        {
            if (DebugLog.Count < 100)
                DebugLog.Enqueue(String.Format("[{0}]: {1}" + Environment.NewLine, DateTime.Now, msg));

            Logger.GetLogger(LogType.Debug).Debug(msg);
        }

        public void EnqueueChat(string msg)
        {
            if (ChatLog.Count < 100)
                ChatLog.Enqueue(String.Format("[{0}]: {1}" + Environment.NewLine, DateTime.Now, msg));

            Logger.GetLogger(LogType.Chat).Info(msg);
        }
        public void EnqueueError(string msg)
        {
            if (ErrorLog.Count < 100)
                ErrorLog.Enqueue(String.Format("[{0}]: {1}" + Environment.NewLine, DateTime.Now, msg));

            Logger.GetLogger(LogType.Error).Error(msg);
        }

        public void EnqueueRecharge(string msg)
        {
            if (RechargeLog.Count < 100)
                RechargeLog.Enqueue(String.Format("[{0}]: {1}" + Environment.NewLine, DateTime.Now, msg));

            Logger.GetLogger(LogType.Recharge).Debug(msg);
        }
    }
}

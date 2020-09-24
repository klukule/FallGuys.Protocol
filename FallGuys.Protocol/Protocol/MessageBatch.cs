using System;
using System.Collections.Generic;
using System.Text;
using ProtoBuf;

namespace Catapult.Protocol
{
    [ProtoContract]
    public class MessageBatch
    {
        [ProtoMember(1)]
        public List<Message> Messages { get; set; }

        public MessageBatch()
        {
            Messages = new List<Message>();
        }

        public void AddRange(IEnumerable<Message> messages)
        {
            Messages.AddRange(messages);
        }

        public void Add<T>(T message) where T : Message
        {
            Messages.Add(message);
        }

        public TMessage Get<TMessage>()
            where TMessage : Message
        {
            foreach (var message in Messages)
            {
                if (message.GetType() == typeof(TMessage))
                    return (TMessage) message;
            }

            return null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(GetType().ToString());

            for (var i = 0; i < Messages.Count; i++)
                sb.AppendLine($"[{i}]: {Messages[i].GetType()}"); // TODO: Verify passed arguments
            
            return sb.ToString();
        }
    }
}

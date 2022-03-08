using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {
    internal class MessageLogger {
        uint _maxMessagesStored = 50;
        uint _numberOfMessagesStored = 0;

        public Message[] Messages { get; }

        public MessageLogger() { Messages = new Message[_maxMessagesStored]; }

        public string ReadAll() {
            return GenerateLogOutput();
        }

        private string GenerateLogOutput() {
            string messageLog = String.Empty;

            for (int i = 0; i < _numberOfMessagesStored; i++) {
                messageLog += Messages[i].Text + "\n";
            }

            return messageLog;
        }

        public void Clear() {
            Array.Clear(Messages, 0, Messages.Length);
            _numberOfMessagesStored = 0;
        }

        public void Write(Message message) {
            if (_numberOfMessagesStored >= _maxMessagesStored) {
                _numberOfMessagesStored = 0;
            }

            Messages[_numberOfMessagesStored] = message;
            _numberOfMessagesStored++;
        }
    }
}

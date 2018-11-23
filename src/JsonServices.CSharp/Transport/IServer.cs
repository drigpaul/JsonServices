using System;
using System.Collections.Generic;

namespace JsonServices.Transport
{
	public interface IServer : IDisposable
	{
		void Send(Guid sessionId, byte[] data);

		event EventHandler<MessageEventArgs> MessageReceived;

		IEnumerable<ISession> ActiveSessions { get; }

		ISession GetSession(Guid sessionId);
	}
}
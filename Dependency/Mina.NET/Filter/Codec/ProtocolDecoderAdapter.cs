﻿using System;
using Mina.Core.Buffer;
using Mina.Core.Session;

namespace Mina.Filter.Codec
{
    /// <summary>
    /// An abstract <see cref="IProtocolDecoder"/> implementation for those who don't need
    /// FinishDecode(IoSession, ProtocolDecoderOutput) nor
    /// Dispose(IoSession) method.
    /// </summary>
    public abstract class ProtocolDecoderAdapter : IProtocolDecoder
    {
        public abstract void Decode(IoSession session, IoBuffer input, IProtocolDecoderOutput output);

        public virtual void FinishDecode(IoSession session, IProtocolDecoderOutput output)
        {
            // Do nothing
        }

        public virtual void Dispose(IoSession session)
        {
            // Do nothing
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTPPV5.Infrastructure.Collections.ProducerConsumer
{
    public interface IChunkedBlockingQueue<TItem> : IBlockingQueue<TItem>
    {
        TItem[] TakeBatch(int maxCount);
    }
}
﻿Console.WriteLine(args.FirstOrDefault()?.AggregateBy(x => x, new System.Text.StringBuilder(), (b, x) => { b.Append("〇一二三四五六七八九×"[int.TryParse(x.ToString(), out var i) ? i : 10]); return b; }).Select(x => x.Value).FirstOrDefault()?.ToString());
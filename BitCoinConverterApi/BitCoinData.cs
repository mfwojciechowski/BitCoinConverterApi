using System;

namespace BitCoinConverterApi
{

    public class BitCoinData
    {
        public Time time { get; set; }
        public string disclaimer { get; set; }
        public Bpi bpi { get; set; }
    }

    public class Time
    {
        public string updated { get; set; }
        public DateTime updatedISO { get; set; }
        public string updateduk { get; set; }
    }

    public class Bpi
    {
        public USD USD { get; set; }
        public PLN PLN { get; set; }
    }

    public class USD
    {
        public string code { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public float rate_float { get; set; }
    }

    public class PLN
    {
        public string code { get; set; }
        public string rate { get; set; }
        public string description { get; set; }
        public float rate_float { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class CurrencyCodeEnum : BaseStringEnumeration
    {
        public CurrencyCodeEnum(string value) : base(value) { }

        public static CurrencyCodeEnum AustralianDollar => new CurrencyCodeEnum("AUD");
        public static CurrencyCodeEnum BrazilianReal => new CurrencyCodeEnum("BRL");
        public static CurrencyCodeEnum CanadianDollar => new CurrencyCodeEnum("CAD");
        public static CurrencyCodeEnum CzechKoruna => new CurrencyCodeEnum("CZK");
        public static CurrencyCodeEnum DanishKrone => new CurrencyCodeEnum("DKK");
        public static CurrencyCodeEnum Euro => new CurrencyCodeEnum("EUR");
        public static CurrencyCodeEnum HongKongDollar => new CurrencyCodeEnum("HKD");
        public static CurrencyCodeEnum HungarianForint => new CurrencyCodeEnum("HUF");
        public static CurrencyCodeEnum IndianRupee => new CurrencyCodeEnum("INR");
        public static CurrencyCodeEnum IsraeliNewSheqel => new CurrencyCodeEnum("ILS");
        public static CurrencyCodeEnum JapaneseYen => new CurrencyCodeEnum("JPY");
        public static CurrencyCodeEnum MalaysianRinggit => new CurrencyCodeEnum("MYR");
        public static CurrencyCodeEnum MexicanPeso => new CurrencyCodeEnum("MXN");
        public static CurrencyCodeEnum NorwegianKrone => new CurrencyCodeEnum("NOK");
        public static CurrencyCodeEnum NewZealandDollar => new CurrencyCodeEnum("NZD");
        public static CurrencyCodeEnum PhilippinePeso => new CurrencyCodeEnum("PHP");
        public static CurrencyCodeEnum PolishZloty => new CurrencyCodeEnum("PLN");
        public static CurrencyCodeEnum PoundSterling => new CurrencyCodeEnum("GBP");
        public static CurrencyCodeEnum RussianRuble => new CurrencyCodeEnum("RUB");
        public static CurrencyCodeEnum SingaporeDollar => new CurrencyCodeEnum("SGD");
        public static CurrencyCodeEnum SwedishKrona => new CurrencyCodeEnum("SEK");
        public static CurrencyCodeEnum SwissFranc => new CurrencyCodeEnum("CHF");
        public static CurrencyCodeEnum TaiwanNewDollar => new CurrencyCodeEnum("TWD");
        public static CurrencyCodeEnum ThaiBaht => new CurrencyCodeEnum("THB");
        public static CurrencyCodeEnum USDollar => new CurrencyCodeEnum("USD");

        public static implicit operator string(CurrencyCodeEnum value)
        {
            return value?.Value;
        }

        public static explicit operator CurrencyCodeEnum(string value)
        {
            return new CurrencyCodeEnum(value);
        }
    }
}

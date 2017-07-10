//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace PayPal.Api
{
    /// <summary>
    /// A payer's funding instrument details used in context of payments.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class FundingInstrument : PayPalSerializableObject
    {
        /// <summary>
        /// Credit Card information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_card")]
        public CreditCard credit_card { get; set; }

        /// <summary>
        /// Credit Card information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credit_card_token")]
        public CreditCardToken credit_card_token { get; set; }

        #region Unsupported properties (support not yet available in PayPal REST API)
        /// <summary>
        /// Payment Card information.
        /// <para>NOTE: This property is currently not supported as a funding instrument option with the PayPal REST API.</para>
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        //[Browsable(false)]
        public PaymentCard payment_card { get; set; }

        /// <summary>
        /// Bank Account information.
        /// <para>NOTE: This property is currently not supported as a funding instrument option with the PayPal REST API.</para>
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        //[Browsable(false)]
        public ExtendedBankAccount bank_account { get; set; }

        /// <summary>
        /// Bank Account information.
        /// <para>NOTE: This property is currently not supported as a funding instrument option with the PayPal REST API.</para>
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        //[Browsable(false)]
        public BankToken bank_account_token { get; set; }

        /// <summary>
        /// Credit funding information.
        /// <para>NOTE: This property is currently not supported as a funding instrument option with the PayPal REST API.</para>
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        //[Browsable(false)]
        public Credit credit { get; set; }

        /// <summary>
        /// Incentive funding information.
        /// <para>NOTE: This property is currently not supported as a funding instrument option with the PayPal REST API.</para>
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        //[Browsable(false)]
        public Incentive incentive { get; set; }

        /// <summary>
        /// Carrier account token information.
        /// <para>NOTE: This property is currently not supported as a funding instrument option with the PayPal REST API.</para>
        /// </summary>
        [JsonIgnore]
        [Obsolete("This field is not availalbe publicly in the PayPal REST API. It will be removed in a future release.", false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        //[Browsable(false)]
        public CarrierAccountToken carrier_account_token { get; set; }
        #endregion
    }
}

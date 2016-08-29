using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSS.MerchantRankByWebsosanh
{
    public class MerchantScore
    {
        public MerchantScore()
        {
            MerchantId = 0;
            ScoreNumberProduct1 = 0;
            ScoreStore1 = 0;
            ScoreTraffic1 = 0;
            ScoreAdvertisementPR1 = 0;
            ScoreScandal1 = 0;
            TotalPart1 = 0;
            ScoreAddressStore2 = 0;
            ScorePhoneNumberAvaiable2 = 0;
            ScoreCustomerServices2 = 0;
            TotalPart2 = 0;
            ScoreProductInformation3 = 0;
            ScoreWebsosanhRate3 = 0;
            ScoreGoogleRate3 = 0;
            ScoreRateWebsite3 = 0;
            TotalPart3 = 0;
            ScoreStatusProduct4 = 0;
            ScoreSignContract5 = 0;
            ScoreResignContract5 = 0;
            ScorePotential5 = 0;
            ScoreSales5 = 0;
            TotalPart5 = 0;
        }
        
        public long MerchantId { set; get; }
        public string MerchantWebsite { set; get; }
        #region Phần 1
        
        /// <summary>
        /// Điểm 'Số lượng' sản phẩm
        /// </summary>
        public int ScoreNumberProduct1 { set; get; }

        /// <summary>
        ///Điểm số cửa hàng
        /// </summary>
        public int ScoreStore1 { set; get; }
        
        /// <summary>
        /// Điểm traffic
        /// </summary>

        public double ScoreTraffic1 { set; get; }

        /// <summary>
        /// Điểm quảng cáo PR
        /// </summary>
        public int ScoreAdvertisementPR1 { set; get; }

        /// <summary>
        /// Điểm Scandal
        /// </summary>
        public int ScoreScandal1 { set; get; }

        public double TotalPart1 { set; get; }
        #endregion

        public double CalculatorToTalPart1()
        {
            double result = 0;
            result = ScoreNumberProduct1 * 0.2 + ScoreStore1 * 0.3 + ScoreTraffic1 * 0.3 + ScoreAdvertisementPR1 * 0.1 + ScoreScandal1 * 0.1;
            return Math.Round(result,4);
        }

        #region Phần 2
        /// <summary>
        /// Điểm địa chỉ rõ ràng
        /// </summary>
        public int ScoreAddressStore2 { set; get; }
        /// <summary>
        /// Điểm 'Số liên lạc' còn hoạt động
        /// </summary>
        public int ScorePhoneNumberAvaiable2 { set; get; }
        /// <summary>
        /// Điểm tư vấn khách hàng
        /// </summary>
        public int ScoreCustomerServices2 { set; get; }
        #endregion
        public double TotalPart2 { set; get; }
        public double CalculatorToTalPart2()
        {
            double result = 0;
            result = ScoreAddressStore2 * 0.4 + ScorePhoneNumberAvaiable2 * 0.4 + ScoreCustomerServices2 * 0.2;
            return Math.Round(result, 4);
        }

        #region Phần 3
        /// <summary>
        /// Điểm thông tin sản phẩm
        /// </summary>
        public int ScoreProductInformation3 { set; get; }
        /// <summary>
        /// Điểm websosanh đánh giá
        /// </summary>
        public int ScoreWebsosanhRate3 { set; get; }
        /// <summary>
        /// Điểm google đánh giá
        /// </summary>
        public int ScoreGoogleRate3 { set; get; }
        /// <summary>
        /// Điểm đánh giá website merchant
        /// </summary>
        public int ScoreRateWebsite3 { set; get; }
        #endregion
        public double TotalPart3 { set; get;}
        public double CalculatorTotalPart3()
        {
            double result = 0;
            result = ScoreProductInformation3 * 0.5 + ((ScoreWebsosanhRate3 * 0.2 + ScoreGoogleRate3 * 0.6 + ScoreRateWebsite3 * 0.2) / 3) * 0.5;
            return Math.Round(result, 4);
        }

        #region Phần 4
        /// <summary>
        /// Điểm trang thái sản phẩm
        /// </summary>
        public int ScoreStatusProduct4 { set; get; }
        #endregion

        #region Phần 5
        /// <summary>
        /// Kí hợp đồng
        /// </summary>
        public int ScoreSignContract5 { set; get; }
        /// <summary>
        /// Tái kí hợp đồng
        /// </summary>
        public int ScoreResignContract5 { set; get; }
        /// <summary>
        /// Điểm Tiềm năng
        /// </summary>
        public int ScorePotential5 { set; get; }
        /// <summary>
        /// Doanh số
        /// </summary>
        public int ScoreSales5 { set; get; }
        #endregion
        public double TotalPart5 { set; get; }
        public double CalculatorTotalPart5()
        {
            double result = 0;
            result = ScoreSignContract5 * 0.2 + ScoreResignContract5 * 0.3 + ScorePotential5 * 0.3 + ScoreSales5 * 0.2;
            return Math.Round(result, 4);
        }

        public double Score { set; get; }
        public double CalculatorScore()
        {
            return Math.Round(TotalPart1 * 0.33 + TotalPart2 * 0.14 + TotalPart3 * 0.06 + ScoreStatusProduct4 * 0.2 + TotalPart5 * 0.27, 4);
        }

    }
}

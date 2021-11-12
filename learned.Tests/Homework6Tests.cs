using NUnit.Framework;
using System;

namespace learned.Tests
{
    static class Homework6Tests
    {
        //Задание 1
        public enum InversionFrameMockVariants
        {
            Size3X4,
            Size2X5,
            Size4X10,
            Size2X2,
            Size1X1
        }
        private static int[,] InversionFrameMockInputData(InversionFrameMockVariants variants) //подготовка исходных матриц
        {
            return variants switch
            {
                InversionFrameMockVariants.Size1X1 => new int[1, 1] {{5}},
                InversionFrameMockVariants.Size2X2 => new int[2, 2] {{-53, 56}, {14, 1}},
                InversionFrameMockVariants.Size2X5 => new int[2, 5] {{-83, 17, -15, -41, 6}, {20, 98, -89, -63, -96}},
                InversionFrameMockVariants.Size3X4 => new int[3, 4] {
                    {-90, 99, 54, -40}, 
                    {-45, -36, -63, 51}, 
                    {88, 80, -59, 53} },
                InversionFrameMockVariants.Size4X10 => new int[4, 10]{
                    {49, -30, -19, -57, -2, -79, 75, 59, 65, 25},
                    {-23, -76, 12, -23, 28, -8, -36, -42, 76, 32},
                    {76, 42, 40, 0, 64, -57, 30, 30, -42, 72}, 
                    {13, 56, 38, 56, -31, 61, 18, -84, -13, -90} },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип входных данных")
            };
        }
        private static int[,] InversionFrameMockOutputData(InversionFrameMockVariants variants) //подготовка ответов
        {
            return variants switch
            {
                InversionFrameMockVariants.Size1X1 => new int[1, 1] {{-5}},
                InversionFrameMockVariants.Size2X2 => new int[2, 2] {{53, -56}, {-14, -1}},
                InversionFrameMockVariants.Size2X5 => new int[2, 5] {{83, -17, 15, 41, -6}, {-20, -98, 89, 63, 96}},
                InversionFrameMockVariants.Size3X4 => new int[3, 4] {
                    {90, -99, -54, 40}, 
                    {45, -36, -63, -51}, 
                    {-88, -80, 59, -53} },
                InversionFrameMockVariants.Size4X10 => new int[4, 10] {
                    {-49, 30, 19, 57, 2, 79, -75, -59, -65, -25}, 
                    {23, -76, 12, -23, 28, -8, -36, -42, 76, -32},
                    {-76, 42, 40, 0, 64, -57, 30, 30, -42, -72}, 
                    {-13, -56, -38, -56, 31, -61, -18, 84, 13, 90} },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип выходных данных")
            };
        }

        [TestCase(InversionFrameMockVariants.Size1X1)]
        [TestCase(InversionFrameMockVariants.Size2X2)]
        [TestCase(InversionFrameMockVariants.Size2X5)]
        [TestCase(InversionFrameMockVariants.Size3X4)]
        [TestCase(InversionFrameMockVariants.Size4X10)]
        public static void InversionFrameTest(InversionFrameMockVariants variant)
        {
            int[,] actual = Homework6.InversionFrame(InversionFrameMockInputData(variant));
            int[,] expected = InversionFrameMockOutputData(variant);
            Assert.AreEqual(expected, actual);
        }

        //Задание 2
        public enum MultiplicationTableMockVariants
        {
            At0,
            At1,
            At2,
            At5,
            At9
        }

        private static int[,] MultiplicationTableMock(MultiplicationTableMockVariants variants) //подготовка ответов
        {
            return variants switch
            {
                MultiplicationTableMockVariants.At0 => new int[0, 0],
                MultiplicationTableMockVariants.At1 => new int[1, 1] {{1}},
                MultiplicationTableMockVariants.At2 => new int[2, 2] {{1, 2}, {2, 4}},
                MultiplicationTableMockVariants.At5 => new int[5, 5] {
                    {1, 2, 3, 4, 5}, 
                    {2, 4, 6, 8, 10}, 
                    {3, 6, 9, 12, 15}, 
                    {4, 8, 12, 16, 20}, 
                    {5, 10, 15, 20, 25} },
                MultiplicationTableMockVariants.At9 => new int[9, 9] {
                    {1, 2, 3, 4, 5, 6, 7, 8, 9}, 
                    {2, 4, 6, 8, 10, 12, 14, 16, 18},
                    {3, 6, 9, 12, 15, 18, 21, 24, 27}, 
                    {4, 8, 12, 16, 20, 24, 28, 32, 36},
                    {5, 10, 15, 20, 25, 30, 35, 40, 45}, 
                    {6, 12, 18, 24, 30, 36, 42, 48, 54},
                    {7, 14, 21, 28, 35, 42, 49, 56, 63}, 
                    {8, 16, 24, 32, 40, 48, 56, 64, 72},
                    {9, 18, 27, 36, 45, 54, 63, 72, 81} },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип выходных данных")
            };
        }

        [TestCase(0, MultiplicationTableMockVariants.At0)]
        [TestCase(1, MultiplicationTableMockVariants.At1)]
        [TestCase(2, MultiplicationTableMockVariants.At2)]
        [TestCase(5, MultiplicationTableMockVariants.At5)]
        [TestCase(9, MultiplicationTableMockVariants.At9)]
        public static void MultiplicationTableTest(int size, MultiplicationTableMockVariants variant)
        {
            int[,] actual = Homework6.MultiplicationTable(size);
            int[,] expected = MultiplicationTableMock(variant);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void MultiplicationTableNegativTest()
        {
            Assert.Throws<ArgumentException>(() => Homework6.MultiplicationTable(-59));
        }

        //Задание 3
        public enum GetChessBoardMockVariants
        {
            At0,
            At1,
            At8,
            At10,
            At15
        }

        private static char[,] GetChessBoardMock(GetChessBoardMockVariants variants) //подготовка ответов
        {
            return variants switch
            {
                GetChessBoardMockVariants.At0 => new char[0, 0],
                GetChessBoardMockVariants.At1 => new char[1, 1] {{'0'}},
                GetChessBoardMockVariants.At8 => new char[8, 8] {
                    {'1', '0', '1', '0', '1', '0', '1', '0',},
                    {'0', '1', '0', '1', '0', '1', '0', '1'},
                    {'1', '0', '1', '0', '1', '0', '1', '0'}, 
                    {'0', '1', '0', '1', '0', '1', '0', '1'},
                    {'1', '0', '1', '0', '1', '0', '1', '0'},
                    {'0', '1', '0', '1', '0', '1', '0', '1'},
                    {'1', '0', '1', '0', '1', '0', '1', '0'}, 
                    {'0', '1', '0', '1', '0', '1', '0', '1'} },
                GetChessBoardMockVariants.At10 => new char[10, 10] {
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1'} },
                GetChessBoardMockVariants.At15 => new char[15, 15] {
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0'},
                    {'1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1'},
                    {'0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0', '1', '0'} },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип выходных данных")
            };
        }

        [TestCase(0, GetChessBoardMockVariants.At0)]
        [TestCase(1, GetChessBoardMockVariants.At1)]
        [TestCase(8, GetChessBoardMockVariants.At8)]
        [TestCase(10, GetChessBoardMockVariants.At10)]
        [TestCase(15, GetChessBoardMockVariants.At15)]
        public static void GetChessBoardTest(int size, GetChessBoardMockVariants variant)
        {
            char[,] actual = Homework6.GetChessBoard(size);
            char[,] expected = GetChessBoardMock(variant);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void GetChessBoardNegativTest()
        {
            Assert.Throws<ArgumentException>(() => Homework6.GetChessBoard(-59));
        }

        //Задание 4
        public enum RespectedAntiqueRulesMockVariants
        {
            Size0X0,
            Size1X1,
            Size4X5,
            Size5X7,
            Size8X9
        }

        private static int[,] RespectedAntiqueRulesMock(RespectedAntiqueRulesMockVariants variants) //подготовка ответов
        {
            return variants switch
            {
                RespectedAntiqueRulesMockVariants.Size0X0 => new int[0, 0],
                RespectedAntiqueRulesMockVariants.Size1X1 => new int[1, 1] {{0}},
                RespectedAntiqueRulesMockVariants.Size4X5 => new int[4, 5] {
                    {0, 0, 1, 0, 1},
                    {1, 1, 0, 0, 0}, 
                    {1, 1, 1, 0, 0}, 
                    {1, 1, 1, 1, 0} },
                RespectedAntiqueRulesMockVariants.Size5X7 => new int[5, 7] {
                    {1, 1, 1, 1, 1, 1, 0},
                    {0, 1, 0, 1, 0, 1, 0}, 
                    {1, 0, 1, 0, 1, 1, 0}, 
                    {1, 0, 0, 0, 0, 1, 1},
                    {1, 0, 0, 1, 1, 1, 1} },
                RespectedAntiqueRulesMockVariants.Size8X9 => new int[8, 9] {
                    {0, 0, 1, 1, 0, 1, 0, 1, 1},
                    {1, 0, 0, 0, 1, 1, 1, 0, 0},
                    {1, 1, 1, 1, 0, 1, 1, 0, 0},
                    {1, 1, 1, 0, 1, 1, 1, 1, 0},
                    {0, 1, 1, 0, 1, 0, 0, 1, 0}, 
                    {0, 1, 0, 1, 0, 1, 0, 0, 0},
                    {0, 0, 1, 1, 1, 1, 0, 1, 0}, 
                    {1, 1, 1, 0, 1, 1, 1, 0, 1} },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип выходных данных")
            };
        }

        [TestCase(false, RespectedAntiqueRulesMockVariants.Size0X0)]
        [TestCase(false, RespectedAntiqueRulesMockVariants.Size1X1)]
        [TestCase(true, RespectedAntiqueRulesMockVariants.Size4X5)]
        [TestCase(true, RespectedAntiqueRulesMockVariants.Size5X7)]
        [TestCase(true, RespectedAntiqueRulesMockVariants.Size8X9)]
        public static void RespectedAntiqueRulesTest(bool expected, RespectedAntiqueRulesMockVariants variant)
        {
            bool actual = Homework6.RespectedAntiqueRules(RespectedAntiqueRulesMock(variant));
            Assert.AreEqual(expected, actual);
        }

        //Задание 5
        public enum GetStoreIncomeMockVariants
        {
            Var1,
            Var2,
            Var3,
            Var4,
            Var5
        }

        private static double[,] GetStoreIncomeMock(GetStoreIncomeMockVariants variants) //подготовка ответов
        {
            return variants switch
            {
                GetStoreIncomeMockVariants.Var1 => new double[10, 6]
                {
                    {104548.15, 118007.55, 182306.27, 118760.09, 133482.19, 113897.07},
                    {253516.1, 237263.15, 150486.27, 287388.68, 268909.8, 112607.75},
                    {101099.73, 296003.63, 179468.81, 235010.78, 214956.6, 205660.02},
                    {149478.15, 233617.9, 131959.98, 160824.29, 273452.19, 224502.25},
                    {212396.16, 186828.16, 139582.49, 248508.87, 255480.67, 257116.88},
                    {168363.69, 114497.27, 106905.95, 205759.74, 223636.18, 172357.66},
                    {184224.48, 125947.58, 205549.44, 152623.99, 219744.63, 199064.68},
                    {125272.38, 277003.22, 246568.38, 256544.2, 198702.09, 194216.99},
                    {173861.05, 208203.92, 108746.24, 263328.77, 146298.04, 218627.67},
                    {260132.6, 282995.77, 182350.48, 172300.62, 204680.37, 240263.93}
                },
                GetStoreIncomeMockVariants.Var2 => new double[10, 6]
                {
                    {163094.36, 295953.4, 250720.7, 235436.75, 156478.3, 114021.95},
                    {224055.9, 158529.64, 137636.87, 234786.13, 154801.29, 151789.66},
                    {120320.18, 181259.16, 187780.19, 139521.93, 252443.73, 150395.98},
                    {262392.38, 117785.06, 119141.47, 251846.41, 165843.6, 222179.92},
                    {227726.09, 149549.04, 109298.35, 266784.44, 124327.65, 120064.46},
                    {264000.43, 111162.37, 170668.21, 287346.6, 182012.02, 121096.74},
                    {217682.67, 177931.14, 226353.2, 156064.32, 280250.66, 277423.84},
                    {168211.13, 274039.44, 136314.91, 104303.66, 295396.43, 180806.59},
                    {256914.06, 116384.79, 177890.68, 160283.88, 183436.82, 175679.91},
                    {196175.87, 100310.41, 230587.92, 272975.61, 258981.62, 286956.85}
                },
                GetStoreIncomeMockVariants.Var3 => new double[10, 6]
                {
                    {246639.99, 256633.91, 105060.07, 222676.21, 140631.91, 188707.75},
                    {180731.7, 243101.23, 288704.11, 239244.98, 253387.48, 276563.85},
                    {218637.4, 194581.56, 198443.47, 275715.57, 218734.96, 282368.57},
                    {226912.84, 100360.72, 126221.75, 159046.96, 131990.95, 297531.59},
                    {258660.38, 145688.05, 290154.23, 174073.26, 150745.25, 116936.01},
                    {123587.23, 210637.7, 241602.93, 125377.26, 177455.19, 163681.24},
                    {263808.58, 296011.28, 299031.13, 286363.24, 190495.2, 103243.01},
                    {203471.65, 140105.26, 227235.61, 118625.01, 134042.49, 243446.92},
                    {130023.56, 257286.25, 295632.69, 149538.56, 189772.05, 151143.54},
                    {192312.2, 130410.53, 170098.01, 138995.71, 279880.07, 175035.99}
                },
                GetStoreIncomeMockVariants.Var4 => new double[10, 6]
                {
                    {246639.99, 256633.91, 105060.07, 222676.21, 140631.91, 188707.75},
                    {180731.7, 243101.23, 288704.11, 239244.98, 253387.48, 276563.85},
                    {218637.4, 194581.56, 198443.47, 275715.57, 218734.96, 282368.57},
                    {226912.84, 100360.72, 126221.75, 159046.96, 131990.95, 297531.59},
                    {258660.38, 145688.05, 290154.23, 174073.26, 150745.25, 116936.01},
                    {123587.23, 210637.7, 241602.93, 125377.26, 177455.19, 163681.24},
                    {263808.58, 296011.28, 299031.13, 286363.24, 190495.2, 103243.01},
                    {203471.65, 140105.26, 227235.61, 118625.01, 134042.49, 243446.92},
                    {130023.56, 257286.25, 295632.69, 149538.56, 189772.05, 151143.54},
                    {192312.2, 130410.53, 170098.01, 138995.71, 279880.07, 175035.99}
                },
                GetStoreIncomeMockVariants.Var5 => new double[10, 6]
                {
                    {213159.25, 250608.08, 195043.73, 275814, 228486.58, 190541.18},
                    {219453.22, 180508.25, 110186.22, 225061.01, 293936.64, 155721.93},
                    {253000.58, 211082.15, 279947.81, 112245.22, 132886.71, 108772.57},
                    {150248.99, 274377.11, double.MaxValue, 188784.59, 264538.29, 150888.61},
                    {145778.96, 186357.49, 246095.93, 102049.32, 238859.34, 154464.91},
                    {290976.67, 147616.94, 298174.28, 117486.1, 159316.19, 179371.09},
                    {112650.26, 188413.18, 225040.23, 218694.13, 213323.98, 211735.05},
                    {249247.76, 213328.88, 188545.82, 268182.05, 122866.85, 161504.95},
                    {148908.59, 225248.91, 120878.7, 175723.91, 209041.57, 148975.93},
                    {299674.82, 203999, 216966.45, 162614.53, 270204.26, 106850.53}
                },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип выходных данных")
            };
        }

        [TestCase(101099.73, 296003.63, new double[]
                {1732892.49, 2080368.15, 1633924.31, 2101050.03, 2139342.76, 1938314.9}, new double[]
            {
                771001.32, 1310171.75, 1232199.57, 1173834.76, 1299913.23, 991520.49, 1087154.8, 1298307.26, 1119065.69,
                1342723.77
            },
            GetStoreIncomeMockVariants.Var1)]
        [TestCase(100310.41, 295953.4, new double[]
                {2100573.07, 1682904.45, 1746392.5, 2109349.73, 2053972.12, 1800415.9}, new double[]
            {
                1215705.46, 1061599.49, 1031721.17, 1139188.84, 997750.03, 1136286.37, 1335705.83, 1159072.16,
                1070590.14, 1345988.28
            },
            GetStoreIncomeMockVariants.Var2)]
        [TestCase(100360.72, 299031.13, new double[]
                {2044785.53, 1974816.49, 2242184, 1889656.76, 1867135.55, 1998658.47}, new double[]
            {
                1160349.84, 1481733.35, 1388481.53, 1042064.81, 1136257.18, 1042341.55, 1438952.44, 1066926.94,
                1173396.65, 1086732.51
            },
            GetStoreIncomeMockVariants.Var3)]
        [TestCase(100360.72, 299031.13, new double[]
                {2044785.53, 1974816.49, 2242184, 1889656.76, 1867135.55, 1998658.47}, new double[]
            {
                1160349.84, 1481733.35, 1388481.53, 1042064.81, 1136257.18, 1042341.55, 1438952.44, 1066926.94,
                1173396.65, 1086732.51
            },
            GetStoreIncomeMockVariants.Var4)]
        [TestCase(102049.32, double.MaxValue, new double[]
                {2083099.1, 2081539.99, double.MaxValue, 1846654.86, 2133460.41, 1568826.75}, new double[]
            {
                1353652.82, 1184867.27, 1097935.04, double.MaxValue, 1073605.95, 1192941.27, 1169856.83, 1203676.31,
                1028777.61, 1260309.59
            },
            GetStoreIncomeMockVariants.Var5)]
        public static void GetStoreIncomeTest(double min, double max, double[] sumMonths, double[] sumOneShop,
            GetStoreIncomeMockVariants variant)
        {
            (double, double, double[], double[]) expected = (min, max, sumMonths, sumOneShop);
            (double, double, double[], double[]) actual = Homework6.GetStoreIncome(GetStoreIncomeMock(variant));
            Assert.AreEqual(expected, actual);
        }

        //Задание 6
        public enum GetMoreThanTheirNeighborsMockVariants
        {
            Size0X0,
            Size2X10,
            Size4X10,
            Size2X2,
            Size1X1
        }

        private static int[,] GetMoreThanTheirNeighborsMock(GetMoreThanTheirNeighborsMockVariants variants) //подготовка исходных матриц
        {
            return variants switch
            {
                GetMoreThanTheirNeighborsMockVariants.Size0X0 => new int[0, 0],
                GetMoreThanTheirNeighborsMockVariants.Size1X1 => new int[1, 1] {{14}},
                GetMoreThanTheirNeighborsMockVariants.Size2X2 => new int[2, 2] {{-41, 6}, {63, -96}},
                GetMoreThanTheirNeighborsMockVariants.Size2X10 => new int[2, 10] {
                    {-90, 99, 54, -40, 54, 64, 74, 13, -95, 15},
                    {-45, -36, -63, 51, 88, 80, -59, 53, 15, 4} },
                GetMoreThanTheirNeighborsMockVariants.Size4X10 => new int[4, 10] {
                    {49, -30, -19, -57, -2, -79, 75, 59, 65, 25}, 
                    {-23, -76, 12, -23, 28, -8, -36, -42, 76, 32},
                    {76, 42, 40, 0, 64, -57, 30, 30, -42, 72},
                    {13, 56, 38, 56, -31, 61, 18, -84, -13, -90} },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип входных данных")
            };
        }

        [TestCase(0, GetMoreThanTheirNeighborsMockVariants.Size0X0)]
        [TestCase(0, GetMoreThanTheirNeighborsMockVariants.Size1X1)]
        [TestCase(2, GetMoreThanTheirNeighborsMockVariants.Size2X2)]
        [TestCase(8, GetMoreThanTheirNeighborsMockVariants.Size2X10)]
        [TestCase(17, GetMoreThanTheirNeighborsMockVariants.Size4X10)]
        public static void GetMoreThanTheirNeighborsTest(int expected, GetMoreThanTheirNeighborsMockVariants variant)
        {
            int actual = Homework6.GetMoreThanTheirNeighbors(GetMoreThanTheirNeighborsMock(variant));
            Assert.AreEqual(expected, actual);
        }

        //Задание 7
        public enum GetHourglassMockVariants
        {
            At0,
            At1,
            At8,
            At10,
            At15
        }

        private static char[,] GetHourglassMock(GetHourglassMockVariants variants) //подготовка ответов
        {
            return variants switch
            {
                GetHourglassMockVariants.At0 => new char[0, 0],
                GetHourglassMockVariants.At1 => new char[1, 1] {{'1'}},
                GetHourglassMockVariants.At8 => new char[8, 8] {
                    {'1', '1', '1', '1', '1', '1', '1', '1'},
                    {'0', '1', '1', '1', '1', '1', '1', '0'},
                    {'0', '0', '1', '1', '1', '1', '0', '0'}, 
                    {'0', '0', '0', '1', '1', '0', '0', '0'},
                    {'0', '0', '0', '1', '1', '0', '0', '0'}, 
                    {'0', '0', '1', '1', '1', '1', '0', '0'},
                    {'0', '1', '1', '1', '1', '1', '1', '0'}, 
                    {'1', '1', '1', '1', '1', '1', '1', '1'} },
                GetHourglassMockVariants.At10 => new char[10, 10] {
                    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
                    {'0', '1', '1', '1', '1', '1', '1', '1', '1', '0'},
                    {'0', '0', '1', '1', '1', '1', '1', '1', '0', '0'},
                    {'0', '0', '0', '1', '1', '1', '1', '0', '0', '0'},
                    {'0', '0', '0', '0', '1', '1', '0', '0', '0', '0'},
                    {'0', '0', '0', '0', '1', '1', '0', '0', '0', '0'},
                    {'0', '0', '0', '1', '1', '1', '1', '0', '0', '0'},
                    {'0', '0', '1', '1', '1', '1', '1', '1', '0', '0'},
                    {'0', '1', '1', '1', '1', '1', '1', '1', '1', '0'},
                    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1'} },
                GetHourglassMockVariants.At15 => new char[15, 15] {
                    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'},
                    {'0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0'},
                    {'0', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '0'},
                    {'0', '0', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '0', '0'},
                    {'0', '0', '0', '0', '1', '1', '1', '1', '1', '1', '1', '0', '0', '0', '0'},
                    {'0', '0', '0', '0', '0', '1', '1', '1', '1', '1', '0', '0', '0', '0', '0'},
                    {'0', '0', '0', '0', '0', '0', '1', '1', '1', '0', '0', '0', '0', '0', '0'},
                    {'0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '0', '0', '0', '0', '0'},
                    {'0', '0', '0', '0', '0', '0', '1', '1', '1', '0', '0', '0', '0', '0', '0'},
                    {'0', '0', '0', '0', '0', '1', '1', '1', '1', '1', '0', '0', '0', '0', '0'},
                    {'0', '0', '0', '0', '1', '1', '1', '1', '1', '1', '1', '0', '0', '0', '0'},
                    {'0', '0', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '0', '0'},
                    {'0', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '0'},
                    {'0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0'},
                    {'1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1'} },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип выходных данных")
            };
        }

        [TestCase(0, GetHourglassMockVariants.At0)]
        [TestCase(1, GetHourglassMockVariants.At1)]
        [TestCase(8, GetHourglassMockVariants.At8)]
        [TestCase(10, GetHourglassMockVariants.At10)]
        [TestCase(15, GetHourglassMockVariants.At15)]
        public static void GetHourglassTest(int size, GetHourglassMockVariants variant)
        {
            char[,] actual = Homework6.GetHourglass(size);
            char[,] expected = GetHourglassMock(variant);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void GetHourglassNegativTest()
        {
            Assert.Throws<ArgumentException>(() => Homework6.GetChessBoard(-84));
        }

        //Задание 8
        public enum MultiplicationMatrixMockVariants
        {
            Size0X0,
            Size1X1,
            Size2X2,
            Size2X5,
            Size3X4
        }

        private static (int[,], int[,]) MultiplicationMatrixMockInputData(MultiplicationMatrixMockVariants variants) //подготовка исходных матриц
        {
            return variants switch
            {
                MultiplicationMatrixMockVariants.Size0X0 => (new int[0, 0], new int[0, 0]),
                MultiplicationMatrixMockVariants.Size1X1 => (new[,] {{4}}, new int[1, 1] {{-3}}),
                MultiplicationMatrixMockVariants.Size2X2 => (new int[2, 2] {{4, 10}, {8, -7}},
                    new int[2, 2] {{-3, 7}, {20, -87}}),
                MultiplicationMatrixMockVariants.Size2X5 => (new int[2, 2] {{4, 10}, {8, -7}},
                    new int[2, 5] {{-3, 7, 84, -9, 15}, {20, -87, 78, 96, 45}}),
                MultiplicationMatrixMockVariants.Size3X4 => (new int[3, 2] {{4, 10}, {8, -7}, {47, 47}},
                    new int[2, 4] {{7, 84, -9, 15}, {20, 78, 96, 45}}),
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип входных данных")
            };
        }

        private static long[,] MultiplicationMatrixMockOutputData(MultiplicationMatrixMockVariants variants) //подготовка ответов
        {
            return variants switch
            {
                MultiplicationMatrixMockVariants.Size0X0 => new long[0, 0],
                MultiplicationMatrixMockVariants.Size1X1 => new long[1, 1] {{-12}},
                MultiplicationMatrixMockVariants.Size2X2 => new long[2, 2] {{188, -842}, {-164, 665}},
                MultiplicationMatrixMockVariants.Size2X5 => new long[2, 5] {
                    {188, -842, 1116, 924, 510}, 
                    {-164, 665, 126, -744, -195} },
                MultiplicationMatrixMockVariants.Size3X4 => new long[3, 4] {
                    {228, 1116, 924, 510}, 
                    {-84, 126, -744, -195}, 
                    {1269, 7614, 4089, 2820} },
                _ => throw new ArgumentNullException(nameof(variants), "Несуществующий тип выходных данных")
            };
        }

        [TestCase(MultiplicationMatrixMockVariants.Size0X0)]
        [TestCase(MultiplicationMatrixMockVariants.Size1X1)]
        [TestCase(MultiplicationMatrixMockVariants.Size2X2)]
        [TestCase(MultiplicationMatrixMockVariants.Size2X5)]
        [TestCase(MultiplicationMatrixMockVariants.Size3X4)]
        public static void MultiplicationMatrixTest(MultiplicationMatrixMockVariants variant)
        {
            var (arrOne, arrTwo) = MultiplicationMatrixMockInputData(variant);
            long[,] actual = Homework6.MultiplicationMatrix(arrOne, arrTwo);
            long[,] expected = MultiplicationMatrixMockOutputData(variant);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void MultiplicationMatrixNegativTest()
        {
            Assert.Throws<ArgumentException>(() => Homework6.MultiplicationMatrix(new int[10, 4], new int[5, 6]));
        }
    }
}
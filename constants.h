/////////////////////////////////////////////////////////////////////////////////////
////                                    sabitler.h                               ////
////                                                                             ////
////                                                                             ////
/////////////////////////////////////////////////////////////////////////////////////
//// Author    : Nuri Ozcelik                                                    ////
//// Date      : 16.11.2020                                                      ////
//// Version   : v1.0                                                            ////
/////////////////////////////////////////////////////////////////////////////////////
//// CONSTANTS                                                                   ////
////                                                                             ////
////                                                                             ////
/////////////////////////////////////////////////////////////////////////////////////
//// VARIABLES                                                                   ////
////                                                                             ////
////                                                                             ////
/////////////////////////////////////////////////////////////////////////////////////
//// FUNCTIONS                                                                   ////
////                                                                             ////
////                                                                             ////
/////////////////////////////////////////////////////////////////////////////////////
////                      (C) Copyright  Nuri Ozcelik                            ////
/////////////////////////////////////////////////////////////////////////////////////


#define INSTANT_MONEY_MEMORY_ADDRES 2000
#define TOTAL_MONEY_MEMORY_ADDRES   2016
#define FOAM_MONEY_MEMORY_ADDRES    2020
#define POLISH_MONEY_MEMORY_ADDRES  2024
#define WASHING_MONEY_MEMORY_ADDRES 2028
#define VACUUM_MONEY_MEMORY_ADDRES  2032
#define AIR_MONEY_MEMORY_ADDRES     2036
#define MAT_MONEY_MEMORY_ADDRES     2040

unsigned int32 yikamaTotalBuffer = 0;
unsigned int32 paspasTotalBuffer = 0;
unsigned int32 yikamaTotalWorkingTimeBuffer = 0;
unsigned int32 paspasTotalWorkingTimeBuffer = 0;
unsigned int32 kopukTotalBuffer = 0;
unsigned int32 havaTotalBuffer = 0;
unsigned int32 kopukTotalWorkingTimeBuffer = 0;
unsigned int32 havaTotalWorkingTimeBuffer = 0;
unsigned int32 cilaTotalBuffer = 0;
unsigned int32 vakumTotalBuffer = 0;
unsigned int32 cilaTotalWorkingTimeBuffer = 0;
unsigned int32 vakumTotalWorkingTimeBuffer = 0;

/////////////////////////////////////////
/////////    DIGITAL OUTPUTS   //////////
typedef enum _digitalOutputTypes{DIGITAL_OUTPUT_COIN_STATUS = 0, DIGITAL_OUTPUT_RELAY_SU_AKIS, DIGITAL_OUTPUT_SU_BASINC_PASPAS, DIGITAL_OUTPUT_KOPUK_HAVA, DIGITAL_OUTPUT_SUPURGE_CILA, DIGITAL_OUTPUT_BUZZER, DIGITAL_OUTPUT_HARICI, DIGITAL_OUTPUT_HARICI2}digitalOutputTypes;

//WORKING TYPE AND STATUS BIT//
typedef enum _workingStatusAndTypes{WASHING_ACTIVE = 0, MAT_ACTIVE, FOAM_ACTIVE, AIR_ACTIVE, VACUUM_ACTIVE, POLISH_ACTIVE}workingStatusAndTypes;


/////////////////////////////////////////
/////////MODBUS REGISTER GROUPS//////////
typedef enum _parametergroups{HOLDING_GROUP_CFG = 0, HOLDING_GROUP_PASPAS, HOLDING_GROUP_YIKAMA, HOLDING_GROUP_KOPUK, HOLDING_GROUP_AIRMATIK,
                              HOLDING_GROUP_VAKUMMATIK, HOLDING_GROUP_CILA, HOLDING_GROUP_ALARM, HOLDING_GROUP_WORKING_TIME} parametergroups;
                              
                              
//////////////////////////////////////////
/////////PARAMETRE SABITLERI//////////////
#define INPUT_REGISTER_SIZE                     9
#define HOLDING_REGISTER_ROW_SIZE               1
#define HOLDING_REGISTER_COLUMN_SIZE            58


#define ver 3
///////////////////////////////////
////////   INPUT REGISTERS   //////////
digitalOutputStatus                     inputRegister[1]     
instantCounterValue                     inputRegister[2] //YENÝ ALGORITMA LAZIM
alarmStatus                             inputRegister[3]
ambientTemperatureMsb                   inputRegister[4]
ambientTemperatureLsb                   inputRegister[5]
ambientTemperature                      f_IEEEtoPIC(make32(ambientTemperatureMsb, ambientTemperatureLsb))     
instantMoney                            inputRegister[6]
totalMoney                              inputRegister[7]
workingStatusAndType                    inputRegister[8]

///////////////////////////////////////
///////    HOLDING REGISTERS    ///////

///GROUP NAME:CONFIG
///GROUP NO:0
///PARAMETERS START NO:0
deviceStatus                                holdingVariables[HOLDING_GROUP_CFG][1]    
communicationAddress                        holdingVariables[HOLDING_GROUP_CFG][2]          
version                                     holdingVariables[HOLDING_GROUP_CFG][3]   
P10Address                                  holdingVariables[HOLDING_GROUP_CFG][4]         
coinCounterStatus                           holdingVariables[HOLDING_GROUP_CFG][5] 
factoryReset                                holdingVariables[HOLDING_GROUP_CFG][6]  
pulserUsageStatus                           holdingVariables[HOLDING_GROUP_CFG][7] 

///GROUP NAME:paspas
///GROUP NO:1
///PARAMETERS START NO:100
paspasModuTutar                                 holdingVariables[HOLDING_GROUP_CFG][8]   
paspasModuCalismaSuresi                         holdingVariables[HOLDING_GROUP_CFG][9]  
paspasModuDurum                                 holdingVariables[HOLDING_GROUP_CFG][10]   
paspasTotalMoneyMsb                             holdingVariables[HOLDING_GROUP_CFG][11]
paspasTotalMoneyLsb                             holdingVariables[HOLDING_GROUP_CFG][12]
paspasTotalTotalMoney                           make32(paspasTotalMoneyMsb, paspasTotalMoneyLsb)
paspasTotalWorkingTimeMsb                       holdingVariables[HOLDING_GROUP_CFG][13]
paspasTotalWorkingTimeLsb                       holdingVariables[HOLDING_GROUP_CFG][14]
paspasTotalWorkingTime                          make32(paspasTotalWorkingTimeMsb, paspasTotalWorkingTimeLsb)
                              
///GROUP NAME:yikama
///GROUP NO:2
///PARAMETERS START NO:200
yikamaModuTutar                                 holdingVariables[HOLDING_GROUP_CFG][15]   
yikamaModuCalismaSuresi                         holdingVariables[HOLDING_GROUP_CFG][16]
yikamaModuDurum                                 holdingVariables[HOLDING_GROUP_CFG][17]
yikamaTotalMoneyMsb                             holdingVariables[HOLDING_GROUP_CFG][18]
yikamaTotalMoneyLsb                             holdingVariables[HOLDING_GROUP_CFG][19]
yikamaTotalMoney                                make32(yikamaTotalMoneyMsb, yikamaTotalMoneyLsb)
yikamaTotalWorkingTimeMsb                       holdingVariables[HOLDING_GROUP_CFG][20]
yikamaTotalWorkingTimeLsb                       holdingVariables[HOLDING_GROUP_CFG][21]
yikamaTotalWorkingTime                          make32(yikamaTotalWorkingTimeMsb, yikamaTotalWorkingTimeLsb)


///GROUP NAME:kopuk
///GROUP NO:3
///PARAMETERS START NO:300
kopukModuTutar                                  holdingVariables[HOLDING_GROUP_CFG][22]   
kopukModuCalismaSuresi                          holdingVariables[HOLDING_GROUP_CFG][23] 
kopukModuDurum                                  holdingVariables[HOLDING_GROUP_CFG][24] 
 kopukTotalMoneyMsb                              holdingVariables[HOLDING_GROUP_CFG][25]
 kopukTotalMoneyLsb                              holdingVariables[HOLDING_GROUP_CFG][26]
 kopukTotalTotalMoney                            make32(kopukTotalMoneyMsb, kopukTotalMoneyLsb)
kopukTotalWorkingTimeMsb                        holdingVariables[HOLDING_GROUP_CFG][27]
kopukTotalWorkingTimeLsb                        holdingVariables[HOLDING_GROUP_CFG][28]
kopukTotalWorkingTime                           make32(kopukTotalWorkingTimeMsb, kopukTotalWorkingTimeLsb)

///GROUP NAME:airmatik
///GROUP NO:4
///PARAMETERS START NO:400
airmatikModuTutar                               holdingVariables[HOLDING_GROUP_CFG][29]   
airmatikModuCalismaSuresi                       holdingVariables[HOLDING_GROUP_CFG][30]  
airmatikModuDurum                               holdingVariables[HOLDING_GROUP_CFG][31]   
airmatikTotalMoneyMsb                           holdingVariables[HOLDING_GROUP_CFG][32]
airmatikTotalMoneyLsb                           holdingVariables[HOLDING_GROUP_CFG][33]
airmatikTotalTotalMoney                         make32(airmatikTotalMoneyMsb, airmatikTotalMoneyLsb)
airmatikTotalWorkingTimeMsb                     holdingVariables[HOLDING_GROUP_CFG][34]
airmatikTotalWorkingTimeLsb                     holdingVariables[HOLDING_GROUP_CFG][35]
airmatikTotalWorkingTime                        make32(airmatikTotalWorkingTimeMsb, airmatikTotalWorkingTimeLsb)

///GROUP NAME:vakummatik
///GROUP NO:5
///PARAMETERS START NO:500
vakummatikModuTutar                             holdingVariables[HOLDING_GROUP_CFG][36]   
vakummatikModuCalismaSuresi                     holdingVariables[HOLDING_GROUP_CFG][37]   
vakummatikModuDurum                             holdingVariables[HOLDING_GROUP_CFG][38]
vakummatikTotalMoneyMsb                         holdingVariables[HOLDING_GROUP_CFG][39]
vakummatikTotalMoneyLsb                         holdingVariables[HOLDING_GROUP_CFG][40]
vakummatikTotalTotalMoney                       make32(vakummatikTotalMoneyMsb, vakummatikTotalMoneyLsb)
vakummatikTotalWorkingTimeMsb                   holdingVariables[HOLDING_GROUP_CFG][41]
vakummatikTotalWorkingTimeLsb                   holdingVariables[HOLDING_GROUP_CFG][42]
vakummatikTotalWorkingTime                      make32(vakummatikTotalWorkingTimeMsb, vakummatikTotalWorkingTimeLsb)

///GROUP NAME:cila
///GROUP NO:6
///PARAMETERS START NO:600
cilaModuTutar                                   holdingVariables[HOLDING_GROUP_CFG][43]   
cilaModuCalismaSuresi                           holdingVariables[HOLDING_GROUP_CFG][44]  
cilaModuDurum                                   holdingVariables[HOLDING_GROUP_CFG][45]  
cilaTotalMoneyMsb                               holdingVariables[HOLDING_GROUP_CFG][46]
cilaTotalMoneyLsb                               holdingVariables[HOLDING_GROUP_CFG][47]
cilaTotalTotalMoney                             make32(cilaTotalMoneyMsb, cilaTotalMoneyLsb)
cilaTotalWorkingTimeMsb                         holdingVariables[HOLDING_GROUP_CFG][48]
cilaTotalWorkingTimeLsb                         holdingVariables[HOLDING_GROUP_CFG][49]
cilaTotalWorkingTime                            make32(cilaTotalWorkingTimeMsb, cilaTotalWorkingTimeLsb)

///GROUP NAME:alarm
///GROUP NO:7
///PARAMETERS START NO:700
overFlowPulseCount                              holdingVariables[HOLDING_GROUP_CFG][50]   
lowerFlowPulseCount                             holdingVariables[HOLDING_GROUP_CFG][51]   
lowAmbientTemperature                           holdingVariables[HOLDING_GROUP_CFG][52]  
highAmbientTemperature                          holdingVariables[HOLDING_GROUP_CFG][53]
ambientTemperatureControl                       holdingVariables[HOLDING_GROUP_CFG][54]
pulserCountLimit                                holdingVariables[HOLDING_GROUP_CFG][55]

///GROUP NAME:
///GROUP NO:8
///PARAMETERS START NO:800
p10active                      holdingVariables[HOLDING_GROUP_CFG][56] 
#define clearTotals                    holdingVariables[HOLDING_GROUP_CFG][57] 

unsigned int16 holdingVariables[HOLDING_REGISTER_ROW_SIZE][HOLDING_REGISTER_COLUMN_SIZE];
unsigned int16 inputRegister[INPUT_REGISTER_SIZE] = {0};

////////////////////////////////////////////////////                                 
// GROUP NO                                                                             0,   1,   2,   3,   4,   5,   6,   7,   8
const unsigned int16 parameterLastIndexHoldingVariables[HOLDING_REGISTER_ROW_SIZE]=   { 57};


// PARAMETERS UPPER LIMIT VALUES
unsigned int16 const parameterUpperLimit[HOLDING_REGISTER_ROW_SIZE][HOLDING_REGISTER_COLUMN_SIZE] = {
//   0  ,  1  ,  2  ,  3  ,  4  ,  5  ,  6  ,  7  
//GROUP NO:0 GROUP NAME:CFG
//{"___","___","___","___","___","___","___","___"},
  {    0,    1,  254,  ver,  254,    1,    1,    1,

//GROUP NO:1 GROUP NAME:PASPAS
     100,  600,    1,    0,    0,    0,    0,
//GROUP NO:2 GROUP NAME:YIKAMA
       100,  600,    1,65535,65535,65535,65535,
//GROUP NO:3 GROUP NAME:KOPUK
       100,  600,    1,65535,65535,65535,65535,
//GROUP NO:4 GROUP NAME:AIRMATIK
       100,  600,    1,65535,65535,65535,65535,
//GROUP NO:5 GROUP NAME:VAKUMMATIK
     100,  600,    1,65535,65535,65535,65535,
//GROUP NO:6 GROUP NAME:CILA
       100,  600,    1,65535,65535,65535,65535,
//GROUP NO:7 GROUP NAME:ALARM
       2000, 2000,    1,    1,    1,  255,  
//GROUP NO:8 GROUP NAME:
        1,    1}
};


// lowerLimit[][]
// PARAMETERS LOWER LIMIT VALUES
unsigned int16 const parameterLowerLimit[HOLDING_REGISTER_ROW_SIZE][HOLDING_REGISTER_COLUMN_SIZE] = {
//   0  ,  1  ,  2  ,  3  ,  4  ,  5  ,  6  ,  7  
//GROUP NO:0 GROUP NAME:CFG
//{"___","___","___","___","___","___","___","___"},
  {    0,    0,    1,    0,    1,    0,    0,    0,
//GROUP NO:1 GROUP NAME:PASPAS
    0,    0,    0,    0,    0,    0,    0,
//GROUP NO:2 GROUP NAME:YIKAMA
    0,    0,    0,    0,    0,    0,    0,
//GROUP NO:3 GROUP NAME:KOPUK
   0,    0,    0,    0,    0,    0,    0,
//GROUP NO:4 GROUP NAME:AIRMATIK
     0,    0,    0,    0,    0,    0,    0,
//GROUP NO:5 GROUP NAME:VAKUMMATIK
     0,    0,    0,    0,    0,    0,    0,
//GROUP NO:6 GROUP NAME:CILA
   0,    0,    0,    0,    0,    0,    0,
//GROUP NO:7 GROUP NAME:ALARM
     
//GROUP NO:8 GROUP NAME:WORKING TIME
         0,    0}
};

// deafultValue[][]
// PARAMETERS DEFAULT VALUES
unsigned int16 const parameterDefaultValue[HOLDING_REGISTER_ROW_SIZE][HOLDING_REGISTER_COLUMN_SIZE] = {
//   0  ,  1  ,  2  ,  3  ,  4  ,  5  ,   6 ,   7 ,   
//GROUP NO:0 GROUP NAME:STAT
//{"___","___","___","___","___","___","___","___"},
  {    0,    1,    1,  ver,    1,    1,    0,    1,
//GROUP NO:1 GROUP NAME:PASPAS
//{"___","___","___","___","___","___","___","___"},
     2,   60,    0,    0,    0,    0,    0,
//GROUP NO:2 GROUP NAME:YIKAMA
//{"___","___","___","___","___","___","___","___"},
     2,  240,    1,    0,    0,    0,    0,
//GROUP NO:3 GROUP NAME:KOPUK
//{"___","___","___","___","___","___","___","___"},
     2,   60,    1,    0,    0,    0,    0,
//GROUP NO:4 GROUP NAME:AIRMATIK
//{"___","___","___","___","___","___","___","___"},
    2,  180,    0,    0,    0,    0,    0,
//GROUP NO:5 GROUP NAME:VAKUMMATIK
//{"___","___","___","___","___","___","___","___"},
   2,  240,    0,    0,    0,    0,    0,
//GROUP NO:6 GROUP NAME:CILA
//{"___","___","___","___","___","___","___","___"},
   2,  120,    0,    0,    0,    0,    0,
//GROUP NO:7 GROUP NAME:ALARM
//{"___","___","___","___","___","___","___","___"},
 1100,  100,    0,   50,    0,   20,
//GROUP NO:8 GROUP NAME:
//{"___","___","___","___","___","___","___","___"},
    1,    0}
};

// unitValue[10][24]
// PARAMETERS UNIT
unsigned int16 const parameterWritePermission[HOLDING_REGISTER_ROW_SIZE][HOLDING_REGISTER_COLUMN_SIZE] = {
//   0  ,  1  ,  2  ,  3  ,  4  ,  5  ,  6  ,  7  
//GROUP NO:0 GROUP NAME:CFG
//{"___","___","___","___","___","___","___","___"},
  {    1,    1,    1,    0,    1,    1,    1,    1,
//GROUP NO:1 GROUP NAME:PASPAS
//{"___","___","___","___","___","___","___","___"},
     1,    1,    1,    1,    1,    1,    1,
//GROUP NO:2 GROUP NAME:YIKAMA
//{"___","___","___","___","___","___","___","___"},
  1,    1,    1,    1,    1,    1,    1,
  //GROUP NO:3 GROUP NAME:KOPUK
//{"___","___","___","___","___","___","___","___"},
      1,    1,    1,    1,    1,    1,    1,
  //GROUP NO:4 GROUP NAME:AIRMATIK
//{"___","___","___","___","___","___","___","___"},
    1,    1,    1,    1,    1,    1,    1,
//GROUP NO:5 GROUP NAME:VAKUMMATIK
//{"___","___","___","___","___","___","___","___"},
   1,    1,    1,    1,    1,    1,    1,
//GROUP NO:6 GROUP NAME:CILA
//{"___","___","___","___","___","___","___","___"},
      1,    1,    1,    1,    1,    1,    1,
//GROUP NO:7 GROUP NAME:ALARM
//{"___","___","___","___","___","___","___","___"},
      1,    1,    1,    1,    1,    1,
//GROUP NO:8 GROUP NAME:WORKING TIME
//{"___","___","___","___","___","___","___","___"},
      1,    1}
};

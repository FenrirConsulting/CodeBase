create table ZZTECHLOG
(
  zztl_ref          NUMBER not null,
  zztl_state        NVARCHAR2(20),
  zztl_wotype       NVARCHAR2(30),
  zztl_woasset      NVARCHAR2(50),
  zztl_wocomplaint  NVARCHAR2(2000),
  zztl_worootcause  NVARCHAR2(2000),
  zztl_wocorrection NVARCHAR2(2000),
  zztl_genuser      NVARCHAR2(20),
  zztl_gendate      DATE,
  zztl_moduser      NVARCHAR2(20),
  zztl_moddate      DATE
);

create table ZZTECHLOG_PARTS
(
  zztlp_ref          NUMBER not null,
  zztl_ref           NUMBER,
  zztlp_qnty         NUMBER,
  zzhtlp_partnumber  NVARCHAR2(20),
  zzhtlp_location    NVARCHAR2(20),
  zzhtlp_description NVARCHAR2(200)
);

create table ZZTECHLOG_TECHS
(
  zztlt_name        VARCHAR2(50) not null,
  zztlt_shift       VARCHAR2(5),
  zztlt_islead      VARCHAR2(5) default 'False',
  zztlt_isadmin     VARCHAR2(5) default 'False',
  zztlt_ispartslead NVARCHAR2(5) default 'False',
  zztlt_isactive    VARCHAR2(5) default 'True',
  zztlt_pword       NVARCHAR2(12),
  zztlt_auname      VARCHAR2(50)
);

create table ZZTECHLOG_USER
(
  zztlu_ref   NUMBER not null,
  zztl_ref    NUMBER,
  zztlu_name  VARCHAR2(50),
  zztlu_time  NUMBER,
  zztlu_shift NUMBER,
  zztlu_date  DATE
);

create table ZZ_WEEKLY_REPORT
(
  zzwr_type  NUMBER,
  zzwr_date  DATE,
  zzwr_text  VARCHAR2(40),
  zzwr_var01 NUMBER,
  zzwr_var02 NUMBER,
  zzwr_var03 NUMBER,
  zzwr_var04 NUMBER,
  zzwr_var05 NUMBER,
  zzwr_var06 NUMBER,
  zzwr_var07 NUMBER,
  zzwr_var08 NUMBER,
  zzwr_var09 NUMBER,
  zzwr_var10 NUMBER,
  zzwr_var11 NUMBER,
  zzwr_var12 NUMBER,
  zzwr_var13 NUMBER,
  zzwr_var14 NUMBER
);

create table ZZ_DEPARTDATE
(
  dd_ref     NUMBER(10) not null,
  moddate    DATE not null,
  lrou_ref   NUMBER not null,
  newdepart  DATE not null,
  olddepart  DATE not null,
  mod_userno NUMBER
);

create table ZZHANDOVERLOG
(
  zzhol_ref          NUMBER not null,
  zzhol_state        NVARCHAR2(20),
  zzhol_wotype       NVARCHAR2(30),
  zzhol_woasset      NVARCHAR2(50),
  zzhol_woarea       NVARCHAR2(30),
  zzhol_wocomplaint  NVARCHAR2(2000),
  zzhol_worootcause  NVARCHAR2(2000),
  zzhol_wocorrection NVARCHAR2(2000),
  zzhol_wodowntime   NUMBER,
  zzhol_wonotes      NVARCHAR2(2000),
  zzhol_printdate    DATE,
  zzhol_genuser      NVARCHAR2(20),
  zzhol_gendate      DATE,
  zzhol_moduser      NVARCHAR2(20),
  zzhol_moddate      DATE
);

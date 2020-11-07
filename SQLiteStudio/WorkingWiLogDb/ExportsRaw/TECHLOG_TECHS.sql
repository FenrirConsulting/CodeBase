prompt PL/SQL Developer import file
prompt Created on Friday, October 30, 2020 by c067460
set feedback off
set define off
prompt Creating ZZTECHLOG_TECHS...
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
)
tablespace DATAS46024
  pctfree 10
  initrans 1
  maxtrans 255
  storage
  (
    initial 64K
    next 1M
    minextents 1
    maxextents unlimited
  );

prompt Loading ZZTECHLOG_TECHS...
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Farnell, Brian_OLD', '1', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Bonner, Gene_OLD', '1', 'False', 'False', 'False', 'False', '1749', '9997130');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Markel, Nathan_OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree1', '9997128');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Burchette, Boyd', '2', 'True', 'True', 'True', 'True', 'Palmtree', '1501398');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Landeros, Lopez', '2', 'False', 'False', 'True', 'True', 'Palmtree1', '1594843');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Farrell, Dave_OLD', '3', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Gamez, Armando_OLD', '3', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Hinzman, Nick_OLD', '1', 'False', 'False', 'False', 'False', '14553', '9997017');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Johnston, Richard_OLD', '3', 'False', 'False', 'False', 'False', '14555', '9997022');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Krueger, Ryan_OLD', '2', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('MacDougall, Mike_OLD', '1', 'False', 'False', 'False', 'False', '14114', '9997016');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('McCord, James_OLD', '1', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Mendenhall, Robert', '1', 'False', 'False', 'False', 'False', '7505', '9997037');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Sergel, Scott_OLD', '1', 'True', 'False', 'False', 'False', '14199', '9997024');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Smith, Jamie_OLD', '3', 'False', 'False', 'False', 'False', '145403', '9997020');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Steinke, Stephen_OLD', '2', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Tesnow, Scotty_OLD', '2', 'False', 'False', 'False', 'False', '14564', '9997025');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Moore, Matt_OLD', '1', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Merkel, Nathan_OLD', '3', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Jones, Ian_OLD', '3', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Vallajo, Elliot_OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree1', '9997139');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Zook, Jordan_OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree1', '9997144');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Steff, Mason_OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree1', '9997145');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Cox, Kris_OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree1', '9997146');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Bono, Nicholas', '2', 'False', 'False', 'False', 'True', 'Palmtree', '1241526');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Shuttz, David', '1', 'False', 'False', 'False', 'True', 'Palmtree', '0653579');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Mokumbu, Clement', '1', 'False', 'False', 'False', 'True', 'Palmtree', '1296118');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Fries, Andrew', '2', 'False', 'False', 'False', 'True', 'Palmtree', '0569269');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Fries, Eloisa', '2', 'False', 'False', 'False', 'True', 'Palmtree', '0708748');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Brothers, David_OLD', '1', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Pontius, Steve_OLD', '3', 'False', 'False', 'False', 'False', '1234', '9997106');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Fulton, Steve_OLD', '3', 'False', 'False', 'False', 'False', '1379', '9997110');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Sierk, Dylan_OLD', '1', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Vicars, Gary_OLD', '1', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Vallajo, Elliott_OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree1', '9997139');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Benjamin, Gabe', '1', 'True', 'True', 'True', 'True', 'Palmtree', '0329730');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Farnell, Brian', '1', 'True', 'True', 'True', 'True', '3034', '1515265');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Kris, Cox', '1', 'False', 'False', 'False', 'True', 'Palmtree', '0655225');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Scott Sergel', '1', 'False', 'False', 'False', 'True', 'Palmtree', '1741422');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Henderson, Marvin_OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree', '1752900');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Brandon Sharland _OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree', '1742360');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Steve Fulton', '2', 'True', 'False', 'True', 'True', 'Palmtree', '1741583');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Mike MacDougall', '1', 'True', 'False', 'True', 'True', 'Palmtree', '1742119');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Rob Olsen', '1', 'False', 'False', 'False', 'True', 'Palmtree', '1743475');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Emory Polley', '3', 'False', 'False', 'False', 'True', 'Palmtree', '1590612');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Sheldon Taitam', '2', 'False', 'False', 'False', 'True', 'Palmtree', '0702174');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Walker, Austin_OLD', '1', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Walker, Austin_OLD', '1', 'False', 'False', 'False', 'False', 'Palmtree1', null);
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Vicars, Gary_OLD', '1', 'False', 'Fasle', 'False', 'False', 'Palmtree1', '9997141');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Olson, Christopher', '1', 'True', 'True', 'True', 'True', '9012', '1444437');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Steinke, Steve', '2', 'True', 'False', 'True', 'True', 'Palmtree', '1741576');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Ley, Michael', '1', 'False', 'False', 'False', 'True', 'Palmtree', '1394396');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Loubriel, William', '1', 'False', 'False', 'False', 'True', 'Palmtree', '1431039');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Barboza, Miguel', '2', 'True', 'True', 'True', 'True', '51952', '0936719');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Jorge, Pena', '2', 'False', 'False', 'False', 'True', 'Palmtree1', '1028594');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('MITCHELL, DAN', '2', 'False', 'False', 'False', 'False', '6462', '9997018');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Teff, Michael', '1', 'False', 'False', 'False', 'False', '7569', '9997107');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Malloy, Brian_OLD', '3', 'False', 'False', 'False', 'False', 'NotHere321', ' ');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Tavarez, Otto', '1', 'False', 'False', 'False', 'False', '7501', '9997029');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('test, test', '3', 'True', 'True', 'True', 'False', 'PalmTree1', '999323232');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Olsen, Robert', '1', 'False', 'False', 'False', 'False', 'Palmtree1', '9997150');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Sharland, Brandon', '1', 'False', 'False', 'False', 'False', 'Palmtree1', '9997151');
insert into ZZTECHLOG_TECHS (zztlt_name, zztlt_shift, zztlt_islead, zztlt_isadmin, zztlt_ispartslead, zztlt_isactive, zztlt_pword, zztlt_auname)
values ('Bowen, Jesse', '1', 'True', 'True', 'True', 'True', 'Palmtree1', '1737702');
commit;
prompt 63 records loaded
set feedback on
set define on
prompt Done.

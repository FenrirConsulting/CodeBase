prompt PL/SQL Developer import file
prompt Created on Friday, October 30, 2020 by c067460
set feedback off
set define off
prompt Creating ZZ_DEPARTDATE...
create table ZZ_DEPARTDATE
(
  dd_ref     NUMBER(10) not null,
  moddate    DATE not null,
  lrou_ref   NUMBER not null,
  newdepart  DATE not null,
  olddepart  DATE not null,
  mod_userno NUMBER
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
comment on table ZZ_DEPARTDATE
  is 'Changes to Lroute.lrou_departdate,Fed from lroutr_updRow,Entries over 30 days are cleared via DBMS_Jobs #487655 on Sunday';
comment on column ZZ_DEPARTDATE.dd_ref
  is 'Internal Referance';
comment on column ZZ_DEPARTDATE.moddate
  is 'Date of change';
comment on column ZZ_DEPARTDATE.lrou_ref
  is 'lroute.lrou_ref';
comment on column ZZ_DEPARTDATE.newdepart
  is 'Modified date';
comment on column ZZ_DEPARTDATE.olddepart
  is 'Original date';
comment on column ZZ_DEPARTDATE.mod_userno
  is 'Modifing user';
alter table ZZ_DEPARTDATE
  add constraint DEPT_PK primary key (DD_REF)
  using index 
  tablespace INDXS51874
  pctfree 10
  initrans 2
  maxtrans 255
  storage
  (
    initial 256K
    next 256K
    minextents 1
    maxextents unlimited
  );

prompt Loading ZZ_DEPARTDATE...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52419, to_date('16-10-2020 15:42:12', 'dd-mm-yyyy hh24:mi:ss'), 124630, to_date('17-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52420, to_date('16-10-2020 15:42:42', 'dd-mm-yyyy hh24:mi:ss'), 124629, to_date('17-10-2020', 'dd-mm-yyyy'), to_date('16-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52421, to_date('16-10-2020 15:43:07', 'dd-mm-yyyy hh24:mi:ss'), 124628, to_date('16-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52422, to_date('16-10-2020 15:43:18', 'dd-mm-yyyy hh24:mi:ss'), 124627, to_date('16-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52423, to_date('16-10-2020 15:43:31', 'dd-mm-yyyy hh24:mi:ss'), 124626, to_date('16-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52424, to_date('16-10-2020 15:43:45', 'dd-mm-yyyy hh24:mi:ss'), 124625, to_date('16-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52425, to_date('16-10-2020 15:43:59', 'dd-mm-yyyy hh24:mi:ss'), 124624, to_date('16-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52426, to_date('16-10-2020 15:48:47', 'dd-mm-yyyy hh24:mi:ss'), 124623, to_date('16-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52427, to_date('16-10-2020 15:48:59', 'dd-mm-yyyy hh24:mi:ss'), 124622, to_date('16-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52428, to_date('16-10-2020 15:49:12', 'dd-mm-yyyy hh24:mi:ss'), 124621, to_date('16-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52429, to_date('16-10-2020 15:49:26', 'dd-mm-yyyy hh24:mi:ss'), 124620, to_date('16-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52430, to_date('16-10-2020 15:49:49', 'dd-mm-yyyy hh24:mi:ss'), 124619, to_date('16-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51157, to_date('28-09-2020 07:21:49', 'dd-mm-yyyy hh24:mi:ss'), 66111, to_date('28-09-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51158, to_date('28-09-2020 07:21:57', 'dd-mm-yyyy hh24:mi:ss'), 66110, to_date('28-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51159, to_date('28-09-2020 07:22:36', 'dd-mm-yyyy hh24:mi:ss'), 66112, to_date('28-09-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51160, to_date('28-09-2020 07:22:48', 'dd-mm-yyyy hh24:mi:ss'), 66112, to_date('28-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51161, to_date('28-09-2020 07:30:33', 'dd-mm-yyyy hh24:mi:ss'), 60133, to_date('28-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52345, to_date('14-10-2020 14:52:46', 'dd-mm-yyyy hh24:mi:ss'), 116056, to_date('14-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52346, to_date('14-10-2020 14:53:02', 'dd-mm-yyyy hh24:mi:ss'), 116055, to_date('14-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52347, to_date('14-10-2020 14:53:25', 'dd-mm-yyyy hh24:mi:ss'), 116054, to_date('14-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52348, to_date('14-10-2020 14:53:41', 'dd-mm-yyyy hh24:mi:ss'), 116053, to_date('14-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52349, to_date('14-10-2020 14:54:14', 'dd-mm-yyyy hh24:mi:ss'), 116052, to_date('14-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52350, to_date('14-10-2020 14:54:33', 'dd-mm-yyyy hh24:mi:ss'), 116051, to_date('14-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52351, to_date('14-10-2020 14:54:45', 'dd-mm-yyyy hh24:mi:ss'), 116050, to_date('14-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52352, to_date('14-10-2020 14:54:55', 'dd-mm-yyyy hh24:mi:ss'), 116049, to_date('14-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52353, to_date('14-10-2020 14:55:12', 'dd-mm-yyyy hh24:mi:ss'), 116048, to_date('14-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52354, to_date('14-10-2020 16:41:21', 'dd-mm-yyyy hh24:mi:ss'), 116057, to_date('15-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52355, to_date('14-10-2020 16:41:32', 'dd-mm-yyyy hh24:mi:ss'), 116057, to_date('15-10-2020', 'dd-mm-yyyy'), to_date('15-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52356, to_date('14-10-2020 16:41:44', 'dd-mm-yyyy hh24:mi:ss'), 116056, to_date('14-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52357, to_date('14-10-2020 16:41:55', 'dd-mm-yyyy hh24:mi:ss'), 116055, to_date('14-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52358, to_date('14-10-2020 16:42:06', 'dd-mm-yyyy hh24:mi:ss'), 116054, to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52359, to_date('14-10-2020 16:42:18', 'dd-mm-yyyy hh24:mi:ss'), 116053, to_date('14-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52360, to_date('14-10-2020 16:42:42', 'dd-mm-yyyy hh24:mi:ss'), 116052, to_date('14-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52361, to_date('14-10-2020 16:42:55', 'dd-mm-yyyy hh24:mi:ss'), 116051, to_date('14-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52362, to_date('14-10-2020 16:43:09', 'dd-mm-yyyy hh24:mi:ss'), 116050, to_date('14-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52363, to_date('14-10-2020 16:43:42', 'dd-mm-yyyy hh24:mi:ss'), 116049, to_date('14-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52364, to_date('14-10-2020 20:16:57', 'dd-mm-yyyy hh24:mi:ss'), 116057, to_date('15-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52365, to_date('14-10-2020 20:17:25', 'dd-mm-yyyy hh24:mi:ss'), 116056, to_date('15-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52366, to_date('14-10-2020 20:17:44', 'dd-mm-yyyy hh24:mi:ss'), 116055, to_date('15-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52367, to_date('14-10-2020 20:17:50', 'dd-mm-yyyy hh24:mi:ss'), 116055, to_date('15-10-2020 00:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51162, to_date('28-09-2020 07:30:43', 'dd-mm-yyyy hh24:mi:ss'), 60132, to_date('28-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51163, to_date('28-09-2020 07:31:18', 'dd-mm-yyyy hh24:mi:ss'), 60131, to_date('28-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51164, to_date('28-09-2020 07:31:29', 'dd-mm-yyyy hh24:mi:ss'), 60130, to_date('28-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51165, to_date('28-09-2020 07:31:40', 'dd-mm-yyyy hh24:mi:ss'), 60129, to_date('28-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51166, to_date('28-09-2020 07:31:54', 'dd-mm-yyyy hh24:mi:ss'), 60128, to_date('28-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51167, to_date('28-09-2020 07:32:07', 'dd-mm-yyyy hh24:mi:ss'), 60127, to_date('28-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51168, to_date('28-09-2020 07:32:18', 'dd-mm-yyyy hh24:mi:ss'), 60126, to_date('28-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51169, to_date('28-09-2020 07:32:48', 'dd-mm-yyyy hh24:mi:ss'), 60125, to_date('28-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51170, to_date('28-09-2020 07:32:59', 'dd-mm-yyyy hh24:mi:ss'), 60124, to_date('28-09-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51171, to_date('28-09-2020 07:33:16', 'dd-mm-yyyy hh24:mi:ss'), 60123, to_date('28-09-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51172, to_date('28-09-2020 07:33:27', 'dd-mm-yyyy hh24:mi:ss'), 60122, to_date('28-09-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51173, to_date('28-09-2020 07:33:37', 'dd-mm-yyyy hh24:mi:ss'), 60121, to_date('28-09-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51174, to_date('28-09-2020 07:33:48', 'dd-mm-yyyy hh24:mi:ss'), 60120, to_date('28-09-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51175, to_date('28-09-2020 07:34:01', 'dd-mm-yyyy hh24:mi:ss'), 60119, to_date('28-09-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51176, to_date('28-09-2020 07:34:14', 'dd-mm-yyyy hh24:mi:ss'), 60118, to_date('28-09-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51177, to_date('28-09-2020 07:34:26', 'dd-mm-yyyy hh24:mi:ss'), 60117, to_date('28-09-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51178, to_date('28-09-2020 07:34:45', 'dd-mm-yyyy hh24:mi:ss'), 60116, to_date('28-09-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51179, to_date('28-09-2020 07:34:58', 'dd-mm-yyyy hh24:mi:ss'), 60115, to_date('28-09-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51180, to_date('28-09-2020 07:35:10', 'dd-mm-yyyy hh24:mi:ss'), 60114, to_date('28-09-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51181, to_date('28-09-2020 07:35:46', 'dd-mm-yyyy hh24:mi:ss'), 60113, to_date('28-09-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51182, to_date('28-09-2020 07:35:57', 'dd-mm-yyyy hh24:mi:ss'), 60112, to_date('28-09-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51183, to_date('28-09-2020 07:36:11', 'dd-mm-yyyy hh24:mi:ss'), 60111, to_date('28-09-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51184, to_date('28-09-2020 07:36:23', 'dd-mm-yyyy hh24:mi:ss'), 60110, to_date('28-09-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51185, to_date('28-09-2020 07:36:35', 'dd-mm-yyyy hh24:mi:ss'), 60109, to_date('28-09-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51186, to_date('28-09-2020 07:37:00', 'dd-mm-yyyy hh24:mi:ss'), 60108, to_date('28-09-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51187, to_date('28-09-2020 07:37:12', 'dd-mm-yyyy hh24:mi:ss'), 60107, to_date('28-09-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51336, to_date('29-09-2020 06:07:58', 'dd-mm-yyyy hh24:mi:ss'), 60140, to_date('29-09-2020 06:09:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51339, to_date('29-09-2020 06:14:11', 'dd-mm-yyyy hh24:mi:ss'), 60157, to_date('29-09-2020 06:16:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51340, to_date('29-09-2020 06:17:16', 'dd-mm-yyyy hh24:mi:ss'), 60158, to_date('29-09-2020 06:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51341, to_date('29-09-2020 06:24:11', 'dd-mm-yyyy hh24:mi:ss'), 60159, to_date('29-09-2020 06:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51342, to_date('29-09-2020 06:29:28', 'dd-mm-yyyy hh24:mi:ss'), 60156, to_date('29-09-2020 06:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51343, to_date('29-09-2020 07:09:29', 'dd-mm-yyyy hh24:mi:ss'), 60167, to_date('29-09-2020 07:12:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51344, to_date('29-09-2020 07:12:37', 'dd-mm-yyyy hh24:mi:ss'), 60160, to_date('29-09-2020 07:14:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51345, to_date('29-09-2020 07:18:03', 'dd-mm-yyyy hh24:mi:ss'), 60163, to_date('29-09-2020 07:19:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51363, to_date('29-09-2020 08:38:49', 'dd-mm-yyyy hh24:mi:ss'), 60159, to_date('29-09-2020 08:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 06:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51365, to_date('29-09-2020 08:39:55', 'dd-mm-yyyy hh24:mi:ss'), 60158, to_date('29-09-2020 08:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 06:18:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51366, to_date('29-09-2020 08:42:33', 'dd-mm-yyyy hh24:mi:ss'), 60156, to_date('29-09-2020 08:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 06:31:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51367, to_date('29-09-2020 08:44:45', 'dd-mm-yyyy hh24:mi:ss'), 60159, to_date('29-09-2020 08:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 08:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51369, to_date('29-09-2020 09:37:04', 'dd-mm-yyyy hh24:mi:ss'), 66112, to_date('29-09-2020 09:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51370, to_date('29-09-2020 09:39:11', 'dd-mm-yyyy hh24:mi:ss'), 66110, to_date('29-09-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51371, to_date('29-09-2020 09:40:58', 'dd-mm-yyyy hh24:mi:ss'), 66108, to_date('29-09-2020 09:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51372, to_date('29-09-2020 09:43:30', 'dd-mm-yyyy hh24:mi:ss'), 60151, to_date('29-09-2020 09:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51377, to_date('29-09-2020 09:59:29', 'dd-mm-yyyy hh24:mi:ss'), 60154, to_date('29-09-2020 10:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51379, to_date('29-09-2020 10:01:10', 'dd-mm-yyyy hh24:mi:ss'), 60153, to_date('29-09-2020 10:03:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51380, to_date('29-09-2020 10:03:32', 'dd-mm-yyyy hh24:mi:ss'), 60152, to_date('29-09-2020 10:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51382, to_date('29-09-2020 10:05:00', 'dd-mm-yyyy hh24:mi:ss'), 60155, to_date('29-09-2020 10:06:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51386, to_date('29-09-2020 10:06:51', 'dd-mm-yyyy hh24:mi:ss'), 60143, to_date('29-09-2020 10:08:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51387, to_date('29-09-2020 10:08:40', 'dd-mm-yyyy hh24:mi:ss'), 72493, to_date('29-09-2020 10:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52543, to_date('22-10-2020 10:04:25', 'dd-mm-yyyy hh24:mi:ss'), 151296, to_date('22-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52544, to_date('22-10-2020 10:04:36', 'dd-mm-yyyy hh24:mi:ss'), 151297, to_date('22-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51389, to_date('29-09-2020 10:12:36', 'dd-mm-yyyy hh24:mi:ss'), 72494, to_date('29-09-2020 10:14:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51391, to_date('29-09-2020 10:14:01', 'dd-mm-yyyy hh24:mi:ss'), 72492, to_date('29-09-2020 10:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51396, to_date('29-09-2020 10:30:03', 'dd-mm-yyyy hh24:mi:ss'), 60162, to_date('29-09-2020 10:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51397, to_date('29-09-2020 10:31:56', 'dd-mm-yyyy hh24:mi:ss'), 60161, to_date('29-09-2020 10:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51398, to_date('29-09-2020 10:33:30', 'dd-mm-yyyy hh24:mi:ss'), 66100, to_date('29-09-2020 10:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:10:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51399, to_date('29-09-2020 10:35:18', 'dd-mm-yyyy hh24:mi:ss'), 66102, to_date('29-09-2020 10:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51400, to_date('29-09-2020 10:36:30', 'dd-mm-yyyy hh24:mi:ss'), 60164, to_date('29-09-2020 10:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51401, to_date('29-09-2020 10:37:44', 'dd-mm-yyyy hh24:mi:ss'), 60165, to_date('29-09-2020 10:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51402, to_date('29-09-2020 10:39:22', 'dd-mm-yyyy hh24:mi:ss'), 60148, to_date('29-09-2020 10:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51403, to_date('29-09-2020 10:40:45', 'dd-mm-yyyy hh24:mi:ss'), 60142, to_date('29-09-2020 10:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
commit;
prompt 100 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51156, to_date('28-09-2020 07:21:43', 'dd-mm-yyyy hh24:mi:ss'), 66111, to_date('28-09-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51404, to_date('29-09-2020 10:58:55', 'dd-mm-yyyy hh24:mi:ss'), 66101, to_date('29-09-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51405, to_date('29-09-2020 11:07:49', 'dd-mm-yyyy hh24:mi:ss'), 60171, to_date('29-09-2020 11:09:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:28:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51406, to_date('29-09-2020 11:10:37', 'dd-mm-yyyy hh24:mi:ss'), 66088, to_date('29-09-2020 11:12:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51407, to_date('29-09-2020 11:13:00', 'dd-mm-yyyy hh24:mi:ss'), 66098, to_date('29-09-2020 11:14:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51408, to_date('29-09-2020 11:14:14', 'dd-mm-yyyy hh24:mi:ss'), 66114, to_date('29-09-2020 11:16:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52344, to_date('14-10-2020 14:51:45', 'dd-mm-yyyy hh24:mi:ss'), 116057, to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52090, to_date('09-10-2020 09:35:33', 'dd-mm-yyyy hh24:mi:ss'), 103449, to_date('12-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52091, to_date('09-10-2020 09:35:39', 'dd-mm-yyyy hh24:mi:ss'), 103449, to_date('12-10-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52092, to_date('09-10-2020 09:35:50', 'dd-mm-yyyy hh24:mi:ss'), 103448, to_date('12-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52093, to_date('09-10-2020 09:35:57', 'dd-mm-yyyy hh24:mi:ss'), 103448, to_date('12-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52094, to_date('09-10-2020 09:36:10', 'dd-mm-yyyy hh24:mi:ss'), 103447, to_date('12-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52095, to_date('09-10-2020 09:36:19', 'dd-mm-yyyy hh24:mi:ss'), 103447, to_date('12-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52096, to_date('09-10-2020 09:36:58', 'dd-mm-yyyy hh24:mi:ss'), 103446, to_date('09-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52097, to_date('09-10-2020 09:37:09', 'dd-mm-yyyy hh24:mi:ss'), 103445, to_date('09-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52098, to_date('09-10-2020 09:38:09', 'dd-mm-yyyy hh24:mi:ss'), 103444, to_date('09-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52099, to_date('09-10-2020 09:38:23', 'dd-mm-yyyy hh24:mi:ss'), 103443, to_date('09-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52100, to_date('09-10-2020 09:38:37', 'dd-mm-yyyy hh24:mi:ss'), 103442, to_date('09-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52101, to_date('09-10-2020 09:38:49', 'dd-mm-yyyy hh24:mi:ss'), 103441, to_date('09-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52102, to_date('09-10-2020 09:39:02', 'dd-mm-yyyy hh24:mi:ss'), 103440, to_date('09-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52103, to_date('09-10-2020 09:39:13', 'dd-mm-yyyy hh24:mi:ss'), 103439, to_date('09-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52104, to_date('09-10-2020 09:39:37', 'dd-mm-yyyy hh24:mi:ss'), 103438, to_date('09-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52105, to_date('09-10-2020 09:39:47', 'dd-mm-yyyy hh24:mi:ss'), 103437, to_date('09-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52106, to_date('09-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), 103436, to_date('09-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52107, to_date('09-10-2020 09:40:12', 'dd-mm-yyyy hh24:mi:ss'), 103435, to_date('09-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52108, to_date('09-10-2020 09:49:46', 'dd-mm-yyyy hh24:mi:ss'), 103434, to_date('09-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52109, to_date('09-10-2020 09:49:57', 'dd-mm-yyyy hh24:mi:ss'), 103433, to_date('09-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52110, to_date('09-10-2020 09:50:08', 'dd-mm-yyyy hh24:mi:ss'), 103432, to_date('09-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52111, to_date('09-10-2020 09:50:19', 'dd-mm-yyyy hh24:mi:ss'), 103431, to_date('09-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52112, to_date('09-10-2020 09:50:29', 'dd-mm-yyyy hh24:mi:ss'), 103430, to_date('09-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52113, to_date('09-10-2020 09:50:41', 'dd-mm-yyyy hh24:mi:ss'), 103429, to_date('09-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52114, to_date('09-10-2020 09:50:51', 'dd-mm-yyyy hh24:mi:ss'), 103428, to_date('09-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52115, to_date('09-10-2020 09:51:04', 'dd-mm-yyyy hh24:mi:ss'), 103427, to_date('09-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52116, to_date('09-10-2020 09:51:20', 'dd-mm-yyyy hh24:mi:ss'), 103426, to_date('09-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52117, to_date('09-10-2020 09:51:33', 'dd-mm-yyyy hh24:mi:ss'), 103425, to_date('09-10-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52118, to_date('09-10-2020 09:52:11', 'dd-mm-yyyy hh24:mi:ss'), 103423, to_date('09-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52119, to_date('09-10-2020 09:52:34', 'dd-mm-yyyy hh24:mi:ss'), 103422, to_date('09-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52120, to_date('09-10-2020 09:52:48', 'dd-mm-yyyy hh24:mi:ss'), 103421, to_date('09-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51547, to_date('01-10-2020 12:57:16', 'dd-mm-yyyy hh24:mi:ss'), 76381, to_date('01-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51548, to_date('01-10-2020 12:57:27', 'dd-mm-yyyy hh24:mi:ss'), 76380, to_date('01-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51549, to_date('01-10-2020 12:57:38', 'dd-mm-yyyy hh24:mi:ss'), 76379, to_date('01-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51550, to_date('01-10-2020 12:57:52', 'dd-mm-yyyy hh24:mi:ss'), 76378, to_date('01-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51551, to_date('01-10-2020 12:58:02', 'dd-mm-yyyy hh24:mi:ss'), 76377, to_date('01-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51552, to_date('01-10-2020 12:58:32', 'dd-mm-yyyy hh24:mi:ss'), 76376, to_date('01-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51553, to_date('01-10-2020 12:58:48', 'dd-mm-yyyy hh24:mi:ss'), 76375, to_date('01-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51554, to_date('01-10-2020 12:59:01', 'dd-mm-yyyy hh24:mi:ss'), 76374, to_date('01-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51555, to_date('01-10-2020 12:59:12', 'dd-mm-yyyy hh24:mi:ss'), 76373, to_date('01-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51556, to_date('01-10-2020 12:59:37', 'dd-mm-yyyy hh24:mi:ss'), 76372, to_date('01-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51557, to_date('01-10-2020 13:00:10', 'dd-mm-yyyy hh24:mi:ss'), 76371, to_date('01-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51558, to_date('01-10-2020 13:00:21', 'dd-mm-yyyy hh24:mi:ss'), 76370, to_date('01-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51559, to_date('01-10-2020 13:01:01', 'dd-mm-yyyy hh24:mi:ss'), 76369, to_date('01-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52088, to_date('09-10-2020 09:34:57', 'dd-mm-yyyy hh24:mi:ss'), 103450, to_date('12-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52089, to_date('09-10-2020 09:35:20', 'dd-mm-yyyy hh24:mi:ss'), 103450, to_date('12-10-2020 11:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52155, to_date('12-10-2020 07:44:18', 'dd-mm-yyyy hh24:mi:ss'), 5309, to_date('12-10-2020 07:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 14:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52156, to_date('12-10-2020 07:45:52', 'dd-mm-yyyy hh24:mi:ss'), 10413, to_date('12-10-2020 07:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:19:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52157, to_date('12-10-2020 07:47:47', 'dd-mm-yyyy hh24:mi:ss'), 10428, to_date('12-10-2020 07:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52158, to_date('12-10-2020 07:49:15', 'dd-mm-yyyy hh24:mi:ss'), 10432, to_date('12-10-2020 07:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52159, to_date('12-10-2020 07:59:25', 'dd-mm-yyyy hh24:mi:ss'), 10436, to_date('12-10-2020 08:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52160, to_date('12-10-2020 08:01:14', 'dd-mm-yyyy hh24:mi:ss'), 5288, to_date('12-10-2020 08:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:05:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52161, to_date('12-10-2020 08:02:33', 'dd-mm-yyyy hh24:mi:ss'), 7989, to_date('12-10-2020 08:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52162, to_date('12-10-2020 08:03:50', 'dd-mm-yyyy hh24:mi:ss'), 7987, to_date('12-10-2020 08:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52163, to_date('12-10-2020 08:15:55', 'dd-mm-yyyy hh24:mi:ss'), 5286, to_date('12-10-2020 08:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:04:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52164, to_date('12-10-2020 08:17:14', 'dd-mm-yyyy hh24:mi:ss'), 5289, to_date('12-10-2020 08:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:07:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52165, to_date('12-10-2020 08:18:21', 'dd-mm-yyyy hh24:mi:ss'), 10423, to_date('12-10-2020 08:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52166, to_date('12-10-2020 08:20:14', 'dd-mm-yyyy hh24:mi:ss'), 10414, to_date('12-10-2020 08:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51533, to_date('01-10-2020 08:13:05', 'dd-mm-yyyy hh24:mi:ss'), 76352, to_date('01-10-2020 11:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14266);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51534, to_date('01-10-2020 08:14:32', 'dd-mm-yyyy hh24:mi:ss'), 76354, to_date('01-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14266);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52276, to_date('13-10-2020 11:49:44', 'dd-mm-yyyy hh24:mi:ss'), 114743, to_date('13-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52277, to_date('13-10-2020 11:49:54', 'dd-mm-yyyy hh24:mi:ss'), 114742, to_date('13-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52278, to_date('13-10-2020 11:50:04', 'dd-mm-yyyy hh24:mi:ss'), 114741, to_date('13-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52279, to_date('13-10-2020 11:50:26', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('13-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52280, to_date('13-10-2020 11:50:36', 'dd-mm-yyyy hh24:mi:ss'), 114738, to_date('13-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52281, to_date('13-10-2020 11:50:45', 'dd-mm-yyyy hh24:mi:ss'), 114737, to_date('13-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52282, to_date('13-10-2020 11:50:56', 'dd-mm-yyyy hh24:mi:ss'), 114736, to_date('13-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52283, to_date('13-10-2020 11:51:05', 'dd-mm-yyyy hh24:mi:ss'), 114735, to_date('13-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52284, to_date('13-10-2020 11:51:16', 'dd-mm-yyyy hh24:mi:ss'), 114734, to_date('13-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52285, to_date('13-10-2020 11:51:27', 'dd-mm-yyyy hh24:mi:ss'), 114733, to_date('13-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52286, to_date('13-10-2020 11:51:38', 'dd-mm-yyyy hh24:mi:ss'), 114732, to_date('13-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52287, to_date('13-10-2020 11:51:48', 'dd-mm-yyyy hh24:mi:ss'), 114731, to_date('13-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52288, to_date('13-10-2020 11:51:59', 'dd-mm-yyyy hh24:mi:ss'), 114730, to_date('13-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52289, to_date('13-10-2020 11:52:08', 'dd-mm-yyyy hh24:mi:ss'), 114729, to_date('13-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52290, to_date('13-10-2020 11:52:18', 'dd-mm-yyyy hh24:mi:ss'), 114728, to_date('13-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52291, to_date('13-10-2020 11:52:27', 'dd-mm-yyyy hh24:mi:ss'), 114727, to_date('13-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52292, to_date('13-10-2020 11:52:37', 'dd-mm-yyyy hh24:mi:ss'), 114726, to_date('13-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52293, to_date('13-10-2020 11:52:49', 'dd-mm-yyyy hh24:mi:ss'), 114725, to_date('13-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52294, to_date('13-10-2020 11:53:03', 'dd-mm-yyyy hh24:mi:ss'), 114724, to_date('13-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52295, to_date('13-10-2020 11:53:16', 'dd-mm-yyyy hh24:mi:ss'), 114723, to_date('13-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52296, to_date('13-10-2020 11:53:31', 'dd-mm-yyyy hh24:mi:ss'), 114722, to_date('13-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52297, to_date('13-10-2020 11:53:44', 'dd-mm-yyyy hh24:mi:ss'), 114721, to_date('13-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52298, to_date('13-10-2020 13:42:29', 'dd-mm-yyyy hh24:mi:ss'), 114743, to_date('14-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52299, to_date('13-10-2020 13:42:53', 'dd-mm-yyyy hh24:mi:ss'), 114743, to_date('14-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52300, to_date('13-10-2020 13:44:06', 'dd-mm-yyyy hh24:mi:ss'), 114742, to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52301, to_date('13-10-2020 13:44:12', 'dd-mm-yyyy hh24:mi:ss'), 114742, to_date('14-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52302, to_date('13-10-2020 13:44:35', 'dd-mm-yyyy hh24:mi:ss'), 114741, to_date('14-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52303, to_date('13-10-2020 13:44:42', 'dd-mm-yyyy hh24:mi:ss'), 114741, to_date('14-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52304, to_date('13-10-2020 13:44:52', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('14-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52305, to_date('13-10-2020 13:44:58', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('14-10-2020', 'dd-mm-yyyy'), to_date('14-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52306, to_date('13-10-2020 13:45:24', 'dd-mm-yyyy hh24:mi:ss'), 114738, to_date('13-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52307, to_date('13-10-2020 13:45:32', 'dd-mm-yyyy hh24:mi:ss'), 114740, to_date('13-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52308, to_date('13-10-2020 13:46:26', 'dd-mm-yyyy hh24:mi:ss'), 114740, to_date('14-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
commit;
prompt 200 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52309, to_date('13-10-2020 13:46:31', 'dd-mm-yyyy hh24:mi:ss'), 114740, to_date('14-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52310, to_date('13-10-2020 13:46:55', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020', 'dd-mm-yyyy'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52311, to_date('13-10-2020 13:47:02', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('13-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52312, to_date('13-10-2020 13:49:01', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52313, to_date('13-10-2020 13:49:10', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('14-10-2020', 'dd-mm-yyyy'), to_date('14-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52314, to_date('13-10-2020 13:49:39', 'dd-mm-yyyy hh24:mi:ss'), 114737, to_date('13-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52315, to_date('13-10-2020 13:50:15', 'dd-mm-yyyy hh24:mi:ss'), 114736, to_date('13-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52316, to_date('13-10-2020 13:50:29', 'dd-mm-yyyy hh24:mi:ss'), 114735, to_date('13-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52317, to_date('13-10-2020 13:50:39', 'dd-mm-yyyy hh24:mi:ss'), 114734, to_date('13-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52318, to_date('13-10-2020 13:50:53', 'dd-mm-yyyy hh24:mi:ss'), 114733, to_date('13-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51320, to_date('28-09-2020 22:42:44', 'dd-mm-yyyy hh24:mi:ss'), 60127, to_date('29-09-2020 08:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 08:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51321, to_date('28-09-2020 22:42:56', 'dd-mm-yyyy hh24:mi:ss'), 60128, to_date('29-09-2020 08:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 08:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51322, to_date('28-09-2020 22:43:14', 'dd-mm-yyyy hh24:mi:ss'), 60129, to_date('29-09-2020 08:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51323, to_date('28-09-2020 22:43:28', 'dd-mm-yyyy hh24:mi:ss'), 60130, to_date('29-09-2020 08:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51324, to_date('28-09-2020 22:43:37', 'dd-mm-yyyy hh24:mi:ss'), 60130, to_date('29-09-2020 08:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 08:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51325, to_date('28-09-2020 22:44:28', 'dd-mm-yyyy hh24:mi:ss'), 60130, to_date('29-09-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 08:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51326, to_date('28-09-2020 22:44:37', 'dd-mm-yyyy hh24:mi:ss'), 60130, to_date('29-09-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51327, to_date('28-09-2020 22:44:51', 'dd-mm-yyyy hh24:mi:ss'), 60131, to_date('29-09-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51328, to_date('28-09-2020 22:59:58', 'dd-mm-yyyy hh24:mi:ss'), 66119, to_date('24-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51329, to_date('28-09-2020 23:00:15', 'dd-mm-yyyy hh24:mi:ss'), 66119, to_date('24-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51330, to_date('28-09-2020 23:04:46', 'dd-mm-yyyy hh24:mi:ss'), 60130, to_date('29-09-2020 08:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51331, to_date('28-09-2020 23:05:06', 'dd-mm-yyyy hh24:mi:ss'), 60131, to_date('29-09-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51332, to_date('28-09-2020 23:06:01', 'dd-mm-yyyy hh24:mi:ss'), 60132, to_date('29-09-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51333, to_date('28-09-2020 23:06:09', 'dd-mm-yyyy hh24:mi:ss'), 60132, to_date('29-09-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51334, to_date('28-09-2020 23:06:31', 'dd-mm-yyyy hh24:mi:ss'), 60133, to_date('29-09-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51335, to_date('28-09-2020 23:06:40', 'dd-mm-yyyy hh24:mi:ss'), 60133, to_date('29-09-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51535, to_date('01-10-2020 09:23:48', 'dd-mm-yyyy hh24:mi:ss'), 76353, to_date('01-10-2020 12:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51536, to_date('01-10-2020 09:24:04', 'dd-mm-yyyy hh24:mi:ss'), 76355, to_date('01-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51918, to_date('06-10-2020 11:12:10', 'dd-mm-yyyy hh24:mi:ss'), 89199, to_date('06-10-2020 14:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51919, to_date('06-10-2020 11:12:33', 'dd-mm-yyyy hh24:mi:ss'), 89199, to_date('06-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 14:15:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51920, to_date('06-10-2020 11:13:19', 'dd-mm-yyyy hh24:mi:ss'), 89201, to_date('06-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51921, to_date('06-10-2020 11:13:34', 'dd-mm-yyyy hh24:mi:ss'), 89202, to_date('06-10-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52436, to_date('19-10-2020 07:48:49', 'dd-mm-yyyy hh24:mi:ss'), 130437, to_date('19-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52437, to_date('19-10-2020 07:48:59', 'dd-mm-yyyy hh24:mi:ss'), 130438, to_date('19-10-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52438, to_date('19-10-2020 07:49:10', 'dd-mm-yyyy hh24:mi:ss'), 130439, to_date('19-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52439, to_date('19-10-2020 07:49:28', 'dd-mm-yyyy hh24:mi:ss'), 130440, to_date('19-10-2020 12:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52440, to_date('19-10-2020 07:49:43', 'dd-mm-yyyy hh24:mi:ss'), 130441, to_date('19-10-2020 12:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52530, to_date('21-10-2020 17:33:33', 'dd-mm-yyyy hh24:mi:ss'), 140402, to_date('21-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52531, to_date('21-10-2020 17:33:43', 'dd-mm-yyyy hh24:mi:ss'), 140401, to_date('21-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52532, to_date('21-10-2020 17:33:54', 'dd-mm-yyyy hh24:mi:ss'), 140400, to_date('21-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52533, to_date('21-10-2020 17:34:07', 'dd-mm-yyyy hh24:mi:ss'), 140399, to_date('21-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52534, to_date('21-10-2020 17:34:20', 'dd-mm-yyyy hh24:mi:ss'), 140398, to_date('21-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52535, to_date('21-10-2020 18:00:51', 'dd-mm-yyyy hh24:mi:ss'), 140396, to_date('21-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52536, to_date('21-10-2020 20:48:36', 'dd-mm-yyyy hh24:mi:ss'), 151289, to_date('22-10-2020', 'dd-mm-yyyy'), to_date('22-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52537, to_date('21-10-2020 20:48:53', 'dd-mm-yyyy hh24:mi:ss'), 151290, to_date('22-10-2020 00:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52538, to_date('21-10-2020 20:49:19', 'dd-mm-yyyy hh24:mi:ss'), 151291, to_date('22-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52736, to_date('28-10-2020 19:17:38', 'dd-mm-yyyy hh24:mi:ss'), 172294, to_date('29-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52737, to_date('28-10-2020 19:17:44', 'dd-mm-yyyy hh24:mi:ss'), 172294, to_date('29-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52738, to_date('28-10-2020 19:17:57', 'dd-mm-yyyy hh24:mi:ss'), 172293, to_date('29-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52739, to_date('28-10-2020 19:18:04', 'dd-mm-yyyy hh24:mi:ss'), 172293, to_date('29-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52740, to_date('28-10-2020 19:18:17', 'dd-mm-yyyy hh24:mi:ss'), 172292, to_date('29-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52741, to_date('28-10-2020 19:18:23', 'dd-mm-yyyy hh24:mi:ss'), 172292, to_date('29-10-2020', 'dd-mm-yyyy'), to_date('29-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52742, to_date('28-10-2020 19:18:35', 'dd-mm-yyyy hh24:mi:ss'), 172291, to_date('28-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52743, to_date('28-10-2020 19:18:45', 'dd-mm-yyyy hh24:mi:ss'), 172290, to_date('28-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51927, to_date('06-10-2020 14:45:39', 'dd-mm-yyyy hh24:mi:ss'), 89207, to_date('06-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51928, to_date('06-10-2020 14:45:59', 'dd-mm-yyyy hh24:mi:ss'), 89208, to_date('06-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51929, to_date('06-10-2020 14:46:07', 'dd-mm-yyyy hh24:mi:ss'), 89208, to_date('06-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52546, to_date('22-10-2020 11:18:54', 'dd-mm-yyyy hh24:mi:ss'), 151299, to_date('22-10-2020 14:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 12017);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52547, to_date('22-10-2020 11:19:05', 'dd-mm-yyyy hh24:mi:ss'), 151300, to_date('22-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 12017);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51409, to_date('29-09-2020 11:15:31', 'dd-mm-yyyy hh24:mi:ss'), 66113, to_date('29-09-2020 11:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51410, to_date('29-09-2020 11:16:55', 'dd-mm-yyyy hh24:mi:ss'), 66115, to_date('29-09-2020 11:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51411, to_date('29-09-2020 11:24:49', 'dd-mm-yyyy hh24:mi:ss'), 66116, to_date('29-09-2020 11:26:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51412, to_date('29-09-2020 11:26:12', 'dd-mm-yyyy hh24:mi:ss'), 66117, to_date('29-09-2020 11:27:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51413, to_date('29-09-2020 11:27:32', 'dd-mm-yyyy hh24:mi:ss'), 66118, to_date('29-09-2020 11:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51414, to_date('29-09-2020 11:28:50', 'dd-mm-yyyy hh24:mi:ss'), 66119, to_date('29-09-2020 11:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51415, to_date('29-09-2020 11:30:19', 'dd-mm-yyyy hh24:mi:ss'), 66103, to_date('29-09-2020 11:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51416, to_date('29-09-2020 11:34:37', 'dd-mm-yyyy hh24:mi:ss'), 66105, to_date('29-09-2020 11:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51925, to_date('06-10-2020 14:45:10', 'dd-mm-yyyy hh24:mi:ss'), 89205, to_date('06-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51926, to_date('06-10-2020 14:45:25', 'dd-mm-yyyy hh24:mi:ss'), 89206, to_date('06-10-2020 18:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51930, to_date('06-10-2020 14:46:35', 'dd-mm-yyyy hh24:mi:ss'), 89209, to_date('06-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51931, to_date('06-10-2020 15:59:56', 'dd-mm-yyyy hh24:mi:ss'), 89210, to_date('06-10-2020 19:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51932, to_date('06-10-2020 16:00:07', 'dd-mm-yyyy hh24:mi:ss'), 89211, to_date('06-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51933, to_date('06-10-2020 16:00:20', 'dd-mm-yyyy hh24:mi:ss'), 89212, to_date('06-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51934, to_date('06-10-2020 16:00:35', 'dd-mm-yyyy hh24:mi:ss'), 89213, to_date('06-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52545, to_date('22-10-2020 11:18:30', 'dd-mm-yyyy hh24:mi:ss'), 151298, to_date('22-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 12017);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51098, to_date('25-09-2020 15:07:21', 'dd-mm-yyyy hh24:mi:ss'), 985221, to_date('04-10-2020 06:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 06:02:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51099, to_date('25-09-2020 15:07:38', 'dd-mm-yyyy hh24:mi:ss'), 988002, to_date('04-10-2020 08:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 08:52:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51100, to_date('25-09-2020 15:07:48', 'dd-mm-yyyy hh24:mi:ss'), 988002, to_date('04-10-2020 08:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 08:52:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51101, to_date('25-09-2020 15:57:55', 'dd-mm-yyyy hh24:mi:ss'), 54048, to_date('26-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51102, to_date('25-09-2020 15:58:05', 'dd-mm-yyyy hh24:mi:ss'), 54048, to_date('26-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51103, to_date('25-09-2020 15:58:19', 'dd-mm-yyyy hh24:mi:ss'), 54047, to_date('26-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51104, to_date('25-09-2020 15:58:27', 'dd-mm-yyyy hh24:mi:ss'), 54047, to_date('26-09-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51105, to_date('25-09-2020 15:58:40', 'dd-mm-yyyy hh24:mi:ss'), 54046, to_date('26-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51106, to_date('25-09-2020 15:58:51', 'dd-mm-yyyy hh24:mi:ss'), 54046, to_date('26-09-2020', 'dd-mm-yyyy'), to_date('26-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51107, to_date('25-09-2020 15:59:03', 'dd-mm-yyyy hh24:mi:ss'), 54045, to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51108, to_date('25-09-2020 15:59:12', 'dd-mm-yyyy hh24:mi:ss'), 54044, to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51109, to_date('25-09-2020 15:59:24', 'dd-mm-yyyy hh24:mi:ss'), 54043, to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51110, to_date('25-09-2020 15:59:37', 'dd-mm-yyyy hh24:mi:ss'), 54042, to_date('25-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51111, to_date('25-09-2020 16:00:21', 'dd-mm-yyyy hh24:mi:ss'), 54041, to_date('25-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51112, to_date('25-09-2020 16:00:35', 'dd-mm-yyyy hh24:mi:ss'), 54040, to_date('25-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51113, to_date('25-09-2020 16:00:57', 'dd-mm-yyyy hh24:mi:ss'), 54039, to_date('25-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51114, to_date('25-09-2020 16:01:09', 'dd-mm-yyyy hh24:mi:ss'), 54038, to_date('25-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51115, to_date('25-09-2020 16:01:20', 'dd-mm-yyyy hh24:mi:ss'), 54037, to_date('25-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52607, to_date('23-10-2020 14:16:41', 'dd-mm-yyyy hh24:mi:ss'), 157603, to_date('26-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52608, to_date('23-10-2020 14:16:52', 'dd-mm-yyyy hh24:mi:ss'), 157603, to_date('26-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52609, to_date('23-10-2020 14:17:14', 'dd-mm-yyyy hh24:mi:ss'), 157602, to_date('24-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52610, to_date('23-10-2020 14:17:29', 'dd-mm-yyyy hh24:mi:ss'), 157601, to_date('24-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51155, to_date('28-09-2020 06:11:05', 'dd-mm-yyyy hh24:mi:ss'), 66088, to_date('28-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 08:55:00', 'dd-mm-yyyy hh24:mi:ss'), 12311);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51432, to_date('29-09-2020 17:52:39', 'dd-mm-yyyy hh24:mi:ss'), 66081, to_date('29-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51433, to_date('29-09-2020 17:52:51', 'dd-mm-yyyy hh24:mi:ss'), 66080, to_date('29-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
commit;
prompt 300 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51434, to_date('29-09-2020 17:53:03', 'dd-mm-yyyy hh24:mi:ss'), 66079, to_date('29-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51435, to_date('29-09-2020 17:53:16', 'dd-mm-yyyy hh24:mi:ss'), 66078, to_date('29-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51436, to_date('29-09-2020 17:53:28', 'dd-mm-yyyy hh24:mi:ss'), 66077, to_date('29-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51437, to_date('29-09-2020 17:53:42', 'dd-mm-yyyy hh24:mi:ss'), 66076, to_date('29-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51438, to_date('29-09-2020 19:22:45', 'dd-mm-yyyy hh24:mi:ss'), 72536, to_date('24-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51439, to_date('29-09-2020 19:22:58', 'dd-mm-yyyy hh24:mi:ss'), 72536, to_date('24-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51440, to_date('29-09-2020 19:23:14', 'dd-mm-yyyy hh24:mi:ss'), 72537, to_date('24-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51441, to_date('29-09-2020 19:23:21', 'dd-mm-yyyy hh24:mi:ss'), 72537, to_date('24-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51442, to_date('29-09-2020 19:23:30', 'dd-mm-yyyy hh24:mi:ss'), 72538, to_date('24-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51443, to_date('29-09-2020 19:23:38', 'dd-mm-yyyy hh24:mi:ss'), 72538, to_date('24-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51444, to_date('29-09-2020 19:23:47', 'dd-mm-yyyy hh24:mi:ss'), 72539, to_date('24-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51445, to_date('29-09-2020 19:23:52', 'dd-mm-yyyy hh24:mi:ss'), 72539, to_date('24-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51446, to_date('29-09-2020 19:24:30', 'dd-mm-yyyy hh24:mi:ss'), 72540, to_date('24-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51447, to_date('29-09-2020 19:24:37', 'dd-mm-yyyy hh24:mi:ss'), 72540, to_date('24-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51448, to_date('29-09-2020 22:29:21', 'dd-mm-yyyy hh24:mi:ss'), 72502, to_date('30-09-2020 08:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51449, to_date('29-09-2020 22:29:32', 'dd-mm-yyyy hh24:mi:ss'), 72503, to_date('30-09-2020 08:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51450, to_date('29-09-2020 22:30:09', 'dd-mm-yyyy hh24:mi:ss'), 72504, to_date('30-09-2020 08:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51487, to_date('30-09-2020 11:46:19', 'dd-mm-yyyy hh24:mi:ss'), 76393, to_date('30-09-2020 11:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51499, to_date('30-09-2020 17:55:55', 'dd-mm-yyyy hh24:mi:ss'), 76395, to_date('31-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51500, to_date('30-09-2020 17:56:04', 'dd-mm-yyyy hh24:mi:ss'), 76395, to_date('31-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('31-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51501, to_date('30-09-2020 17:56:14', 'dd-mm-yyyy hh24:mi:ss'), 76394, to_date('31-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51502, to_date('30-09-2020 17:56:53', 'dd-mm-yyyy hh24:mi:ss'), 76394, to_date('31-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('31-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51503, to_date('30-09-2020 17:57:02', 'dd-mm-yyyy hh24:mi:ss'), 76392, to_date('31-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51504, to_date('30-09-2020 17:57:08', 'dd-mm-yyyy hh24:mi:ss'), 76392, to_date('31-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('31-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51505, to_date('30-09-2020 17:58:22', 'dd-mm-yyyy hh24:mi:ss'), 72531, to_date('01-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51506, to_date('30-09-2020 17:58:30', 'dd-mm-yyyy hh24:mi:ss'), 72531, to_date('01-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51507, to_date('30-09-2020 17:59:09', 'dd-mm-yyyy hh24:mi:ss'), 72530, to_date('01-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51508, to_date('30-09-2020 17:59:16', 'dd-mm-yyyy hh24:mi:ss'), 72530, to_date('01-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51509, to_date('30-09-2020 17:59:29', 'dd-mm-yyyy hh24:mi:ss'), 72529, to_date('01-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51510, to_date('30-09-2020 17:59:36', 'dd-mm-yyyy hh24:mi:ss'), 72529, to_date('01-10-2020', 'dd-mm-yyyy'), to_date('01-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51511, to_date('30-09-2020 17:59:49', 'dd-mm-yyyy hh24:mi:ss'), 72528, to_date('30-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51512, to_date('30-09-2020 18:00:03', 'dd-mm-yyyy hh24:mi:ss'), 72527, to_date('30-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51513, to_date('30-09-2020 19:56:36', 'dd-mm-yyyy hh24:mi:ss'), 72527, to_date('30-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51514, to_date('30-09-2020 19:56:49', 'dd-mm-yyyy hh24:mi:ss'), 72528, to_date('30-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51989, to_date('07-10-2020 16:08:37', 'dd-mm-yyyy hh24:mi:ss'), 93819, to_date('07-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51990, to_date('07-10-2020 16:08:45', 'dd-mm-yyyy hh24:mi:ss'), 93819, to_date('07-10-2020 19:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51991, to_date('07-10-2020 16:08:59', 'dd-mm-yyyy hh24:mi:ss'), 93820, to_date('07-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51992, to_date('07-10-2020 16:12:47', 'dd-mm-yyyy hh24:mi:ss'), 93821, to_date('07-10-2020 19:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51993, to_date('07-10-2020 19:03:37', 'dd-mm-yyyy hh24:mi:ss'), 93830, to_date('08-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51994, to_date('07-10-2020 19:03:44', 'dd-mm-yyyy hh24:mi:ss'), 93830, to_date('08-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51995, to_date('07-10-2020 19:03:58', 'dd-mm-yyyy hh24:mi:ss'), 93829, to_date('08-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51996, to_date('07-10-2020 19:04:13', 'dd-mm-yyyy hh24:mi:ss'), 93828, to_date('08-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51997, to_date('07-10-2020 19:04:20', 'dd-mm-yyyy hh24:mi:ss'), 93828, to_date('08-10-2020', 'dd-mm-yyyy'), to_date('08-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51998, to_date('07-10-2020 19:04:39', 'dd-mm-yyyy hh24:mi:ss'), 93826, to_date('07-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51999, to_date('07-10-2020 19:05:05', 'dd-mm-yyyy hh24:mi:ss'), 93827, to_date('07-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52000, to_date('07-10-2020 19:05:33', 'dd-mm-yyyy hh24:mi:ss'), 93826, to_date('07-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52368, to_date('15-10-2020 07:05:03', 'dd-mm-yyyy hh24:mi:ss'), 121223, to_date('15-10-2020 10:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52369, to_date('15-10-2020 07:05:28', 'dd-mm-yyyy hh24:mi:ss'), 121224, to_date('15-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52370, to_date('15-10-2020 07:05:51', 'dd-mm-yyyy hh24:mi:ss'), 121225, to_date('15-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52371, to_date('15-10-2020 09:19:50', 'dd-mm-yyyy hh24:mi:ss'), 121226, to_date('15-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52372, to_date('15-10-2020 09:20:05', 'dd-mm-yyyy hh24:mi:ss'), 121227, to_date('15-10-2020 12:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52373, to_date('15-10-2020 10:14:29', 'dd-mm-yyyy hh24:mi:ss'), 121228, to_date('15-10-2020 13:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52374, to_date('15-10-2020 10:14:43', 'dd-mm-yyyy hh24:mi:ss'), 121229, to_date('15-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52375, to_date('15-10-2020 10:47:55', 'dd-mm-yyyy hh24:mi:ss'), 121230, to_date('15-10-2020 13:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52376, to_date('15-10-2020 10:48:13', 'dd-mm-yyyy hh24:mi:ss'), 121231, to_date('15-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52606, to_date('23-10-2020 14:16:27', 'dd-mm-yyyy hh24:mi:ss'), 157604, to_date('26-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52611, to_date('23-10-2020 14:17:44', 'dd-mm-yyyy hh24:mi:ss'), 157600, to_date('24-10-2020', 'dd-mm-yyyy'), to_date('23-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52612, to_date('23-10-2020 14:18:07', 'dd-mm-yyyy hh24:mi:ss'), 157599, to_date('23-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52613, to_date('23-10-2020 14:18:18', 'dd-mm-yyyy hh24:mi:ss'), 157598, to_date('23-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52614, to_date('23-10-2020 14:18:29', 'dd-mm-yyyy hh24:mi:ss'), 157597, to_date('23-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52615, to_date('23-10-2020 14:18:44', 'dd-mm-yyyy hh24:mi:ss'), 157596, to_date('23-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52616, to_date('23-10-2020 14:18:57', 'dd-mm-yyyy hh24:mi:ss'), 157595, to_date('23-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52617, to_date('23-10-2020 14:19:11', 'dd-mm-yyyy hh24:mi:ss'), 157594, to_date('23-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52618, to_date('23-10-2020 14:19:28', 'dd-mm-yyyy hh24:mi:ss'), 157593, to_date('23-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52619, to_date('23-10-2020 14:19:42', 'dd-mm-yyyy hh24:mi:ss'), 157592, to_date('23-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52620, to_date('23-10-2020 14:20:03', 'dd-mm-yyyy hh24:mi:ss'), 157591, to_date('23-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52621, to_date('23-10-2020 14:30:33', 'dd-mm-yyyy hh24:mi:ss'), 157590, to_date('23-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52622, to_date('23-10-2020 16:11:15', 'dd-mm-yyyy hh24:mi:ss'), 54055, to_date('31-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52623, to_date('23-10-2020 16:11:24', 'dd-mm-yyyy hh24:mi:ss'), 47128, to_date('31-10-2020 13:22:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 13:22:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52624, to_date('23-10-2020 18:01:42', 'dd-mm-yyyy hh24:mi:ss'), 157592, to_date('23-10-2020 21:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52625, to_date('23-10-2020 18:01:53', 'dd-mm-yyyy hh24:mi:ss'), 157593, to_date('23-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52626, to_date('23-10-2020 19:39:38', 'dd-mm-yyyy hh24:mi:ss'), 157602, to_date('24-10-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52627, to_date('23-10-2020 19:39:52', 'dd-mm-yyyy hh24:mi:ss'), 157601, to_date('24-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52628, to_date('23-10-2020 19:40:04', 'dd-mm-yyyy hh24:mi:ss'), 157600, to_date('24-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52629, to_date('23-10-2020 19:41:41', 'dd-mm-yyyy hh24:mi:ss'), 157599, to_date('24-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52630, to_date('23-10-2020 19:41:47', 'dd-mm-yyyy hh24:mi:ss'), 157599, to_date('24-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52631, to_date('23-10-2020 19:42:01', 'dd-mm-yyyy hh24:mi:ss'), 157598, to_date('24-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52632, to_date('23-10-2020 19:42:16', 'dd-mm-yyyy hh24:mi:ss'), 157597, to_date('24-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52720, to_date('28-10-2020 06:47:18', 'dd-mm-yyyy hh24:mi:ss'), 172262, to_date('28-10-2020 09:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52721, to_date('28-10-2020 06:47:30', 'dd-mm-yyyy hh24:mi:ss'), 172263, to_date('28-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52722, to_date('28-10-2020 06:48:18', 'dd-mm-yyyy hh24:mi:ss'), 172264, to_date('28-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52723, to_date('28-10-2020 06:48:25', 'dd-mm-yyyy hh24:mi:ss'), 172264, to_date('28-10-2020 10:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52724, to_date('28-10-2020 06:48:39', 'dd-mm-yyyy hh24:mi:ss'), 172265, to_date('28-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52725, to_date('28-10-2020 06:48:46', 'dd-mm-yyyy hh24:mi:ss'), 172265, to_date('28-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51488, to_date('30-09-2020 13:26:32', 'dd-mm-yyyy hh24:mi:ss'), 72531, to_date('30-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51489, to_date('30-09-2020 13:26:45', 'dd-mm-yyyy hh24:mi:ss'), 72530, to_date('30-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51490, to_date('30-09-2020 13:27:10', 'dd-mm-yyyy hh24:mi:ss'), 72529, to_date('30-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51491, to_date('30-09-2020 13:27:45', 'dd-mm-yyyy hh24:mi:ss'), 72528, to_date('30-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51492, to_date('30-09-2020 13:27:57', 'dd-mm-yyyy hh24:mi:ss'), 72527, to_date('30-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51493, to_date('30-09-2020 13:28:19', 'dd-mm-yyyy hh24:mi:ss'), 72526, to_date('30-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51494, to_date('30-09-2020 13:28:30', 'dd-mm-yyyy hh24:mi:ss'), 72525, to_date('30-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51495, to_date('30-09-2020 13:28:40', 'dd-mm-yyyy hh24:mi:ss'), 72524, to_date('30-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51496, to_date('30-09-2020 13:28:50', 'dd-mm-yyyy hh24:mi:ss'), 72523, to_date('30-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51497, to_date('30-09-2020 13:29:02', 'dd-mm-yyyy hh24:mi:ss'), 72522, to_date('30-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51498, to_date('30-09-2020 13:29:12', 'dd-mm-yyyy hh24:mi:ss'), 72521, to_date('30-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51584, to_date('02-10-2020 09:13:03', 'dd-mm-yyyy hh24:mi:ss'), 79874, to_date('02-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51585, to_date('02-10-2020 09:13:22', 'dd-mm-yyyy hh24:mi:ss'), 79873, to_date('02-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51586, to_date('02-10-2020 09:13:41', 'dd-mm-yyyy hh24:mi:ss'), 79872, to_date('02-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51587, to_date('02-10-2020 09:13:55', 'dd-mm-yyyy hh24:mi:ss'), 79871, to_date('02-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51588, to_date('02-10-2020 09:14:14', 'dd-mm-yyyy hh24:mi:ss'), 79870, to_date('02-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
commit;
prompt 400 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51589, to_date('02-10-2020 09:14:24', 'dd-mm-yyyy hh24:mi:ss'), 79869, to_date('02-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51590, to_date('02-10-2020 09:14:34', 'dd-mm-yyyy hh24:mi:ss'), 79868, to_date('02-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51591, to_date('02-10-2020 09:14:45', 'dd-mm-yyyy hh24:mi:ss'), 79867, to_date('02-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51592, to_date('02-10-2020 09:14:57', 'dd-mm-yyyy hh24:mi:ss'), 79866, to_date('02-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51593, to_date('02-10-2020 09:15:21', 'dd-mm-yyyy hh24:mi:ss'), 79865, to_date('02-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51594, to_date('02-10-2020 09:15:32', 'dd-mm-yyyy hh24:mi:ss'), 79864, to_date('02-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51595, to_date('02-10-2020 09:15:44', 'dd-mm-yyyy hh24:mi:ss'), 79863, to_date('02-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51596, to_date('02-10-2020 09:15:55', 'dd-mm-yyyy hh24:mi:ss'), 79862, to_date('02-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51597, to_date('02-10-2020 09:16:06', 'dd-mm-yyyy hh24:mi:ss'), 79861, to_date('02-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51598, to_date('02-10-2020 12:20:29', 'dd-mm-yyyy hh24:mi:ss'), 79860, to_date('02-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51599, to_date('02-10-2020 12:20:40', 'dd-mm-yyyy hh24:mi:ss'), 79859, to_date('02-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51600, to_date('02-10-2020 12:20:50', 'dd-mm-yyyy hh24:mi:ss'), 79858, to_date('02-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51601, to_date('02-10-2020 12:21:00', 'dd-mm-yyyy hh24:mi:ss'), 79857, to_date('02-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51602, to_date('02-10-2020 12:21:11', 'dd-mm-yyyy hh24:mi:ss'), 79856, to_date('02-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51116, to_date('25-09-2020 16:01:34', 'dd-mm-yyyy hh24:mi:ss'), 54036, to_date('25-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51117, to_date('25-09-2020 16:02:30', 'dd-mm-yyyy hh24:mi:ss'), 54035, to_date('25-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51485, to_date('30-09-2020 10:26:43', 'dd-mm-yyyy hh24:mi:ss'), 72510, to_date('30-09-2020 13:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51486, to_date('30-09-2020 10:26:55', 'dd-mm-yyyy hh24:mi:ss'), 72511, to_date('30-09-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52075, to_date('09-10-2020 06:04:20', 'dd-mm-yyyy hh24:mi:ss'), 89250, to_date('09-10-2020 06:06:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52076, to_date('09-10-2020 06:05:48', 'dd-mm-yyyy hh24:mi:ss'), 89252, to_date('09-10-2020 06:07:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52077, to_date('09-10-2020 06:07:03', 'dd-mm-yyyy hh24:mi:ss'), 89251, to_date('09-10-2020 06:08:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52078, to_date('09-10-2020 06:08:11', 'dd-mm-yyyy hh24:mi:ss'), 89253, to_date('30-10-2020 06:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52079, to_date('09-10-2020 08:00:35', 'dd-mm-yyyy hh24:mi:ss'), 84654, to_date('09-10-2020 08:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52080, to_date('09-10-2020 08:04:49', 'dd-mm-yyyy hh24:mi:ss'), 84648, to_date('09-10-2020 08:06:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52081, to_date('09-10-2020 08:08:24', 'dd-mm-yyyy hh24:mi:ss'), 89253, to_date('09-10-2020 08:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 06:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52082, to_date('09-10-2020 08:09:40', 'dd-mm-yyyy hh24:mi:ss'), 89250, to_date('09-10-2020 08:11:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 06:06:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52083, to_date('09-10-2020 08:10:31', 'dd-mm-yyyy hh24:mi:ss'), 89252, to_date('09-10-2020 08:13:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 06:07:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52084, to_date('09-10-2020 08:11:14', 'dd-mm-yyyy hh24:mi:ss'), 89251, to_date('09-10-2020 08:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 06:08:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52085, to_date('09-10-2020 08:12:20', 'dd-mm-yyyy hh24:mi:ss'), 89253, to_date('09-10-2020 08:16:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 08:10:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52086, to_date('09-10-2020 08:16:10', 'dd-mm-yyyy hh24:mi:ss'), 84654, to_date('09-10-2020 08:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 08:02:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52087, to_date('09-10-2020 08:17:20', 'dd-mm-yyyy hh24:mi:ss'), 84648, to_date('09-10-2020 08:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 08:06:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52121, to_date('09-10-2020 10:55:15', 'dd-mm-yyyy hh24:mi:ss'), 89231, to_date('09-10-2020 10:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52122, to_date('09-10-2020 10:56:47', 'dd-mm-yyyy hh24:mi:ss'), 84651, to_date('09-10-2020 10:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52123, to_date('09-10-2020 10:58:16', 'dd-mm-yyyy hh24:mi:ss'), 89228, to_date('09-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52124, to_date('09-10-2020 10:59:43', 'dd-mm-yyyy hh24:mi:ss'), 110822, to_date('09-10-2020 11:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52125, to_date('09-10-2020 11:26:28', 'dd-mm-yyyy hh24:mi:ss'), 84652, to_date('09-10-2020 11:28:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52126, to_date('09-10-2020 11:28:04', 'dd-mm-yyyy hh24:mi:ss'), 84653, to_date('09-10-2020 11:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52127, to_date('09-10-2020 11:29:14', 'dd-mm-yyyy hh24:mi:ss'), 84650, to_date('09-10-2020 11:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52128, to_date('09-10-2020 11:30:23', 'dd-mm-yyyy hh24:mi:ss'), 84649, to_date('30-10-2020 11:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52129, to_date('09-10-2020 11:30:28', 'dd-mm-yyyy hh24:mi:ss'), 84649, to_date('09-10-2020 11:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 11:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52130, to_date('09-10-2020 12:51:17', 'dd-mm-yyyy hh24:mi:ss'), 89238, to_date('09-10-2020 12:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52131, to_date('09-10-2020 12:52:40', 'dd-mm-yyyy hh24:mi:ss'), 89241, to_date('09-10-2020 12:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52132, to_date('09-10-2020 12:53:54', 'dd-mm-yyyy hh24:mi:ss'), 89240, to_date('09-10-2020 12:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52133, to_date('09-10-2020 12:55:02', 'dd-mm-yyyy hh24:mi:ss'), 89239, to_date('09-10-2020 12:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52134, to_date('09-10-2020 12:56:13', 'dd-mm-yyyy hh24:mi:ss'), 89244, to_date('09-10-2020 12:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52135, to_date('09-10-2020 13:14:35', 'dd-mm-yyyy hh24:mi:ss'), 89242, to_date('09-10-2020 13:16:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52136, to_date('09-10-2020 13:16:09', 'dd-mm-yyyy hh24:mi:ss'), 89243, to_date('09-10-2020 13:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52137, to_date('09-10-2020 13:18:15', 'dd-mm-yyyy hh24:mi:ss'), 89246, to_date('09-10-2020 13:19:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52138, to_date('09-10-2020 13:19:31', 'dd-mm-yyyy hh24:mi:ss'), 89245, to_date('09-10-2020 13:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52394, to_date('15-10-2020 17:12:56', 'dd-mm-yyyy hh24:mi:ss'), 121251, to_date('16-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52395, to_date('15-10-2020 17:13:02', 'dd-mm-yyyy hh24:mi:ss'), 121251, to_date('16-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52396, to_date('15-10-2020 17:13:15', 'dd-mm-yyyy hh24:mi:ss'), 121250, to_date('16-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52397, to_date('15-10-2020 17:13:24', 'dd-mm-yyyy hh24:mi:ss'), 121250, to_date('16-10-2020', 'dd-mm-yyyy'), to_date('16-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52398, to_date('15-10-2020 17:13:37', 'dd-mm-yyyy hh24:mi:ss'), 121249, to_date('15-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52399, to_date('15-10-2020 17:14:04', 'dd-mm-yyyy hh24:mi:ss'), 121248, to_date('15-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52400, to_date('15-10-2020 17:14:17', 'dd-mm-yyyy hh24:mi:ss'), 121247, to_date('15-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52401, to_date('15-10-2020 17:14:28', 'dd-mm-yyyy hh24:mi:ss'), 121246, to_date('15-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52402, to_date('15-10-2020 17:14:39', 'dd-mm-yyyy hh24:mi:ss'), 121245, to_date('15-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52403, to_date('15-10-2020 17:14:52', 'dd-mm-yyyy hh24:mi:ss'), 121244, to_date('15-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52404, to_date('15-10-2020 17:15:04', 'dd-mm-yyyy hh24:mi:ss'), 121243, to_date('15-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51938, to_date('07-10-2020 06:07:54', 'dd-mm-yyyy hh24:mi:ss'), 89258, to_date('07-10-2020 06:09:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51939, to_date('07-10-2020 06:13:09', 'dd-mm-yyyy hh24:mi:ss'), 89268, to_date('07-10-2020 06:14:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51940, to_date('07-10-2020 06:15:37', 'dd-mm-yyyy hh24:mi:ss'), 89261, to_date('07-10-2020 06:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51941, to_date('07-10-2020 06:16:59', 'dd-mm-yyyy hh24:mi:ss'), 89227, to_date('07-10-2020 06:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51947, to_date('07-10-2020 08:08:49', 'dd-mm-yyyy hh24:mi:ss'), 89229, to_date('07-10-2020 08:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51948, to_date('07-10-2020 08:10:07', 'dd-mm-yyyy hh24:mi:ss'), 89235, to_date('07-10-2020 08:11:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51949, to_date('07-10-2020 08:11:14', 'dd-mm-yyyy hh24:mi:ss'), 89237, to_date('07-10-2020 08:13:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51950, to_date('07-10-2020 08:12:34', 'dd-mm-yyyy hh24:mi:ss'), 89236, to_date('07-10-2020 08:14:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51951, to_date('07-10-2020 08:13:17', 'dd-mm-yyyy hh24:mi:ss'), 89236, to_date('07-10-2020 08:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 08:14:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51952, to_date('07-10-2020 08:19:54', 'dd-mm-yyyy hh24:mi:ss'), 79893, to_date('07-10-2020 08:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51953, to_date('07-10-2020 08:21:14', 'dd-mm-yyyy hh24:mi:ss'), 89265, to_date('07-10-2020 08:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51954, to_date('07-10-2020 08:22:20', 'dd-mm-yyyy hh24:mi:ss'), 89267, to_date('07-10-2020 08:24:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51955, to_date('07-10-2020 08:23:34', 'dd-mm-yyyy hh24:mi:ss'), 89270, to_date('07-10-2020 08:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51956, to_date('07-10-2020 08:24:58', 'dd-mm-yyyy hh24:mi:ss'), 89254, to_date('07-10-2020 08:26:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51957, to_date('07-10-2020 08:32:45', 'dd-mm-yyyy hh24:mi:ss'), 89260, to_date('07-10-2020 08:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51958, to_date('07-10-2020 08:34:14', 'dd-mm-yyyy hh24:mi:ss'), 89230, to_date('07-10-2020 08:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51959, to_date('07-10-2020 08:35:43', 'dd-mm-yyyy hh24:mi:ss'), 89234, to_date('07-10-2020 08:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51960, to_date('07-10-2020 08:37:08', 'dd-mm-yyyy hh24:mi:ss'), 89232, to_date('07-10-2020 08:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51965, to_date('07-10-2020 10:56:49', 'dd-mm-yyyy hh24:mi:ss'), 7979, to_date('07-10-2020 10:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51966, to_date('07-10-2020 10:58:15', 'dd-mm-yyyy hh24:mi:ss'), 7990, to_date('07-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51967, to_date('07-10-2020 10:59:32', 'dd-mm-yyyy hh24:mi:ss'), 7993, to_date('07-10-2020 11:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51968, to_date('07-10-2020 11:01:02', 'dd-mm-yyyy hh24:mi:ss'), 7992, to_date('07-10-2020 11:03:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51969, to_date('07-10-2020 11:02:29', 'dd-mm-yyyy hh24:mi:ss'), 5324, to_date('07-10-2020 11:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 14:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51970, to_date('07-10-2020 11:03:48', 'dd-mm-yyyy hh24:mi:ss'), 10434, to_date('07-10-2020 11:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51971, to_date('07-10-2020 11:05:04', 'dd-mm-yyyy hh24:mi:ss'), 7994, to_date('07-10-2020 11:06:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51985, to_date('07-10-2020 13:26:18', 'dd-mm-yyyy hh24:mi:ss'), 5285, to_date('07-10-2020 13:28:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:03:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51986, to_date('07-10-2020 13:27:48', 'dd-mm-yyyy hh24:mi:ss'), 7996, to_date('07-10-2020 13:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 12:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51987, to_date('07-10-2020 13:29:10', 'dd-mm-yyyy hh24:mi:ss'), 5283, to_date('07-10-2020 13:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:01:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51988, to_date('07-10-2020 13:30:24', 'dd-mm-yyyy hh24:mi:ss'), 5294, to_date('07-10-2020 13:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:12:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52457, to_date('19-10-2020 16:37:08', 'dd-mm-yyyy hh24:mi:ss'), 130469, to_date('20-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52458, to_date('19-10-2020 16:37:54', 'dd-mm-yyyy hh24:mi:ss'), 130469, to_date('20-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52459, to_date('19-10-2020 16:38:15', 'dd-mm-yyyy hh24:mi:ss'), 130468, to_date('20-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52460, to_date('19-10-2020 16:38:22', 'dd-mm-yyyy hh24:mi:ss'), 130468, to_date('20-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52461, to_date('19-10-2020 16:38:34', 'dd-mm-yyyy hh24:mi:ss'), 130467, to_date('20-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52462, to_date('19-10-2020 16:38:40', 'dd-mm-yyyy hh24:mi:ss'), 130467, to_date('20-10-2020', 'dd-mm-yyyy'), to_date('20-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52463, to_date('19-10-2020 16:38:53', 'dd-mm-yyyy hh24:mi:ss'), 130466, to_date('19-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52464, to_date('19-10-2020 16:39:03', 'dd-mm-yyyy hh24:mi:ss'), 130465, to_date('19-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52465, to_date('19-10-2020 16:39:13', 'dd-mm-yyyy hh24:mi:ss'), 130464, to_date('19-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52466, to_date('19-10-2020 16:39:23', 'dd-mm-yyyy hh24:mi:ss'), 130463, to_date('19-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52467, to_date('19-10-2020 16:39:33', 'dd-mm-yyyy hh24:mi:ss'), 130462, to_date('19-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
commit;
prompt 500 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52468, to_date('19-10-2020 16:39:56', 'dd-mm-yyyy hh24:mi:ss'), 130461, to_date('19-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52469, to_date('19-10-2020 16:40:10', 'dd-mm-yyyy hh24:mi:ss'), 130460, to_date('19-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52470, to_date('19-10-2020 17:46:35', 'dd-mm-yyyy hh24:mi:ss'), 130469, to_date('20-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52471, to_date('19-10-2020 17:47:13', 'dd-mm-yyyy hh24:mi:ss'), 130468, to_date('20-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52472, to_date('19-10-2020 17:47:25', 'dd-mm-yyyy hh24:mi:ss'), 130467, to_date('20-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52473, to_date('19-10-2020 17:47:41', 'dd-mm-yyyy hh24:mi:ss'), 130466, to_date('20-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52474, to_date('19-10-2020 17:48:03', 'dd-mm-yyyy hh24:mi:ss'), 130465, to_date('20-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52475, to_date('19-10-2020 17:48:19', 'dd-mm-yyyy hh24:mi:ss'), 130464, to_date('20-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52476, to_date('19-10-2020 17:48:32', 'dd-mm-yyyy hh24:mi:ss'), 130463, to_date('19-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52477, to_date('19-10-2020 17:49:40', 'dd-mm-yyyy hh24:mi:ss'), 130462, to_date('19-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52478, to_date('19-10-2020 17:49:51', 'dd-mm-yyyy hh24:mi:ss'), 130461, to_date('19-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52479, to_date('19-10-2020 17:50:22', 'dd-mm-yyyy hh24:mi:ss'), 130460, to_date('19-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52480, to_date('19-10-2020 17:54:22', 'dd-mm-yyyy hh24:mi:ss'), 130460, to_date('19-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52481, to_date('19-10-2020 17:54:28', 'dd-mm-yyyy hh24:mi:ss'), 130460, to_date('19-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51188, to_date('28-09-2020 08:16:46', 'dd-mm-yyyy hh24:mi:ss'), 50655, to_date('28-09-2020 08:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51189, to_date('28-09-2020 08:22:25', 'dd-mm-yyyy hh24:mi:ss'), 40688, to_date('28-09-2020 08:24:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51190, to_date('28-09-2020 08:24:51', 'dd-mm-yyyy hh24:mi:ss'), 54059, to_date('28-09-2020 08:26:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51191, to_date('28-09-2020 08:26:16', 'dd-mm-yyyy hh24:mi:ss'), 54057, to_date('28-09-2020 08:28:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51192, to_date('28-09-2020 08:28:24', 'dd-mm-yyyy hh24:mi:ss'), 54060, to_date('28-09-2020 08:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51193, to_date('28-09-2020 08:33:03', 'dd-mm-yyyy hh24:mi:ss'), 54062, to_date('28-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51194, to_date('28-09-2020 08:33:24', 'dd-mm-yyyy hh24:mi:ss'), 54062, to_date('28-09-2020 08:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51195, to_date('28-09-2020 08:37:35', 'dd-mm-yyyy hh24:mi:ss'), 54061, to_date('28-09-2020 08:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51196, to_date('28-09-2020 08:54:59', 'dd-mm-yyyy hh24:mi:ss'), 54069, to_date('28-09-2020 08:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51197, to_date('28-09-2020 09:35:35', 'dd-mm-yyyy hh24:mi:ss'), 54081, to_date('28-09-2020 09:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51198, to_date('28-09-2020 09:38:30', 'dd-mm-yyyy hh24:mi:ss'), 54079, to_date('28-09-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51199, to_date('28-09-2020 09:39:52', 'dd-mm-yyyy hh24:mi:ss'), 54067, to_date('28-09-2020 09:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51200, to_date('28-09-2020 09:41:20', 'dd-mm-yyyy hh24:mi:ss'), 54074, to_date('28-09-2020 09:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51201, to_date('28-09-2020 09:42:53', 'dd-mm-yyyy hh24:mi:ss'), 54075, to_date('28-09-2020 09:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51202, to_date('28-09-2020 09:45:11', 'dd-mm-yyyy hh24:mi:ss'), 54076, to_date('28-09-2020 09:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51203, to_date('28-09-2020 09:46:45', 'dd-mm-yyyy hh24:mi:ss'), 54078, to_date('28-09-2020 09:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51204, to_date('28-09-2020 09:56:33', 'dd-mm-yyyy hh24:mi:ss'), 54077, to_date('28-09-2020 09:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51205, to_date('28-09-2020 09:58:40', 'dd-mm-yyyy hh24:mi:ss'), 54052, to_date('28-09-2020 09:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51206, to_date('28-09-2020 10:00:22', 'dd-mm-yyyy hh24:mi:ss'), 54053, to_date('28-09-2020 10:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51207, to_date('28-09-2020 10:04:03', 'dd-mm-yyyy hh24:mi:ss'), 54056, to_date('28-09-2020 10:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51208, to_date('28-09-2020 10:06:53', 'dd-mm-yyyy hh24:mi:ss'), 54054, to_date('28-09-2020 10:08:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51209, to_date('28-09-2020 10:08:54', 'dd-mm-yyyy hh24:mi:ss'), 54064, to_date('28-09-2020 10:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51210, to_date('28-09-2020 10:10:19', 'dd-mm-yyyy hh24:mi:ss'), 54066, to_date('28-09-2020 10:12:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51211, to_date('28-09-2020 10:24:08', 'dd-mm-yyyy hh24:mi:ss'), 60170, to_date('28-09-2020 10:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51212, to_date('28-09-2020 10:26:51', 'dd-mm-yyyy hh24:mi:ss'), 60168, to_date('28-09-2020 10:28:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51213, to_date('28-09-2020 10:28:09', 'dd-mm-yyyy hh24:mi:ss'), 60169, to_date('28-09-2020 10:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:26:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51214, to_date('28-09-2020 10:29:51', 'dd-mm-yyyy hh24:mi:ss'), 60173, to_date('28-09-2020 10:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51215, to_date('28-09-2020 10:31:17', 'dd-mm-yyyy hh24:mi:ss'), 60172, to_date('28-09-2020 10:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51216, to_date('28-09-2020 10:33:03', 'dd-mm-yyyy hh24:mi:ss'), 60166, to_date('28-09-2020 10:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51217, to_date('28-09-2020 11:42:53', 'dd-mm-yyyy hh24:mi:ss'), 54065, to_date('28-09-2020 11:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51218, to_date('28-09-2020 11:44:40', 'dd-mm-yyyy hh24:mi:ss'), 54063, to_date('28-09-2020 11:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51219, to_date('28-09-2020 11:46:45', 'dd-mm-yyyy hh24:mi:ss'), 60138, to_date('28-09-2020 11:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51220, to_date('28-09-2020 11:51:55', 'dd-mm-yyyy hh24:mi:ss'), 60139, to_date('28-09-2020 11:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51221, to_date('28-09-2020 11:54:19', 'dd-mm-yyyy hh24:mi:ss'), 60137, to_date('28-09-2020 11:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51222, to_date('28-09-2020 13:42:29', 'dd-mm-yyyy hh24:mi:ss'), 60141, to_date('28-09-2020 13:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51223, to_date('28-09-2020 13:48:51', 'dd-mm-yyyy hh24:mi:ss'), 66097, to_date('28-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51224, to_date('28-09-2020 13:48:57', 'dd-mm-yyyy hh24:mi:ss'), 66097, to_date('28-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51225, to_date('28-09-2020 13:49:18', 'dd-mm-yyyy hh24:mi:ss'), 66096, to_date('28-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51226, to_date('28-09-2020 13:49:24', 'dd-mm-yyyy hh24:mi:ss'), 66096, to_date('28-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51227, to_date('28-09-2020 13:49:33', 'dd-mm-yyyy hh24:mi:ss'), 66095, to_date('28-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51228, to_date('28-09-2020 13:49:38', 'dd-mm-yyyy hh24:mi:ss'), 66095, to_date('28-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51229, to_date('28-09-2020 13:49:46', 'dd-mm-yyyy hh24:mi:ss'), 66094, to_date('28-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51230, to_date('28-09-2020 13:49:52', 'dd-mm-yyyy hh24:mi:ss'), 66094, to_date('28-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51231, to_date('28-09-2020 13:50:00', 'dd-mm-yyyy hh24:mi:ss'), 66088, to_date('28-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51232, to_date('28-09-2020 13:50:08', 'dd-mm-yyyy hh24:mi:ss'), 66093, to_date('28-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51233, to_date('28-09-2020 13:50:14', 'dd-mm-yyyy hh24:mi:ss'), 66093, to_date('28-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51234, to_date('28-09-2020 13:50:24', 'dd-mm-yyyy hh24:mi:ss'), 66092, to_date('28-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51235, to_date('28-09-2020 13:50:29', 'dd-mm-yyyy hh24:mi:ss'), 66092, to_date('28-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51236, to_date('28-09-2020 13:50:38', 'dd-mm-yyyy hh24:mi:ss'), 66091, to_date('28-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51237, to_date('28-09-2020 13:50:43', 'dd-mm-yyyy hh24:mi:ss'), 66091, to_date('28-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51238, to_date('28-09-2020 13:50:51', 'dd-mm-yyyy hh24:mi:ss'), 66090, to_date('28-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51239, to_date('28-09-2020 13:50:56', 'dd-mm-yyyy hh24:mi:ss'), 66090, to_date('28-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51240, to_date('28-09-2020 13:51:07', 'dd-mm-yyyy hh24:mi:ss'), 66089, to_date('28-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51241, to_date('28-09-2020 13:51:13', 'dd-mm-yyyy hh24:mi:ss'), 66089, to_date('28-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51242, to_date('28-09-2020 13:51:22', 'dd-mm-yyyy hh24:mi:ss'), 66109, to_date('28-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51243, to_date('28-09-2020 13:51:27', 'dd-mm-yyyy hh24:mi:ss'), 66109, to_date('28-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51452, to_date('30-09-2020 06:54:20', 'dd-mm-yyyy hh24:mi:ss'), 60147, to_date('30-09-2020 06:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51453, to_date('30-09-2020 06:55:16', 'dd-mm-yyyy hh24:mi:ss'), 72536, to_date('30-09-2020 06:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51454, to_date('30-09-2020 06:56:06', 'dd-mm-yyyy hh24:mi:ss'), 72537, to_date('30-09-2020 06:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51455, to_date('30-09-2020 06:59:41', 'dd-mm-yyyy hh24:mi:ss'), 66091, to_date('30-09-2020 07:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51826, to_date('05-10-2020 14:53:55', 'dd-mm-yyyy hh24:mi:ss'), 89227, to_date('24-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51827, to_date('05-10-2020 14:54:04', 'dd-mm-yyyy hh24:mi:ss'), 89227, to_date('24-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51828, to_date('05-10-2020 14:54:12', 'dd-mm-yyyy hh24:mi:ss'), 89228, to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51829, to_date('05-10-2020 14:54:24', 'dd-mm-yyyy hh24:mi:ss'), 89228, to_date('24-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51830, to_date('05-10-2020 14:54:36', 'dd-mm-yyyy hh24:mi:ss'), 89229, to_date('24-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51831, to_date('05-10-2020 14:54:42', 'dd-mm-yyyy hh24:mi:ss'), 89229, to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51832, to_date('05-10-2020 14:55:06', 'dd-mm-yyyy hh24:mi:ss'), 89230, to_date('05-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51833, to_date('05-10-2020 14:55:18', 'dd-mm-yyyy hh24:mi:ss'), 89231, to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51834, to_date('05-10-2020 14:55:24', 'dd-mm-yyyy hh24:mi:ss'), 89231, to_date('24-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51835, to_date('05-10-2020 14:55:32', 'dd-mm-yyyy hh24:mi:ss'), 89232, to_date('24-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51836, to_date('05-10-2020 14:55:38', 'dd-mm-yyyy hh24:mi:ss'), 89232, to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51837, to_date('05-10-2020 14:56:45', 'dd-mm-yyyy hh24:mi:ss'), 89230, to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51838, to_date('05-10-2020 14:56:51', 'dd-mm-yyyy hh24:mi:ss'), 89230, to_date('24-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51839, to_date('05-10-2020 14:59:14', 'dd-mm-yyyy hh24:mi:ss'), 84633, to_date('06-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51840, to_date('05-10-2020 15:27:59', 'dd-mm-yyyy hh24:mi:ss'), 84632, to_date('06-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51841, to_date('05-10-2020 15:28:21', 'dd-mm-yyyy hh24:mi:ss'), 84631, to_date('06-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51842, to_date('05-10-2020 15:28:29', 'dd-mm-yyyy hh24:mi:ss'), 84631, to_date('06-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51843, to_date('05-10-2020 15:29:00', 'dd-mm-yyyy hh24:mi:ss'), 84630, to_date('06-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51844, to_date('05-10-2020 15:29:17', 'dd-mm-yyyy hh24:mi:ss'), 84629, to_date('06-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51845, to_date('05-10-2020 15:29:42', 'dd-mm-yyyy hh24:mi:ss'), 84628, to_date('06-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51846, to_date('05-10-2020 15:29:52', 'dd-mm-yyyy hh24:mi:ss'), 84628, to_date('06-10-2020', 'dd-mm-yyyy'), to_date('06-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51847, to_date('05-10-2020 15:30:11', 'dd-mm-yyyy hh24:mi:ss'), 84627, to_date('05-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51848, to_date('05-10-2020 15:30:25', 'dd-mm-yyyy hh24:mi:ss'), 84626, to_date('05-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51849, to_date('05-10-2020 15:31:41', 'dd-mm-yyyy hh24:mi:ss'), 84625, to_date('05-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51850, to_date('05-10-2020 15:31:56', 'dd-mm-yyyy hh24:mi:ss'), 84624, to_date('05-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51851, to_date('05-10-2020 15:32:37', 'dd-mm-yyyy hh24:mi:ss'), 84623, to_date('05-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
commit;
prompt 600 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51852, to_date('05-10-2020 15:32:51', 'dd-mm-yyyy hh24:mi:ss'), 84622, to_date('05-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51853, to_date('05-10-2020 20:05:57', 'dd-mm-yyyy hh24:mi:ss'), 84627, to_date('05-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51854, to_date('05-10-2020 20:06:15', 'dd-mm-yyyy hh24:mi:ss'), 84628, to_date('05-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51855, to_date('05-10-2020 20:47:12', 'dd-mm-yyyy hh24:mi:ss'), 84632, to_date('06-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51856, to_date('05-10-2020 20:47:20', 'dd-mm-yyyy hh24:mi:ss'), 84632, to_date('06-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51857, to_date('05-10-2020 20:49:25', 'dd-mm-yyyy hh24:mi:ss'), 84631, to_date('06-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52004, to_date('08-10-2020 06:13:20', 'dd-mm-yyyy hh24:mi:ss'), 89247, to_date('08-10-2020 06:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52006, to_date('08-10-2020 06:15:18', 'dd-mm-yyyy hh24:mi:ss'), 89248, to_date('08-10-2020 06:16:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52007, to_date('08-10-2020 06:16:12', 'dd-mm-yyyy hh24:mi:ss'), 89249, to_date('08-10-2020 06:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52008, to_date('08-10-2020 06:25:37', 'dd-mm-yyyy hh24:mi:ss'), 89247, to_date('08-10-2020 06:27:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 06:15:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52012, to_date('08-10-2020 06:31:08', 'dd-mm-yyyy hh24:mi:ss'), 89247, to_date('08-10-2020 06:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 06:27:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52013, to_date('08-10-2020 06:35:57', 'dd-mm-yyyy hh24:mi:ss'), 103451, to_date('08-10-2020 11:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 08:51:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52015, to_date('08-10-2020 07:49:51', 'dd-mm-yyyy hh24:mi:ss'), 89247, to_date('08-10-2020 07:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 06:32:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52020, to_date('08-10-2020 07:58:59', 'dd-mm-yyyy hh24:mi:ss'), 89248, to_date('08-10-2020 08:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 06:16:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52021, to_date('08-10-2020 07:59:20', 'dd-mm-yyyy hh24:mi:ss'), 89247, to_date('08-10-2020 08:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 07:50:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52022, to_date('08-10-2020 07:59:46', 'dd-mm-yyyy hh24:mi:ss'), 89249, to_date('08-10-2020 08:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 06:17:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52431, to_date('16-10-2020 19:27:15', 'dd-mm-yyyy hh24:mi:ss'), 124630, to_date('17-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('17-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52432, to_date('16-10-2020 19:27:27', 'dd-mm-yyyy hh24:mi:ss'), 124629, to_date('17-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('17-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52433, to_date('16-10-2020 19:28:00', 'dd-mm-yyyy hh24:mi:ss'), 124628, to_date('17-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52434, to_date('16-10-2020 19:28:21', 'dd-mm-yyyy hh24:mi:ss'), 124627, to_date('17-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52435, to_date('16-10-2020 19:28:41', 'dd-mm-yyyy hh24:mi:ss'), 124626, to_date('17-10-2020', 'dd-mm-yyyy'), to_date('16-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51459, to_date('30-09-2020 07:01:43', 'dd-mm-yyyy hh24:mi:ss'), 66093, to_date('30-09-2020 07:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51460, to_date('30-09-2020 07:07:44', 'dd-mm-yyyy hh24:mi:ss'), 66092, to_date('30-09-2020 07:09:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51461, to_date('30-09-2020 07:08:43', 'dd-mm-yyyy hh24:mi:ss'), 72497, to_date('30-09-2020 07:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51462, to_date('30-09-2020 07:10:28', 'dd-mm-yyyy hh24:mi:ss'), 66096, to_date('30-09-2020 07:11:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51463, to_date('30-09-2020 07:13:02', 'dd-mm-yyyy hh24:mi:ss'), 66095, to_date('30-09-2020 07:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51464, to_date('30-09-2020 07:24:01', 'dd-mm-yyyy hh24:mi:ss'), 60146, to_date('30-09-2020 07:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51465, to_date('30-09-2020 07:25:45', 'dd-mm-yyyy hh24:mi:ss'), 60145, to_date('30-09-2020 07:27:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51466, to_date('30-09-2020 07:26:37', 'dd-mm-yyyy hh24:mi:ss'), 60144, to_date('30-09-2020 07:28:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51467, to_date('30-09-2020 07:28:11', 'dd-mm-yyyy hh24:mi:ss'), 66109, to_date('30-09-2020 07:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51468, to_date('30-09-2020 07:29:40', 'dd-mm-yyyy hh24:mi:ss'), 66090, to_date('30-09-2020 07:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51469, to_date('30-09-2020 07:31:13', 'dd-mm-yyyy hh24:mi:ss'), 66089, to_date('30-09-2020 07:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51474, to_date('30-09-2020 08:33:35', 'dd-mm-yyyy hh24:mi:ss'), 66094, to_date('30-09-2020 08:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51475, to_date('30-09-2020 08:34:38', 'dd-mm-yyyy hh24:mi:ss'), 72496, to_date('30-09-2020 08:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51476, to_date('30-09-2020 08:35:32', 'dd-mm-yyyy hh24:mi:ss'), 72495, to_date('30-09-2020 08:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51477, to_date('30-09-2020 08:36:51', 'dd-mm-yyyy hh24:mi:ss'), 72498, to_date('30-09-2020 08:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51478, to_date('30-09-2020 08:41:03', 'dd-mm-yyyy hh24:mi:ss'), 66097, to_date('30-09-2020 08:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51479, to_date('30-09-2020 08:41:51', 'dd-mm-yyyy hh24:mi:ss'), 72539, to_date('30-09-2020 08:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51480, to_date('30-09-2020 08:42:35', 'dd-mm-yyyy hh24:mi:ss'), 72540, to_date('30-09-2020 08:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51481, to_date('30-09-2020 08:43:22', 'dd-mm-yyyy hh24:mi:ss'), 72538, to_date('30-09-2020 08:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51825, to_date('05-10-2020 14:52:46', 'dd-mm-yyyy hh24:mi:ss'), 84615, to_date('05-10-2020 15:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52699, to_date('27-10-2020 11:46:04', 'dd-mm-yyyy hh24:mi:ss'), 47128, to_date('27-10-2020 11:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 13:22:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52700, to_date('27-10-2020 11:56:40', 'dd-mm-yyyy hh24:mi:ss'), 54055, to_date('27-10-2020 11:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50912, to_date('25-09-2020 06:05:48', 'dd-mm-yyyy hh24:mi:ss'), 60141, to_date('25-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50913, to_date('25-09-2020 06:05:58', 'dd-mm-yyyy hh24:mi:ss'), 60141, to_date('24-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50914, to_date('25-09-2020 06:06:07', 'dd-mm-yyyy hh24:mi:ss'), 60140, to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50915, to_date('25-09-2020 06:06:22', 'dd-mm-yyyy hh24:mi:ss'), 60140, to_date('24-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50916, to_date('25-09-2020 06:06:31', 'dd-mm-yyyy hh24:mi:ss'), 60139, to_date('24-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50917, to_date('25-09-2020 06:06:36', 'dd-mm-yyyy hh24:mi:ss'), 60139, to_date('24-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50918, to_date('25-09-2020 06:06:46', 'dd-mm-yyyy hh24:mi:ss'), 60138, to_date('24-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50919, to_date('25-09-2020 06:06:51', 'dd-mm-yyyy hh24:mi:ss'), 60138, to_date('24-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50920, to_date('25-09-2020 06:07:02', 'dd-mm-yyyy hh24:mi:ss'), 60137, to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50921, to_date('25-09-2020 06:07:08', 'dd-mm-yyyy hh24:mi:ss'), 60137, to_date('24-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50922, to_date('25-09-2020 06:07:17', 'dd-mm-yyyy hh24:mi:ss'), 60136, to_date('24-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50923, to_date('25-09-2020 06:07:23', 'dd-mm-yyyy hh24:mi:ss'), 60136, to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50924, to_date('25-09-2020 06:07:31', 'dd-mm-yyyy hh24:mi:ss'), 40688, to_date('24-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50925, to_date('25-09-2020 06:07:36', 'dd-mm-yyyy hh24:mi:ss'), 40688, to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50926, to_date('25-09-2020 06:07:46', 'dd-mm-yyyy hh24:mi:ss'), 39157, to_date('24-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50927, to_date('25-09-2020 06:07:52', 'dd-mm-yyyy hh24:mi:ss'), 39157, to_date('24-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50928, to_date('25-09-2020 06:08:01', 'dd-mm-yyyy hh24:mi:ss'), 47128, to_date('24-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-09-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50929, to_date('25-09-2020 06:08:07', 'dd-mm-yyyy hh24:mi:ss'), 47128, to_date('24-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50930, to_date('25-09-2020 06:13:49', 'dd-mm-yyyy hh24:mi:ss'), 50667, to_date('25-09-2020 06:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50931, to_date('25-09-2020 06:15:17', 'dd-mm-yyyy hh24:mi:ss'), 50668, to_date('25-09-2020 06:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50932, to_date('25-09-2020 06:56:24', 'dd-mm-yyyy hh24:mi:ss'), 50670, to_date('25-09-2020 06:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50933, to_date('25-09-2020 06:58:06', 'dd-mm-yyyy hh24:mi:ss'), 50669, to_date('25-09-2020 06:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50934, to_date('25-09-2020 06:59:54', 'dd-mm-yyyy hh24:mi:ss'), 54070, to_date('25-09-2020 07:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50936, to_date('25-09-2020 07:03:29', 'dd-mm-yyyy hh24:mi:ss'), 54080, to_date('25-09-2020 07:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50938, to_date('25-09-2020 08:13:22', 'dd-mm-yyyy hh24:mi:ss'), 60156, to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020', 'dd-mm-yyyy'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50939, to_date('25-09-2020 08:13:39', 'dd-mm-yyyy hh24:mi:ss'), 60156, to_date('25-09-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50940, to_date('25-09-2020 08:13:50', 'dd-mm-yyyy hh24:mi:ss'), 60157, to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020', 'dd-mm-yyyy'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50941, to_date('25-09-2020 08:13:56', 'dd-mm-yyyy hh24:mi:ss'), 60157, to_date('25-09-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50942, to_date('25-09-2020 08:16:42', 'dd-mm-yyyy hh24:mi:ss'), 54048, to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50943, to_date('25-09-2020 08:16:52', 'dd-mm-yyyy hh24:mi:ss'), 54047, to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50944, to_date('25-09-2020 08:17:02', 'dd-mm-yyyy hh24:mi:ss'), 54046, to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50945, to_date('25-09-2020 08:17:12', 'dd-mm-yyyy hh24:mi:ss'), 54045, to_date('25-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50946, to_date('25-09-2020 08:17:26', 'dd-mm-yyyy hh24:mi:ss'), 54044, to_date('25-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50947, to_date('25-09-2020 08:17:37', 'dd-mm-yyyy hh24:mi:ss'), 54043, to_date('25-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50948, to_date('25-09-2020 08:17:49', 'dd-mm-yyyy hh24:mi:ss'), 54042, to_date('25-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50949, to_date('25-09-2020 08:17:59', 'dd-mm-yyyy hh24:mi:ss'), 54041, to_date('25-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50950, to_date('25-09-2020 08:18:21', 'dd-mm-yyyy hh24:mi:ss'), 54040, to_date('25-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50951, to_date('25-09-2020 08:18:34', 'dd-mm-yyyy hh24:mi:ss'), 54039, to_date('25-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50952, to_date('25-09-2020 08:18:46', 'dd-mm-yyyy hh24:mi:ss'), 54038, to_date('25-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50953, to_date('25-09-2020 08:18:57', 'dd-mm-yyyy hh24:mi:ss'), 54037, to_date('25-09-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50954, to_date('25-09-2020 08:19:12', 'dd-mm-yyyy hh24:mi:ss'), 54036, to_date('25-09-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50955, to_date('25-09-2020 08:19:25', 'dd-mm-yyyy hh24:mi:ss'), 54035, to_date('25-09-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50956, to_date('25-09-2020 08:19:39', 'dd-mm-yyyy hh24:mi:ss'), 54034, to_date('25-09-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50957, to_date('25-09-2020 08:19:49', 'dd-mm-yyyy hh24:mi:ss'), 54033, to_date('25-09-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50958, to_date('25-09-2020 08:20:00', 'dd-mm-yyyy hh24:mi:ss'), 54032, to_date('25-09-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50959, to_date('25-09-2020 08:20:11', 'dd-mm-yyyy hh24:mi:ss'), 54031, to_date('25-09-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50960, to_date('25-09-2020 08:20:23', 'dd-mm-yyyy hh24:mi:ss'), 54030, to_date('25-09-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50961, to_date('25-09-2020 08:20:33', 'dd-mm-yyyy hh24:mi:ss'), 54029, to_date('25-09-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50962, to_date('25-09-2020 08:20:46', 'dd-mm-yyyy hh24:mi:ss'), 54028, to_date('25-09-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50963, to_date('25-09-2020 08:20:57', 'dd-mm-yyyy hh24:mi:ss'), 54027, to_date('25-09-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50964, to_date('25-09-2020 08:21:12', 'dd-mm-yyyy hh24:mi:ss'), 54026, to_date('25-09-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50965, to_date('25-09-2020 08:21:21', 'dd-mm-yyyy hh24:mi:ss'), 54025, to_date('25-09-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50966, to_date('25-09-2020 08:21:32', 'dd-mm-yyyy hh24:mi:ss'), 54024, to_date('25-09-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50967, to_date('25-09-2020 08:21:43', 'dd-mm-yyyy hh24:mi:ss'), 54023, to_date('25-09-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50968, to_date('25-09-2020 08:21:56', 'dd-mm-yyyy hh24:mi:ss'), 54022, to_date('25-09-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50969, to_date('25-09-2020 08:22:08', 'dd-mm-yyyy hh24:mi:ss'), 54021, to_date('25-09-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50970, to_date('25-09-2020 08:22:30', 'dd-mm-yyyy hh24:mi:ss'), 54020, to_date('25-09-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
commit;
prompt 700 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50971, to_date('25-09-2020 08:22:43', 'dd-mm-yyyy hh24:mi:ss'), 54019, to_date('25-09-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50972, to_date('25-09-2020 08:27:28', 'dd-mm-yyyy hh24:mi:ss'), 54066, to_date('25-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50973, to_date('25-09-2020 08:27:34', 'dd-mm-yyyy hh24:mi:ss'), 54066, to_date('25-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50974, to_date('25-09-2020 08:27:43', 'dd-mm-yyyy hh24:mi:ss'), 54065, to_date('25-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50975, to_date('25-09-2020 08:27:48', 'dd-mm-yyyy hh24:mi:ss'), 54065, to_date('25-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50976, to_date('25-09-2020 08:27:58', 'dd-mm-yyyy hh24:mi:ss'), 50655, to_date('25-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50977, to_date('25-09-2020 08:28:05', 'dd-mm-yyyy hh24:mi:ss'), 50655, to_date('25-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50978, to_date('25-09-2020 08:28:14', 'dd-mm-yyyy hh24:mi:ss'), 54064, to_date('25-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51118, to_date('25-09-2020 16:10:21', 'dd-mm-yyyy hh24:mi:ss'), 54048, to_date('26-09-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51119, to_date('25-09-2020 16:10:36', 'dd-mm-yyyy hh24:mi:ss'), 54047, to_date('26-09-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51120, to_date('25-09-2020 16:10:49', 'dd-mm-yyyy hh24:mi:ss'), 54046, to_date('26-09-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51121, to_date('25-09-2020 16:11:04', 'dd-mm-yyyy hh24:mi:ss'), 54045, to_date('26-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51122, to_date('25-09-2020 16:11:17', 'dd-mm-yyyy hh24:mi:ss'), 54044, to_date('26-09-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51123, to_date('25-09-2020 16:11:35', 'dd-mm-yyyy hh24:mi:ss'), 54043, to_date('26-09-2020', 'dd-mm-yyyy'), to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51124, to_date('25-09-2020 16:11:53', 'dd-mm-yyyy hh24:mi:ss'), 54042, to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51125, to_date('25-09-2020 16:12:03', 'dd-mm-yyyy hh24:mi:ss'), 54041, to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51126, to_date('25-09-2020 16:12:16', 'dd-mm-yyyy hh24:mi:ss'), 54040, to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51127, to_date('25-09-2020 16:12:31', 'dd-mm-yyyy hh24:mi:ss'), 54039, to_date('25-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51128, to_date('25-09-2020 16:13:25', 'dd-mm-yyyy hh24:mi:ss'), 54038, to_date('25-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51129, to_date('25-09-2020 16:13:38', 'dd-mm-yyyy hh24:mi:ss'), 54037, to_date('25-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51130, to_date('25-09-2020 16:13:56', 'dd-mm-yyyy hh24:mi:ss'), 54036, to_date('25-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51131, to_date('25-09-2020 16:14:15', 'dd-mm-yyyy hh24:mi:ss'), 54035, to_date('25-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51132, to_date('25-09-2020 18:03:32', 'dd-mm-yyyy hh24:mi:ss'), 54048, to_date('26-09-2020 02:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51133, to_date('25-09-2020 18:05:11', 'dd-mm-yyyy hh24:mi:ss'), 54047, to_date('26-09-2020 02:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51134, to_date('25-09-2020 18:05:22', 'dd-mm-yyyy hh24:mi:ss'), 54046, to_date('26-09-2020 02:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51135, to_date('25-09-2020 18:05:35', 'dd-mm-yyyy hh24:mi:ss'), 54045, to_date('26-09-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51136, to_date('25-09-2020 18:06:06', 'dd-mm-yyyy hh24:mi:ss'), 54044, to_date('26-09-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51137, to_date('25-09-2020 18:06:18', 'dd-mm-yyyy hh24:mi:ss'), 54043, to_date('26-09-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51138, to_date('25-09-2020 18:07:47', 'dd-mm-yyyy hh24:mi:ss'), 54042, to_date('26-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51139, to_date('25-09-2020 18:07:58', 'dd-mm-yyyy hh24:mi:ss'), 54041, to_date('26-09-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51140, to_date('25-09-2020 18:08:13', 'dd-mm-yyyy hh24:mi:ss'), 54040, to_date('26-09-2020', 'dd-mm-yyyy'), to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51141, to_date('25-09-2020 18:08:29', 'dd-mm-yyyy hh24:mi:ss'), 54039, to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51142, to_date('25-09-2020 18:08:40', 'dd-mm-yyyy hh24:mi:ss'), 54038, to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51143, to_date('25-09-2020 18:08:53', 'dd-mm-yyyy hh24:mi:ss'), 54037, to_date('25-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51144, to_date('25-09-2020 18:09:10', 'dd-mm-yyyy hh24:mi:ss'), 54036, to_date('25-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51145, to_date('25-09-2020 20:07:04', 'dd-mm-yyyy hh24:mi:ss'), 54038, to_date('25-09-2020 23:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51146, to_date('25-09-2020 20:07:19', 'dd-mm-yyyy hh24:mi:ss'), 54039, to_date('25-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51147, to_date('25-09-2020 20:07:36', 'dd-mm-yyyy hh24:mi:ss'), 54040, to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51148, to_date('25-09-2020 21:10:55', 'dd-mm-yyyy hh24:mi:ss'), 54048, to_date('28-09-2020 11:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 02:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51149, to_date('25-09-2020 21:11:10', 'dd-mm-yyyy hh24:mi:ss'), 54047, to_date('28-09-2020 02:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 02:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51150, to_date('25-09-2020 21:11:18', 'dd-mm-yyyy hh24:mi:ss'), 54047, to_date('28-09-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 02:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51151, to_date('25-09-2020 21:11:34', 'dd-mm-yyyy hh24:mi:ss'), 54046, to_date('28-09-2020 02:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 02:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51152, to_date('25-09-2020 21:11:41', 'dd-mm-yyyy hh24:mi:ss'), 54046, to_date('28-09-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 02:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51153, to_date('25-09-2020 21:29:41', 'dd-mm-yyyy hh24:mi:ss'), 54045, to_date('26-09-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51154, to_date('25-09-2020 21:30:35', 'dd-mm-yyyy hh24:mi:ss'), 54044, to_date('26-09-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-09-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51417, to_date('29-09-2020 14:05:03', 'dd-mm-yyyy hh24:mi:ss'), 72500, to_date('29-10-2020 14:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 14:01:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51418, to_date('29-09-2020 14:05:54', 'dd-mm-yyyy hh24:mi:ss'), 72501, to_date('29-10-2020 14:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 14:02:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51419, to_date('29-09-2020 14:06:13', 'dd-mm-yyyy hh24:mi:ss'), 72501, to_date('29-10-2020 14:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 14:02:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51420, to_date('29-09-2020 14:06:40', 'dd-mm-yyyy hh24:mi:ss'), 72532, to_date('29-10-2020 14:03:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 14:03:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51421, to_date('29-09-2020 14:06:49', 'dd-mm-yyyy hh24:mi:ss'), 72532, to_date('29-10-2020 14:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 14:03:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51422, to_date('29-09-2020 14:07:43', 'dd-mm-yyyy hh24:mi:ss'), 72533, to_date('29-10-2020 14:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 14:04:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51423, to_date('29-09-2020 14:23:39', 'dd-mm-yyyy hh24:mi:ss'), 66081, to_date('29-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51424, to_date('29-09-2020 14:23:52', 'dd-mm-yyyy hh24:mi:ss'), 66080, to_date('29-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51425, to_date('29-09-2020 14:24:34', 'dd-mm-yyyy hh24:mi:ss'), 66079, to_date('29-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51426, to_date('29-09-2020 14:24:45', 'dd-mm-yyyy hh24:mi:ss'), 66078, to_date('29-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51427, to_date('29-09-2020 14:24:58', 'dd-mm-yyyy hh24:mi:ss'), 66077, to_date('29-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51428, to_date('29-09-2020 14:25:12', 'dd-mm-yyyy hh24:mi:ss'), 66076, to_date('29-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51429, to_date('29-09-2020 14:25:24', 'dd-mm-yyyy hh24:mi:ss'), 66075, to_date('29-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51430, to_date('29-09-2020 14:25:35', 'dd-mm-yyyy hh24:mi:ss'), 66074, to_date('29-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51431, to_date('29-09-2020 14:25:47', 'dd-mm-yyyy hh24:mi:ss'), 66073, to_date('29-09-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51886, to_date('06-10-2020 06:18:24', 'dd-mm-yyyy hh24:mi:ss'), 79891, to_date('06-10-2020 06:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51887, to_date('06-10-2020 06:46:25', 'dd-mm-yyyy hh24:mi:ss'), 79894, to_date('06-10-2020 06:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51888, to_date('06-10-2020 08:40:56', 'dd-mm-yyyy hh24:mi:ss'), 79892, to_date('06-10-2020 08:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51908, to_date('06-10-2020 09:31:25', 'dd-mm-yyyy hh24:mi:ss'), 89263, to_date('06-10-2020 09:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:18:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51911, to_date('06-10-2020 09:32:45', 'dd-mm-yyyy hh24:mi:ss'), 89264, to_date('06-10-2020 09:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:19:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51912, to_date('06-10-2020 10:17:03', 'dd-mm-yyyy hh24:mi:ss'), 54058, to_date('06-10-2020 10:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51913, to_date('06-10-2020 10:18:38', 'dd-mm-yyyy hh24:mi:ss'), 89262, to_date('06-10-2020 10:19:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:17:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51914, to_date('06-10-2020 10:19:58', 'dd-mm-yyyy hh24:mi:ss'), 89266, to_date('06-10-2020 10:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:21:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51915, to_date('06-10-2020 10:21:45', 'dd-mm-yyyy hh24:mi:ss'), 89257, to_date('06-10-2020 10:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51916, to_date('06-10-2020 11:10:17', 'dd-mm-yyyy hh24:mi:ss'), 89269, to_date('06-10-2020 11:12:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51917, to_date('06-10-2020 11:11:48', 'dd-mm-yyyy hh24:mi:ss'), 89255, to_date('06-10-2020 11:13:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51922, to_date('06-10-2020 11:13:50', 'dd-mm-yyyy hh24:mi:ss'), 89259, to_date('06-10-2020 11:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51923, to_date('06-10-2020 11:15:51', 'dd-mm-yyyy hh24:mi:ss'), 89256, to_date('06-10-2020 11:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51924, to_date('06-10-2020 13:13:37', 'dd-mm-yyyy hh24:mi:ss'), 89203, to_date('06-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52032, to_date('08-10-2020 11:09:16', 'dd-mm-yyyy hh24:mi:ss'), 96725, to_date('08-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52033, to_date('08-10-2020 11:09:26', 'dd-mm-yyyy hh24:mi:ss'), 96724, to_date('08-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52034, to_date('08-10-2020 11:09:35', 'dd-mm-yyyy hh24:mi:ss'), 96723, to_date('08-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52035, to_date('08-10-2020 11:09:44', 'dd-mm-yyyy hh24:mi:ss'), 96722, to_date('08-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52036, to_date('08-10-2020 11:09:57', 'dd-mm-yyyy hh24:mi:ss'), 96721, to_date('08-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52037, to_date('08-10-2020 11:10:06', 'dd-mm-yyyy hh24:mi:ss'), 96720, to_date('08-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52038, to_date('08-10-2020 11:10:17', 'dd-mm-yyyy hh24:mi:ss'), 96719, to_date('08-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52039, to_date('08-10-2020 11:10:29', 'dd-mm-yyyy hh24:mi:ss'), 96718, to_date('08-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52040, to_date('08-10-2020 11:10:42', 'dd-mm-yyyy hh24:mi:ss'), 96717, to_date('08-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52041, to_date('08-10-2020 11:10:53', 'dd-mm-yyyy hh24:mi:ss'), 96716, to_date('08-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52042, to_date('08-10-2020 11:11:04', 'dd-mm-yyyy hh24:mi:ss'), 96715, to_date('08-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52043, to_date('08-10-2020 11:11:14', 'dd-mm-yyyy hh24:mi:ss'), 96714, to_date('08-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52512, to_date('21-10-2020 06:22:19', 'dd-mm-yyyy hh24:mi:ss'), 140377, to_date('21-10-2020 09:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 12320);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52633, to_date('23-10-2020 19:58:36', 'dd-mm-yyyy hh24:mi:ss'), 157597, to_date('24-10-2020', 'dd-mm-yyyy'), to_date('24-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50979, to_date('25-09-2020 08:28:28', 'dd-mm-yyyy hh24:mi:ss'), 54064, to_date('25-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50980, to_date('25-09-2020 08:28:40', 'dd-mm-yyyy hh24:mi:ss'), 54063, to_date('25-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50981, to_date('25-09-2020 08:28:46', 'dd-mm-yyyy hh24:mi:ss'), 54063, to_date('25-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50982, to_date('25-09-2020 08:28:57', 'dd-mm-yyyy hh24:mi:ss'), 54062, to_date('25-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50983, to_date('25-09-2020 08:29:02', 'dd-mm-yyyy hh24:mi:ss'), 54062, to_date('25-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50984, to_date('25-09-2020 08:29:12', 'dd-mm-yyyy hh24:mi:ss'), 60147, to_date('25-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50985, to_date('25-09-2020 08:29:17', 'dd-mm-yyyy hh24:mi:ss'), 60147, to_date('25-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50986, to_date('25-09-2020 08:29:28', 'dd-mm-yyyy hh24:mi:ss'), 54061, to_date('25-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50987, to_date('25-09-2020 08:29:34', 'dd-mm-yyyy hh24:mi:ss'), 54061, to_date('25-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50988, to_date('25-09-2020 08:29:45', 'dd-mm-yyyy hh24:mi:ss'), 60146, to_date('25-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50989, to_date('25-09-2020 08:29:51', 'dd-mm-yyyy hh24:mi:ss'), 60146, to_date('25-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50990, to_date('25-09-2020 08:30:02', 'dd-mm-yyyy hh24:mi:ss'), 54060, to_date('25-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
commit;
prompt 800 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50991, to_date('25-09-2020 08:30:08', 'dd-mm-yyyy hh24:mi:ss'), 54060, to_date('25-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50992, to_date('25-09-2020 08:30:20', 'dd-mm-yyyy hh24:mi:ss'), 60145, to_date('25-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50993, to_date('25-09-2020 08:30:25', 'dd-mm-yyyy hh24:mi:ss'), 60145, to_date('25-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50994, to_date('25-09-2020 08:30:34', 'dd-mm-yyyy hh24:mi:ss'), 54059, to_date('25-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50995, to_date('25-09-2020 08:30:40', 'dd-mm-yyyy hh24:mi:ss'), 54059, to_date('25-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50996, to_date('25-09-2020 08:30:54', 'dd-mm-yyyy hh24:mi:ss'), 60144, to_date('25-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50997, to_date('25-09-2020 08:30:59', 'dd-mm-yyyy hh24:mi:ss'), 60144, to_date('25-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50998, to_date('25-09-2020 08:31:09', 'dd-mm-yyyy hh24:mi:ss'), 60143, to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (50999, to_date('25-09-2020 08:31:14', 'dd-mm-yyyy hh24:mi:ss'), 60143, to_date('25-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51000, to_date('25-09-2020 08:31:22', 'dd-mm-yyyy hh24:mi:ss'), 54058, to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51001, to_date('25-09-2020 08:31:32', 'dd-mm-yyyy hh24:mi:ss'), 54058, to_date('25-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51002, to_date('25-09-2020 08:31:58', 'dd-mm-yyyy hh24:mi:ss'), 54057, to_date('25-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51003, to_date('25-09-2020 08:32:06', 'dd-mm-yyyy hh24:mi:ss'), 54057, to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51004, to_date('25-09-2020 08:32:22', 'dd-mm-yyyy hh24:mi:ss'), 60142, to_date('25-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51005, to_date('25-09-2020 08:32:28', 'dd-mm-yyyy hh24:mi:ss'), 60142, to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51006, to_date('25-09-2020 08:32:37', 'dd-mm-yyyy hh24:mi:ss'), 50633, to_date('25-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51007, to_date('25-09-2020 08:32:42', 'dd-mm-yyyy hh24:mi:ss'), 50633, to_date('25-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51008, to_date('25-09-2020 08:32:52', 'dd-mm-yyyy hh24:mi:ss'), 60155, to_date('25-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51009, to_date('25-09-2020 08:32:57', 'dd-mm-yyyy hh24:mi:ss'), 60155, to_date('25-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51010, to_date('25-09-2020 08:33:05', 'dd-mm-yyyy hh24:mi:ss'), 54056, to_date('25-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51011, to_date('25-09-2020 08:33:12', 'dd-mm-yyyy hh24:mi:ss'), 54056, to_date('25-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51012, to_date('25-09-2020 08:33:21', 'dd-mm-yyyy hh24:mi:ss'), 60154, to_date('25-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51013, to_date('25-09-2020 08:33:26', 'dd-mm-yyyy hh24:mi:ss'), 60154, to_date('25-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51014, to_date('25-09-2020 08:33:41', 'dd-mm-yyyy hh24:mi:ss'), 54055, to_date('25-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51015, to_date('25-09-2020 08:33:48', 'dd-mm-yyyy hh24:mi:ss'), 54055, to_date('25-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51016, to_date('25-09-2020 08:33:57', 'dd-mm-yyyy hh24:mi:ss'), 60153, to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51017, to_date('25-09-2020 08:34:05', 'dd-mm-yyyy hh24:mi:ss'), 60153, to_date('25-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51018, to_date('25-09-2020 08:35:12', 'dd-mm-yyyy hh24:mi:ss'), 60152, to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51019, to_date('25-09-2020 08:35:21', 'dd-mm-yyyy hh24:mi:ss'), 60152, to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51020, to_date('25-09-2020 08:35:43', 'dd-mm-yyyy hh24:mi:ss'), 54077, to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51021, to_date('25-09-2020 08:39:45', 'dd-mm-yyyy hh24:mi:ss'), 54077, to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51022, to_date('25-09-2020 08:39:54', 'dd-mm-yyyy hh24:mi:ss'), 54076, to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51023, to_date('25-09-2020 08:39:58', 'dd-mm-yyyy hh24:mi:ss'), 54076, to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51024, to_date('25-09-2020 08:40:06', 'dd-mm-yyyy hh24:mi:ss'), 54054, to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51025, to_date('25-09-2020 08:40:11', 'dd-mm-yyyy hh24:mi:ss'), 54054, to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51026, to_date('25-09-2020 08:40:20', 'dd-mm-yyyy hh24:mi:ss'), 54053, to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51027, to_date('25-09-2020 08:40:26', 'dd-mm-yyyy hh24:mi:ss'), 54053, to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51028, to_date('25-09-2020 08:40:36', 'dd-mm-yyyy hh24:mi:ss'), 60151, to_date('25-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51029, to_date('25-09-2020 08:40:42', 'dd-mm-yyyy hh24:mi:ss'), 60151, to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51030, to_date('25-09-2020 08:40:50', 'dd-mm-yyyy hh24:mi:ss'), 54078, to_date('25-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51031, to_date('25-09-2020 08:40:55', 'dd-mm-yyyy hh24:mi:ss'), 54078, to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51032, to_date('25-09-2020 08:41:07', 'dd-mm-yyyy hh24:mi:ss'), 54052, to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51033, to_date('25-09-2020 08:41:13', 'dd-mm-yyyy hh24:mi:ss'), 54052, to_date('25-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51034, to_date('25-09-2020 08:41:24', 'dd-mm-yyyy hh24:mi:ss'), 60150, to_date('25-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51035, to_date('25-09-2020 08:41:30', 'dd-mm-yyyy hh24:mi:ss'), 60150, to_date('25-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51036, to_date('25-09-2020 08:41:42', 'dd-mm-yyyy hh24:mi:ss'), 60149, to_date('25-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51037, to_date('25-09-2020 08:41:47', 'dd-mm-yyyy hh24:mi:ss'), 60149, to_date('25-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51038, to_date('25-09-2020 08:41:56', 'dd-mm-yyyy hh24:mi:ss'), 60148, to_date('25-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51039, to_date('25-09-2020 08:42:01', 'dd-mm-yyyy hh24:mi:ss'), 60148, to_date('25-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51040, to_date('25-09-2020 08:42:13', 'dd-mm-yyyy hh24:mi:ss'), 54075, to_date('25-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51041, to_date('25-09-2020 08:42:18', 'dd-mm-yyyy hh24:mi:ss'), 54075, to_date('25-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51042, to_date('25-09-2020 08:42:30', 'dd-mm-yyyy hh24:mi:ss'), 60165, to_date('25-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51043, to_date('25-09-2020 08:42:35', 'dd-mm-yyyy hh24:mi:ss'), 60165, to_date('25-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51044, to_date('25-09-2020 08:42:43', 'dd-mm-yyyy hh24:mi:ss'), 54074, to_date('25-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51045, to_date('25-09-2020 08:42:48', 'dd-mm-yyyy hh24:mi:ss'), 54074, to_date('25-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51046, to_date('25-09-2020 08:42:57', 'dd-mm-yyyy hh24:mi:ss'), 60164, to_date('25-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51047, to_date('25-09-2020 08:43:03', 'dd-mm-yyyy hh24:mi:ss'), 60164, to_date('25-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51048, to_date('25-09-2020 08:43:12', 'dd-mm-yyyy hh24:mi:ss'), 60163, to_date('25-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51049, to_date('25-09-2020 08:43:18', 'dd-mm-yyyy hh24:mi:ss'), 60163, to_date('25-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51050, to_date('25-09-2020 08:43:34', 'dd-mm-yyyy hh24:mi:ss'), 54067, to_date('25-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51051, to_date('25-09-2020 08:43:39', 'dd-mm-yyyy hh24:mi:ss'), 54067, to_date('25-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51052, to_date('25-09-2020 08:43:51', 'dd-mm-yyyy hh24:mi:ss'), 60162, to_date('25-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51053, to_date('25-09-2020 08:43:57', 'dd-mm-yyyy hh24:mi:ss'), 60162, to_date('25-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51054, to_date('25-09-2020 08:44:08', 'dd-mm-yyyy hh24:mi:ss'), 60161, to_date('25-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51055, to_date('25-09-2020 08:44:15', 'dd-mm-yyyy hh24:mi:ss'), 60161, to_date('25-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51056, to_date('25-09-2020 08:44:24', 'dd-mm-yyyy hh24:mi:ss'), 60160, to_date('25-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51057, to_date('25-09-2020 08:44:30', 'dd-mm-yyyy hh24:mi:ss'), 60160, to_date('25-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51058, to_date('25-09-2020 08:44:38', 'dd-mm-yyyy hh24:mi:ss'), 60159, to_date('25-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51059, to_date('25-09-2020 08:44:44', 'dd-mm-yyyy hh24:mi:ss'), 60159, to_date('25-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51060, to_date('25-09-2020 08:44:56', 'dd-mm-yyyy hh24:mi:ss'), 54079, to_date('25-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51061, to_date('25-09-2020 08:45:07', 'dd-mm-yyyy hh24:mi:ss'), 54069, to_date('25-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51062, to_date('25-09-2020 08:45:13', 'dd-mm-yyyy hh24:mi:ss'), 54069, to_date('25-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51063, to_date('25-09-2020 08:45:29', 'dd-mm-yyyy hh24:mi:ss'), 54068, to_date('25-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51064, to_date('25-09-2020 08:45:35', 'dd-mm-yyyy hh24:mi:ss'), 54068, to_date('25-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51065, to_date('25-09-2020 08:45:43', 'dd-mm-yyyy hh24:mi:ss'), 60158, to_date('25-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51066, to_date('25-09-2020 08:45:49', 'dd-mm-yyyy hh24:mi:ss'), 60158, to_date('25-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51067, to_date('25-09-2020 08:45:59', 'dd-mm-yyyy hh24:mi:ss'), 54081, to_date('25-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51068, to_date('25-09-2020 08:46:05', 'dd-mm-yyyy hh24:mi:ss'), 54081, to_date('25-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51069, to_date('25-09-2020 08:46:14', 'dd-mm-yyyy hh24:mi:ss'), 60173, to_date('25-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51070, to_date('25-09-2020 08:46:22', 'dd-mm-yyyy hh24:mi:ss'), 60173, to_date('25-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51071, to_date('25-09-2020 08:46:33', 'dd-mm-yyyy hh24:mi:ss'), 60172, to_date('25-10-2020 23:28:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:28:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51072, to_date('25-09-2020 08:46:41', 'dd-mm-yyyy hh24:mi:ss'), 60172, to_date('25-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:28:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51073, to_date('25-09-2020 08:46:50', 'dd-mm-yyyy hh24:mi:ss'), 60171, to_date('25-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51074, to_date('25-09-2020 08:46:55', 'dd-mm-yyyy hh24:mi:ss'), 60171, to_date('25-10-2020 23:28:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51075, to_date('25-09-2020 08:47:05', 'dd-mm-yyyy hh24:mi:ss'), 60170, to_date('25-10-2020 23:26:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:26:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51076, to_date('25-09-2020 08:47:10', 'dd-mm-yyyy hh24:mi:ss'), 60170, to_date('25-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:26:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51077, to_date('25-09-2020 08:47:20', 'dd-mm-yyyy hh24:mi:ss'), 60169, to_date('25-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51078, to_date('25-09-2020 08:47:25', 'dd-mm-yyyy hh24:mi:ss'), 60169, to_date('25-10-2020 23:26:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51079, to_date('25-09-2020 08:47:36', 'dd-mm-yyyy hh24:mi:ss'), 60168, to_date('25-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51080, to_date('25-09-2020 08:47:51', 'dd-mm-yyyy hh24:mi:ss'), 60167, to_date('25-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51081, to_date('25-09-2020 08:47:57', 'dd-mm-yyyy hh24:mi:ss'), 60167, to_date('25-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51082, to_date('25-09-2020 08:48:07', 'dd-mm-yyyy hh24:mi:ss'), 60166, to_date('25-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51083, to_date('25-09-2020 08:48:12', 'dd-mm-yyyy hh24:mi:ss'), 60166, to_date('25-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51084, to_date('25-09-2020 08:48:22', 'dd-mm-yyyy hh24:mi:ss'), 60157, to_date('25-10-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51085, to_date('25-09-2020 08:48:29', 'dd-mm-yyyy hh24:mi:ss'), 60157, to_date('25-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51086, to_date('25-09-2020 08:48:38', 'dd-mm-yyyy hh24:mi:ss'), 60156, to_date('25-10-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51087, to_date('25-09-2020 08:48:44', 'dd-mm-yyyy hh24:mi:ss'), 60156, to_date('25-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51560, to_date('01-10-2020 16:35:56', 'dd-mm-yyyy hh24:mi:ss'), 76370, to_date('01-10-2020 19:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51561, to_date('01-10-2020 16:36:23', 'dd-mm-yyyy hh24:mi:ss'), 76381, to_date('01-11-2020 00:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51562, to_date('01-10-2020 16:36:49', 'dd-mm-yyyy hh24:mi:ss'), 76381, to_date('02-10-2020 00:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-11-2020 00:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
commit;
prompt 900 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51563, to_date('01-10-2020 16:37:32', 'dd-mm-yyyy hh24:mi:ss'), 76380, to_date('02-10-2020 00:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51564, to_date('01-10-2020 16:37:51', 'dd-mm-yyyy hh24:mi:ss'), 76379, to_date('02-10-2020 00:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51565, to_date('01-10-2020 16:38:26', 'dd-mm-yyyy hh24:mi:ss'), 76378, to_date('01-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51566, to_date('01-10-2020 16:38:39', 'dd-mm-yyyy hh24:mi:ss'), 76377, to_date('01-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51567, to_date('01-10-2020 16:38:47', 'dd-mm-yyyy hh24:mi:ss'), 76377, to_date('01-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51568, to_date('01-10-2020 16:39:06', 'dd-mm-yyyy hh24:mi:ss'), 76376, to_date('01-10-2020 23:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51569, to_date('01-10-2020 16:39:40', 'dd-mm-yyyy hh24:mi:ss'), 76375, to_date('01-10-2020 21:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51570, to_date('01-10-2020 16:39:47', 'dd-mm-yyyy hh24:mi:ss'), 76375, to_date('01-10-2020 22:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 21:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51571, to_date('01-10-2020 16:40:01', 'dd-mm-yyyy hh24:mi:ss'), 76374, to_date('01-10-2020 22:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51572, to_date('01-10-2020 16:40:13', 'dd-mm-yyyy hh24:mi:ss'), 76373, to_date('01-10-2020 22:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51573, to_date('01-10-2020 16:40:25', 'dd-mm-yyyy hh24:mi:ss'), 76372, to_date('01-10-2020 21:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51574, to_date('01-10-2020 16:40:39', 'dd-mm-yyyy hh24:mi:ss'), 76371, to_date('01-10-2020 21:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51575, to_date('01-10-2020 16:41:03', 'dd-mm-yyyy hh24:mi:ss'), 76370, to_date('01-10-2020 21:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 19:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52023, to_date('08-10-2020 08:03:45', 'dd-mm-yyyy hh24:mi:ss'), 89233, to_date('08-10-2020 08:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 12114);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52243, to_date('13-10-2020 07:29:20', 'dd-mm-yyyy hh24:mi:ss'), 5322, to_date('13-10-2020 07:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 14:45:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52244, to_date('13-10-2020 07:32:01', 'dd-mm-yyyy hh24:mi:ss'), 10416, to_date('13-10-2020 07:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52245, to_date('13-10-2020 07:34:19', 'dd-mm-yyyy hh24:mi:ss'), 5321, to_date('13-10-2020 14:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 14:46:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52246, to_date('13-10-2020 07:34:48', 'dd-mm-yyyy hh24:mi:ss'), 5321, to_date('13-10-2020 07:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 14:46:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52247, to_date('13-10-2020 07:35:36', 'dd-mm-yyyy hh24:mi:ss'), 7978, to_date('13-10-2020 07:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52248, to_date('13-10-2020 07:37:53', 'dd-mm-yyyy hh24:mi:ss'), 9506, to_date('13-10-2020 21:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 21:58:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52249, to_date('13-10-2020 07:38:24', 'dd-mm-yyyy hh24:mi:ss'), 9506, to_date('13-10-2020 07:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 21:58:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52250, to_date('13-10-2020 07:40:50', 'dd-mm-yyyy hh24:mi:ss'), 5312, to_date('13-10-2020 14:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 14:50:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52251, to_date('13-10-2020 07:41:01', 'dd-mm-yyyy hh24:mi:ss'), 5312, to_date('13-10-2020 07:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 14:50:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52253, to_date('13-10-2020 07:42:03', 'dd-mm-yyyy hh24:mi:ss'), 10444, to_date('13-10-2020 07:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52254, to_date('13-10-2020 07:47:13', 'dd-mm-yyyy hh24:mi:ss'), 10418, to_date('13-10-2020 08:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52255, to_date('13-10-2020 08:35:16', 'dd-mm-yyyy hh24:mi:ss'), 10431, to_date('13-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52256, to_date('13-10-2020 08:35:30', 'dd-mm-yyyy hh24:mi:ss'), 10431, to_date('13-10-2020 08:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52257, to_date('13-10-2020 08:37:52', 'dd-mm-yyyy hh24:mi:ss'), 10438, to_date('13-10-2020 08:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52259, to_date('13-10-2020 08:39:55', 'dd-mm-yyyy hh24:mi:ss'), 5292, to_date('13-10-2020 08:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:10:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52260, to_date('13-10-2020 08:42:07', 'dd-mm-yyyy hh24:mi:ss'), 10435, to_date('13-10-2020 08:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52261, to_date('13-10-2020 08:43:53', 'dd-mm-yyyy hh24:mi:ss'), 7972, to_date('13-10-2020 08:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 13:57:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52263, to_date('13-10-2020 08:45:46', 'dd-mm-yyyy hh24:mi:ss'), 7981, to_date('13-10-2020 09:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52264, to_date('13-10-2020 08:46:00', 'dd-mm-yyyy hh24:mi:ss'), 7981, to_date('13-10-2020 08:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 09:57:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52265, to_date('13-10-2020 08:46:48', 'dd-mm-yyyy hh24:mi:ss'), 5284, to_date('13-10-2020 09:03:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:03:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52267, to_date('13-10-2020 09:52:13', 'dd-mm-yyyy hh24:mi:ss'), 10415, to_date('13-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:21:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52268, to_date('13-10-2020 09:55:22', 'dd-mm-yyyy hh24:mi:ss'), 9443, to_date('13-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52269, to_date('13-10-2020 09:56:20', 'dd-mm-yyyy hh24:mi:ss'), 5314, to_date('13-10-2020 10:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 14:49:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52271, to_date('13-10-2020 10:32:06', 'dd-mm-yyyy hh24:mi:ss'), 110824, to_date('13-10-2020 10:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52273, to_date('13-10-2020 10:33:24', 'dd-mm-yyyy hh24:mi:ss'), 110823, to_date('13-10-2020 10:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52275, to_date('13-10-2020 10:34:24', 'dd-mm-yyyy hh24:mi:ss'), 110825, to_date('13-10-2020 10:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:03:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52338, to_date('14-10-2020 00:00:57', 'dd-mm-yyyy hh24:mi:ss'), 114742, to_date('14-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52339, to_date('14-10-2020 00:01:09', 'dd-mm-yyyy hh24:mi:ss'), 114743, to_date('14-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52527, to_date('21-10-2020 14:59:25', 'dd-mm-yyyy hh24:mi:ss'), 140391, to_date('21-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52528, to_date('21-10-2020 14:59:38', 'dd-mm-yyyy hh24:mi:ss'), 140392, to_date('21-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52529, to_date('21-10-2020 14:59:48', 'dd-mm-yyyy hh24:mi:ss'), 140392, to_date('21-10-2020 18:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51346, to_date('29-09-2020 07:34:31', 'dd-mm-yyyy hh24:mi:ss'), 72498, to_date('28-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51347, to_date('29-09-2020 07:34:37', 'dd-mm-yyyy hh24:mi:ss'), 72498, to_date('28-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51348, to_date('29-09-2020 07:34:46', 'dd-mm-yyyy hh24:mi:ss'), 72497, to_date('28-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51349, to_date('29-09-2020 07:34:51', 'dd-mm-yyyy hh24:mi:ss'), 72497, to_date('28-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51350, to_date('29-09-2020 07:35:01', 'dd-mm-yyyy hh24:mi:ss'), 72496, to_date('28-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51351, to_date('29-09-2020 07:35:07', 'dd-mm-yyyy hh24:mi:ss'), 72496, to_date('28-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51352, to_date('29-09-2020 07:35:16', 'dd-mm-yyyy hh24:mi:ss'), 72495, to_date('28-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51353, to_date('29-09-2020 07:35:22', 'dd-mm-yyyy hh24:mi:ss'), 72495, to_date('28-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51354, to_date('29-09-2020 07:35:31', 'dd-mm-yyyy hh24:mi:ss'), 72494, to_date('28-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51355, to_date('29-09-2020 07:35:36', 'dd-mm-yyyy hh24:mi:ss'), 72494, to_date('28-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51356, to_date('29-09-2020 07:35:48', 'dd-mm-yyyy hh24:mi:ss'), 72493, to_date('28-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51357, to_date('29-09-2020 07:36:05', 'dd-mm-yyyy hh24:mi:ss'), 72492, to_date('28-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51358, to_date('29-09-2020 07:36:11', 'dd-mm-yyyy hh24:mi:ss'), 72492, to_date('28-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51359, to_date('29-09-2020 08:22:11', 'dd-mm-yyyy hh24:mi:ss'), 66052, to_date('29-09-2020 11:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51360, to_date('29-09-2020 08:22:26', 'dd-mm-yyyy hh24:mi:ss'), 66053, to_date('29-09-2020 11:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51361, to_date('29-09-2020 08:22:46', 'dd-mm-yyyy hh24:mi:ss'), 66054, to_date('29-09-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51373, to_date('29-09-2020 09:48:45', 'dd-mm-yyyy hh24:mi:ss'), 66055, to_date('29-09-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51374, to_date('29-09-2020 09:49:05', 'dd-mm-yyyy hh24:mi:ss'), 66056, to_date('29-09-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51375, to_date('29-09-2020 09:49:25', 'dd-mm-yyyy hh24:mi:ss'), 66057, to_date('29-09-2020 13:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52049, to_date('08-10-2020 12:32:37', 'dd-mm-yyyy hh24:mi:ss'), 10439, to_date('08-10-2020 12:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52052, to_date('08-10-2020 12:34:01', 'dd-mm-yyyy hh24:mi:ss'), 10425, to_date('08-10-2020 12:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52054, to_date('08-10-2020 12:35:39', 'dd-mm-yyyy hh24:mi:ss'), 10437, to_date('08-10-2020 12:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52167, to_date('12-10-2020 09:50:33', 'dd-mm-yyyy hh24:mi:ss'), 5290, to_date('12-10-2020 10:09:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:09:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52169, to_date('12-10-2020 09:54:20', 'dd-mm-yyyy hh24:mi:ss'), 7980, to_date('12-10-2020 10:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52170, to_date('12-10-2020 09:54:31', 'dd-mm-yyyy hh24:mi:ss'), 7980, to_date('12-10-2020 09:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 10:57:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52198, to_date('12-10-2020 11:43:31', 'dd-mm-yyyy hh24:mi:ss'), 5291, to_date('12-10-2020 11:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:10:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52199, to_date('12-10-2020 11:46:19', 'dd-mm-yyyy hh24:mi:ss'), 5291, to_date('12-10-2020 11:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 11:55:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52340, to_date('14-10-2020 09:00:04', 'dd-mm-yyyy hh24:mi:ss'), 116028, to_date('14-10-2020 12:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52341, to_date('14-10-2020 09:01:46', 'dd-mm-yyyy hh24:mi:ss'), 116029, to_date('14-10-2020 12:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52342, to_date('14-10-2020 09:08:13', 'dd-mm-yyyy hh24:mi:ss'), 116030, to_date('14-10-2020 12:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52343, to_date('14-10-2020 09:08:30', 'dd-mm-yyyy hh24:mi:ss'), 116031, to_date('14-10-2020 12:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52485, to_date('19-10-2020 21:06:09', 'dd-mm-yyyy hh24:mi:ss'), 130464, to_date('20-10-2020', 'dd-mm-yyyy'), to_date('20-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52486, to_date('19-10-2020 21:19:25', 'dd-mm-yyyy hh24:mi:ss'), 130465, to_date('20-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52487, to_date('19-10-2020 21:19:41', 'dd-mm-yyyy hh24:mi:ss'), 130466, to_date('20-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52488, to_date('19-10-2020 21:19:57', 'dd-mm-yyyy hh24:mi:ss'), 130466, to_date('20-10-2020 00:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52489, to_date('19-10-2020 21:21:54', 'dd-mm-yyyy hh24:mi:ss'), 130467, to_date('20-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52490, to_date('19-10-2020 21:22:07', 'dd-mm-yyyy hh24:mi:ss'), 130468, to_date('20-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52491, to_date('19-10-2020 21:22:20', 'dd-mm-yyyy hh24:mi:ss'), 130469, to_date('20-10-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52492, to_date('19-10-2020 22:16:52', 'dd-mm-yyyy hh24:mi:ss'), 130469, to_date('20-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52493, to_date('19-10-2020 22:17:04', 'dd-mm-yyyy hh24:mi:ss'), 130468, to_date('20-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52744, to_date('29-10-2020 07:14:19', 'dd-mm-yyyy hh24:mi:ss'), 177360, to_date('29-10-2020 10:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52745, to_date('29-10-2020 07:14:39', 'dd-mm-yyyy hh24:mi:ss'), 177361, to_date('29-10-2020 10:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52746, to_date('29-10-2020 07:14:58', 'dd-mm-yyyy hh24:mi:ss'), 177361, to_date('29-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 10:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52747, to_date('29-10-2020 07:15:40', 'dd-mm-yyyy hh24:mi:ss'), 177362, to_date('29-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52748, to_date('29-10-2020 07:15:48', 'dd-mm-yyyy hh24:mi:ss'), 177362, to_date('29-10-2020 10:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52761, to_date('29-10-2020 16:20:26', 'dd-mm-yyyy hh24:mi:ss'), 177391, to_date('30-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52762, to_date('29-10-2020 16:20:47', 'dd-mm-yyyy hh24:mi:ss'), 177390, to_date('30-10-2020', 'dd-mm-yyyy'), to_date('29-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52763, to_date('29-10-2020 16:21:03', 'dd-mm-yyyy hh24:mi:ss'), 177389, to_date('29-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52764, to_date('29-10-2020 16:21:17', 'dd-mm-yyyy hh24:mi:ss'), 177388, to_date('29-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52765, to_date('29-10-2020 16:21:31', 'dd-mm-yyyy hh24:mi:ss'), 177387, to_date('29-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52766, to_date('29-10-2020 16:21:46', 'dd-mm-yyyy hh24:mi:ss'), 177386, to_date('29-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52767, to_date('29-10-2020 16:21:56', 'dd-mm-yyyy hh24:mi:ss'), 177385, to_date('29-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52768, to_date('29-10-2020 16:22:08', 'dd-mm-yyyy hh24:mi:ss'), 177384, to_date('29-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52769, to_date('29-10-2020 16:22:21', 'dd-mm-yyyy hh24:mi:ss'), 177383, to_date('29-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52770, to_date('29-10-2020 16:22:33', 'dd-mm-yyyy hh24:mi:ss'), 177382, to_date('29-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
commit;
prompt 1000 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52771, to_date('29-10-2020 16:22:44', 'dd-mm-yyyy hh24:mi:ss'), 177381, to_date('29-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52772, to_date('29-10-2020 16:22:58', 'dd-mm-yyyy hh24:mi:ss'), 177380, to_date('29-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52773, to_date('29-10-2020 18:39:45', 'dd-mm-yyyy hh24:mi:ss'), 177391, to_date('30-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52774, to_date('29-10-2020 18:39:56', 'dd-mm-yyyy hh24:mi:ss'), 177390, to_date('30-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52775, to_date('29-10-2020 18:40:07', 'dd-mm-yyyy hh24:mi:ss'), 177389, to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52776, to_date('29-10-2020 18:40:22', 'dd-mm-yyyy hh24:mi:ss'), 177388, to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52777, to_date('29-10-2020 18:40:29', 'dd-mm-yyyy hh24:mi:ss'), 177388, to_date('30-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52778, to_date('29-10-2020 18:40:41', 'dd-mm-yyyy hh24:mi:ss'), 177389, to_date('30-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52779, to_date('29-10-2020 18:41:03', 'dd-mm-yyyy hh24:mi:ss'), 177387, to_date('30-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52780, to_date('29-10-2020 18:41:09', 'dd-mm-yyyy hh24:mi:ss'), 177387, to_date('30-10-2020', 'dd-mm-yyyy'), to_date('30-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52781, to_date('29-10-2020 18:41:21', 'dd-mm-yyyy hh24:mi:ss'), 177386, to_date('29-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52782, to_date('29-10-2020 18:41:32', 'dd-mm-yyyy hh24:mi:ss'), 177385, to_date('29-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52783, to_date('29-10-2020 18:41:42', 'dd-mm-yyyy hh24:mi:ss'), 177384, to_date('29-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51604, to_date('05-10-2020 09:37:03', 'dd-mm-yyyy hh24:mi:ss'), 89270, to_date('30-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51605, to_date('05-10-2020 09:37:08', 'dd-mm-yyyy hh24:mi:ss'), 89270, to_date('30-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51606, to_date('05-10-2020 09:37:36', 'dd-mm-yyyy hh24:mi:ss'), 89269, to_date('30-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51607, to_date('05-10-2020 09:37:42', 'dd-mm-yyyy hh24:mi:ss'), 89269, to_date('30-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51608, to_date('05-10-2020 09:37:50', 'dd-mm-yyyy hh24:mi:ss'), 89268, to_date('30-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51609, to_date('05-10-2020 09:37:55', 'dd-mm-yyyy hh24:mi:ss'), 89268, to_date('30-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51610, to_date('05-10-2020 09:38:04', 'dd-mm-yyyy hh24:mi:ss'), 89267, to_date('30-10-2020 23:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:21:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51611, to_date('05-10-2020 09:38:09', 'dd-mm-yyyy hh24:mi:ss'), 89267, to_date('30-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:21:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51612, to_date('05-10-2020 09:38:19', 'dd-mm-yyyy hh24:mi:ss'), 89266, to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51613, to_date('05-10-2020 09:38:24', 'dd-mm-yyyy hh24:mi:ss'), 89266, to_date('30-10-2020 23:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51614, to_date('05-10-2020 09:38:32', 'dd-mm-yyyy hh24:mi:ss'), 89265, to_date('30-10-2020 23:19:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:19:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51615, to_date('05-10-2020 09:38:37', 'dd-mm-yyyy hh24:mi:ss'), 89265, to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:19:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51616, to_date('05-10-2020 09:38:45', 'dd-mm-yyyy hh24:mi:ss'), 89264, to_date('30-10-2020 23:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:18:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51617, to_date('05-10-2020 09:38:50', 'dd-mm-yyyy hh24:mi:ss'), 89264, to_date('30-10-2020 23:19:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:18:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51618, to_date('05-10-2020 09:38:58', 'dd-mm-yyyy hh24:mi:ss'), 89263, to_date('30-10-2020 23:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:17:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51619, to_date('05-10-2020 09:39:04', 'dd-mm-yyyy hh24:mi:ss'), 89263, to_date('30-10-2020 23:18:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:17:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51620, to_date('05-10-2020 09:39:12', 'dd-mm-yyyy hh24:mi:ss'), 89262, to_date('30-10-2020 23:16:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:16:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51621, to_date('05-10-2020 09:39:16', 'dd-mm-yyyy hh24:mi:ss'), 89262, to_date('30-10-2020 23:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:16:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51622, to_date('05-10-2020 09:39:32', 'dd-mm-yyyy hh24:mi:ss'), 89233, to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51623, to_date('05-10-2020 09:39:39', 'dd-mm-yyyy hh24:mi:ss'), 89233, to_date('30-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51624, to_date('05-10-2020 09:39:52', 'dd-mm-yyyy hh24:mi:ss'), 84649, to_date('30-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51625, to_date('05-10-2020 09:39:59', 'dd-mm-yyyy hh24:mi:ss'), 84649, to_date('30-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51626, to_date('05-10-2020 09:40:06', 'dd-mm-yyyy hh24:mi:ss'), 84648, to_date('30-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51627, to_date('05-10-2020 09:40:12', 'dd-mm-yyyy hh24:mi:ss'), 84648, to_date('30-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51628, to_date('05-10-2020 09:40:19', 'dd-mm-yyyy hh24:mi:ss'), 84651, to_date('30-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51629, to_date('05-10-2020 09:40:28', 'dd-mm-yyyy hh24:mi:ss'), 84650, to_date('30-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51630, to_date('05-10-2020 09:40:33', 'dd-mm-yyyy hh24:mi:ss'), 84650, to_date('30-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51631, to_date('05-10-2020 09:40:42', 'dd-mm-yyyy hh24:mi:ss'), 84652, to_date('30-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51632, to_date('05-10-2020 09:40:47', 'dd-mm-yyyy hh24:mi:ss'), 84652, to_date('30-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51633, to_date('05-10-2020 09:40:55', 'dd-mm-yyyy hh24:mi:ss'), 84654, to_date('30-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51634, to_date('05-10-2020 09:41:00', 'dd-mm-yyyy hh24:mi:ss'), 84654, to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51635, to_date('05-10-2020 09:41:11', 'dd-mm-yyyy hh24:mi:ss'), 84653, to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51636, to_date('05-10-2020 09:41:17', 'dd-mm-yyyy hh24:mi:ss'), 84653, to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51637, to_date('05-10-2020 09:41:26', 'dd-mm-yyyy hh24:mi:ss'), 89253, to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51638, to_date('05-10-2020 09:41:32', 'dd-mm-yyyy hh24:mi:ss'), 89253, to_date('30-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51639, to_date('05-10-2020 09:41:42', 'dd-mm-yyyy hh24:mi:ss'), 89252, to_date('30-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51640, to_date('05-10-2020 09:41:48', 'dd-mm-yyyy hh24:mi:ss'), 89252, to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51641, to_date('05-10-2020 09:41:58', 'dd-mm-yyyy hh24:mi:ss'), 89251, to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51642, to_date('05-10-2020 09:42:03', 'dd-mm-yyyy hh24:mi:ss'), 89251, to_date('30-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51643, to_date('05-10-2020 09:42:11', 'dd-mm-yyyy hh24:mi:ss'), 89250, to_date('30-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51644, to_date('05-10-2020 09:42:19', 'dd-mm-yyyy hh24:mi:ss'), 89250, to_date('30-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51645, to_date('05-10-2020 09:42:27', 'dd-mm-yyyy hh24:mi:ss'), 89249, to_date('30-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51646, to_date('05-10-2020 09:42:32', 'dd-mm-yyyy hh24:mi:ss'), 89249, to_date('30-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51647, to_date('05-10-2020 09:42:41', 'dd-mm-yyyy hh24:mi:ss'), 89248, to_date('30-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51648, to_date('05-10-2020 09:42:47', 'dd-mm-yyyy hh24:mi:ss'), 89248, to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51649, to_date('05-10-2020 09:42:58', 'dd-mm-yyyy hh24:mi:ss'), 89247, to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51650, to_date('05-10-2020 09:43:03', 'dd-mm-yyyy hh24:mi:ss'), 89247, to_date('30-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51651, to_date('05-10-2020 09:43:12', 'dd-mm-yyyy hh24:mi:ss'), 89246, to_date('30-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51652, to_date('05-10-2020 09:43:22', 'dd-mm-yyyy hh24:mi:ss'), 89246, to_date('30-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51653, to_date('05-10-2020 09:43:29', 'dd-mm-yyyy hh24:mi:ss'), 89245, to_date('30-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51654, to_date('05-10-2020 09:43:34', 'dd-mm-yyyy hh24:mi:ss'), 89245, to_date('30-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51655, to_date('05-10-2020 09:43:47', 'dd-mm-yyyy hh24:mi:ss'), 89244, to_date('30-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51656, to_date('05-10-2020 09:43:53', 'dd-mm-yyyy hh24:mi:ss'), 89244, to_date('30-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51657, to_date('05-10-2020 09:44:18', 'dd-mm-yyyy hh24:mi:ss'), 89243, to_date('30-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51658, to_date('05-10-2020 09:44:23', 'dd-mm-yyyy hh24:mi:ss'), 89243, to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51659, to_date('05-10-2020 09:44:31', 'dd-mm-yyyy hh24:mi:ss'), 89242, to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51660, to_date('05-10-2020 09:44:38', 'dd-mm-yyyy hh24:mi:ss'), 89242, to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51661, to_date('05-10-2020 09:45:03', 'dd-mm-yyyy hh24:mi:ss'), 89241, to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51662, to_date('05-10-2020 09:45:09', 'dd-mm-yyyy hh24:mi:ss'), 89241, to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51663, to_date('05-10-2020 09:45:17', 'dd-mm-yyyy hh24:mi:ss'), 89240, to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51664, to_date('05-10-2020 09:45:23', 'dd-mm-yyyy hh24:mi:ss'), 89240, to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51665, to_date('05-10-2020 09:45:48', 'dd-mm-yyyy hh24:mi:ss'), 89239, to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51666, to_date('05-10-2020 09:45:54', 'dd-mm-yyyy hh24:mi:ss'), 89239, to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51667, to_date('05-10-2020 09:46:04', 'dd-mm-yyyy hh24:mi:ss'), 89238, to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51668, to_date('05-10-2020 09:46:12', 'dd-mm-yyyy hh24:mi:ss'), 89238, to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51669, to_date('05-10-2020 09:46:22', 'dd-mm-yyyy hh24:mi:ss'), 89237, to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51670, to_date('05-10-2020 09:46:28', 'dd-mm-yyyy hh24:mi:ss'), 89237, to_date('30-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51671, to_date('05-10-2020 09:46:38', 'dd-mm-yyyy hh24:mi:ss'), 89236, to_date('30-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51672, to_date('05-10-2020 09:46:45', 'dd-mm-yyyy hh24:mi:ss'), 89236, to_date('30-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51673, to_date('05-10-2020 09:46:55', 'dd-mm-yyyy hh24:mi:ss'), 89235, to_date('30-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51674, to_date('05-10-2020 09:47:00', 'dd-mm-yyyy hh24:mi:ss'), 89235, to_date('30-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51675, to_date('05-10-2020 09:47:08', 'dd-mm-yyyy hh24:mi:ss'), 89234, to_date('30-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51676, to_date('05-10-2020 09:47:13', 'dd-mm-yyyy hh24:mi:ss'), 89234, to_date('30-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52391, to_date('15-10-2020 14:08:46', 'dd-mm-yyyy hh24:mi:ss'), 121238, to_date('15-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52392, to_date('15-10-2020 14:08:59', 'dd-mm-yyyy hh24:mi:ss'), 121239, to_date('15-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52637, to_date('26-10-2020 09:42:56', 'dd-mm-yyyy hh24:mi:ss'), 159990, to_date('26-10-2020 14:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52638, to_date('26-10-2020 09:43:07', 'dd-mm-yyyy hh24:mi:ss'), 159989, to_date('26-10-2020 14:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52639, to_date('26-10-2020 09:43:38', 'dd-mm-yyyy hh24:mi:ss'), 159988, to_date('26-10-2020 14:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52640, to_date('26-10-2020 09:43:51', 'dd-mm-yyyy hh24:mi:ss'), 159987, to_date('26-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52641, to_date('26-10-2020 09:44:04', 'dd-mm-yyyy hh24:mi:ss'), 159986, to_date('26-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52643, to_date('26-10-2020 11:21:48', 'dd-mm-yyyy hh24:mi:ss'), 160015, to_date('27-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52645, to_date('26-10-2020 11:23:30', 'dd-mm-yyyy hh24:mi:ss'), 160014, to_date('27-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52648, to_date('26-10-2020 11:24:00', 'dd-mm-yyyy hh24:mi:ss'), 160013, to_date('27-10-2020 00:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52649, to_date('26-10-2020 11:24:12', 'dd-mm-yyyy hh24:mi:ss'), 160012, to_date('26-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52650, to_date('26-10-2020 11:24:38', 'dd-mm-yyyy hh24:mi:ss'), 160011, to_date('26-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52651, to_date('26-10-2020 11:26:48', 'dd-mm-yyyy hh24:mi:ss'), 160010, to_date('26-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52652, to_date('26-10-2020 11:26:58', 'dd-mm-yyyy hh24:mi:ss'), 160009, to_date('26-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
commit;
prompt 1100 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52653, to_date('26-10-2020 11:27:09', 'dd-mm-yyyy hh24:mi:ss'), 160008, to_date('26-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52655, to_date('26-10-2020 11:27:27', 'dd-mm-yyyy hh24:mi:ss'), 160007, to_date('26-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52656, to_date('26-10-2020 11:27:50', 'dd-mm-yyyy hh24:mi:ss'), 160006, to_date('26-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52658, to_date('26-10-2020 11:28:02', 'dd-mm-yyyy hh24:mi:ss'), 160005, to_date('26-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52659, to_date('26-10-2020 11:28:17', 'dd-mm-yyyy hh24:mi:ss'), 160004, to_date('26-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52660, to_date('26-10-2020 11:28:31', 'dd-mm-yyyy hh24:mi:ss'), 160003, to_date('26-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52661, to_date('26-10-2020 11:28:43', 'dd-mm-yyyy hh24:mi:ss'), 160002, to_date('26-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52662, to_date('26-10-2020 11:28:55', 'dd-mm-yyyy hh24:mi:ss'), 160001, to_date('26-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52663, to_date('26-10-2020 11:29:13', 'dd-mm-yyyy hh24:mi:ss'), 160000, to_date('26-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52664, to_date('26-10-2020 11:29:24', 'dd-mm-yyyy hh24:mi:ss'), 159999, to_date('26-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52665, to_date('26-10-2020 11:29:35', 'dd-mm-yyyy hh24:mi:ss'), 159998, to_date('26-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52666, to_date('26-10-2020 11:29:46', 'dd-mm-yyyy hh24:mi:ss'), 159997, to_date('26-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52667, to_date('26-10-2020 11:29:58', 'dd-mm-yyyy hh24:mi:ss'), 159996, to_date('26-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52668, to_date('26-10-2020 11:30:16', 'dd-mm-yyyy hh24:mi:ss'), 159995, to_date('26-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52669, to_date('26-10-2020 11:30:43', 'dd-mm-yyyy hh24:mi:ss'), 159993, to_date('26-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52670, to_date('26-10-2020 11:31:13', 'dd-mm-yyyy hh24:mi:ss'), 159992, to_date('26-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52671, to_date('26-10-2020 11:31:24', 'dd-mm-yyyy hh24:mi:ss'), 159990, to_date('26-10-2020 16:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 14:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52672, to_date('26-10-2020 11:31:40', 'dd-mm-yyyy hh24:mi:ss'), 159991, to_date('26-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52673, to_date('26-10-2020 11:31:54', 'dd-mm-yyyy hh24:mi:ss'), 159988, to_date('26-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52674, to_date('26-10-2020 11:33:00', 'dd-mm-yyyy hh24:mi:ss'), 159994, to_date('26-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51537, to_date('01-10-2020 09:40:39', 'dd-mm-yyyy hh24:mi:ss'), 76395, to_date('01-10-2020 09:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('31-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51538, to_date('01-10-2020 09:46:23', 'dd-mm-yyyy hh24:mi:ss'), 76394, to_date('01-10-2020 09:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('31-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51539, to_date('01-10-2020 09:49:15', 'dd-mm-yyyy hh24:mi:ss'), 76392, to_date('01-10-2020 09:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('31-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51540, to_date('01-10-2020 09:54:06', 'dd-mm-yyyy hh24:mi:ss'), 79884, to_date('01-10-2020 09:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51541, to_date('01-10-2020 10:04:03', 'dd-mm-yyyy hh24:mi:ss'), 79885, to_date('01-10-2020 10:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51542, to_date('01-10-2020 10:05:55', 'dd-mm-yyyy hh24:mi:ss'), 79883, to_date('01-10-2020 10:07:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51543, to_date('01-10-2020 10:19:41', 'dd-mm-yyyy hh24:mi:ss'), 79886, to_date('01-10-2020 10:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51544, to_date('01-10-2020 10:21:25', 'dd-mm-yyyy hh24:mi:ss'), 79888, to_date('01-10-2020 10:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51545, to_date('01-10-2020 10:23:13', 'dd-mm-yyyy hh24:mi:ss'), 79887, to_date('01-10-2020 10:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51546, to_date('01-10-2020 10:24:51', 'dd-mm-yyyy hh24:mi:ss'), 79890, to_date('01-10-2020 10:26:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51677, to_date('05-10-2020 09:47:22', 'dd-mm-yyyy hh24:mi:ss'), 89261, to_date('30-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51678, to_date('05-10-2020 09:47:27', 'dd-mm-yyyy hh24:mi:ss'), 89261, to_date('30-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51679, to_date('05-10-2020 09:48:03', 'dd-mm-yyyy hh24:mi:ss'), 89260, to_date('30-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51680, to_date('05-10-2020 09:48:11', 'dd-mm-yyyy hh24:mi:ss'), 89260, to_date('30-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51681, to_date('05-10-2020 09:48:25', 'dd-mm-yyyy hh24:mi:ss'), 89259, to_date('30-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51682, to_date('05-10-2020 09:48:33', 'dd-mm-yyyy hh24:mi:ss'), 89259, to_date('30-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51683, to_date('05-10-2020 09:48:49', 'dd-mm-yyyy hh24:mi:ss'), 89258, to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51684, to_date('05-10-2020 09:48:58', 'dd-mm-yyyy hh24:mi:ss'), 89257, to_date('30-10-2020 23:28:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:28:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51685, to_date('05-10-2020 09:49:03', 'dd-mm-yyyy hh24:mi:ss'), 89257, to_date('30-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:28:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51686, to_date('05-10-2020 09:49:12', 'dd-mm-yyyy hh24:mi:ss'), 89256, to_date('30-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:27:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51687, to_date('05-10-2020 09:49:26', 'dd-mm-yyyy hh24:mi:ss'), 89255, to_date('30-10-2020 23:26:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:26:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51688, to_date('05-10-2020 09:49:32', 'dd-mm-yyyy hh24:mi:ss'), 89255, to_date('30-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:26:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51689, to_date('05-10-2020 09:49:41', 'dd-mm-yyyy hh24:mi:ss'), 89254, to_date('30-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51690, to_date('05-10-2020 09:49:48', 'dd-mm-yyyy hh24:mi:ss'), 89254, to_date('30-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51691, to_date('05-10-2020 10:31:38', 'dd-mm-yyyy hh24:mi:ss'), 10423, to_date('30-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51692, to_date('05-10-2020 10:31:49', 'dd-mm-yyyy hh24:mi:ss'), 10422, to_date('30-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51693, to_date('05-10-2020 10:31:56', 'dd-mm-yyyy hh24:mi:ss'), 10425, to_date('30-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51694, to_date('05-10-2020 10:32:05', 'dd-mm-yyyy hh24:mi:ss'), 10424, to_date('30-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51695, to_date('05-10-2020 10:32:12', 'dd-mm-yyyy hh24:mi:ss'), 10427, to_date('30-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51696, to_date('05-10-2020 10:32:20', 'dd-mm-yyyy hh24:mi:ss'), 10426, to_date('30-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51697, to_date('05-10-2020 10:32:28', 'dd-mm-yyyy hh24:mi:ss'), 10428, to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51698, to_date('05-10-2020 10:32:37', 'dd-mm-yyyy hh24:mi:ss'), 7975, to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51699, to_date('05-10-2020 10:32:48', 'dd-mm-yyyy hh24:mi:ss'), 7974, to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51700, to_date('05-10-2020 10:32:56', 'dd-mm-yyyy hh24:mi:ss'), 10431, to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51701, to_date('05-10-2020 10:33:04', 'dd-mm-yyyy hh24:mi:ss'), 7978, to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51702, to_date('05-10-2020 10:33:11', 'dd-mm-yyyy hh24:mi:ss'), 7976, to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51703, to_date('05-10-2020 10:33:18', 'dd-mm-yyyy hh24:mi:ss'), 10430, to_date('30-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51704, to_date('05-10-2020 10:33:26', 'dd-mm-yyyy hh24:mi:ss'), 10433, to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51705, to_date('05-10-2020 10:33:42', 'dd-mm-yyyy hh24:mi:ss'), 7980, to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51706, to_date('05-10-2020 10:33:50', 'dd-mm-yyyy hh24:mi:ss'), 7977, to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51707, to_date('05-10-2020 10:33:58', 'dd-mm-yyyy hh24:mi:ss'), 10432, to_date('30-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51708, to_date('05-10-2020 10:34:10', 'dd-mm-yyyy hh24:mi:ss'), 7979, to_date('30-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51709, to_date('05-10-2020 10:34:20', 'dd-mm-yyyy hh24:mi:ss'), 10435, to_date('30-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51710, to_date('05-10-2020 10:34:33', 'dd-mm-yyyy hh24:mi:ss'), 10434, to_date('30-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51711, to_date('05-10-2020 10:34:41', 'dd-mm-yyyy hh24:mi:ss'), 10436, to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51712, to_date('05-10-2020 10:34:50', 'dd-mm-yyyy hh24:mi:ss'), 7986, to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51713, to_date('05-10-2020 10:34:57', 'dd-mm-yyyy hh24:mi:ss'), 7982, to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51714, to_date('05-10-2020 10:35:04', 'dd-mm-yyyy hh24:mi:ss'), 7982, to_date('30-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51715, to_date('05-10-2020 10:35:12', 'dd-mm-yyyy hh24:mi:ss'), 10438, to_date('30-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51717, to_date('05-10-2020 10:35:30', 'dd-mm-yyyy hh24:mi:ss'), 7981, to_date('30-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51718, to_date('05-10-2020 10:35:39', 'dd-mm-yyyy hh24:mi:ss'), 10437, to_date('30-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51719, to_date('05-10-2020 10:35:49', 'dd-mm-yyyy hh24:mi:ss'), 10439, to_date('30-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51720, to_date('05-10-2020 10:35:56', 'dd-mm-yyyy hh24:mi:ss'), 7988, to_date('30-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51721, to_date('05-10-2020 10:36:03', 'dd-mm-yyyy hh24:mi:ss'), 7988, to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51722, to_date('05-10-2020 10:36:10', 'dd-mm-yyyy hh24:mi:ss'), 7985, to_date('30-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51723, to_date('05-10-2020 10:36:16', 'dd-mm-yyyy hh24:mi:ss'), 7985, to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51724, to_date('05-10-2020 10:36:27', 'dd-mm-yyyy hh24:mi:ss'), 7989, to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51725, to_date('05-10-2020 10:36:33', 'dd-mm-yyyy hh24:mi:ss'), 7989, to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51726, to_date('05-10-2020 10:36:45', 'dd-mm-yyyy hh24:mi:ss'), 7987, to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51727, to_date('05-10-2020 10:36:50', 'dd-mm-yyyy hh24:mi:ss'), 7987, to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51728, to_date('05-10-2020 10:36:59', 'dd-mm-yyyy hh24:mi:ss'), 10441, to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51729, to_date('05-10-2020 10:37:05', 'dd-mm-yyyy hh24:mi:ss'), 10441, to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51730, to_date('05-10-2020 10:37:52', 'dd-mm-yyyy hh24:mi:ss'), 10440, to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51731, to_date('05-10-2020 10:38:11', 'dd-mm-yyyy hh24:mi:ss'), 10440, to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51732, to_date('05-10-2020 10:38:26', 'dd-mm-yyyy hh24:mi:ss'), 7991, to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51733, to_date('05-10-2020 10:38:33', 'dd-mm-yyyy hh24:mi:ss'), 7991, to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51734, to_date('05-10-2020 10:38:44', 'dd-mm-yyyy hh24:mi:ss'), 7990, to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51735, to_date('05-10-2020 10:38:50', 'dd-mm-yyyy hh24:mi:ss'), 7990, to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51736, to_date('05-10-2020 10:38:57', 'dd-mm-yyyy hh24:mi:ss'), 10442, to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51737, to_date('05-10-2020 10:39:04', 'dd-mm-yyyy hh24:mi:ss'), 10442, to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51738, to_date('05-10-2020 10:39:11', 'dd-mm-yyyy hh24:mi:ss'), 7994, to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51739, to_date('05-10-2020 10:39:24', 'dd-mm-yyyy hh24:mi:ss'), 7993, to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51740, to_date('05-10-2020 10:39:29', 'dd-mm-yyyy hh24:mi:ss'), 7993, to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51741, to_date('05-10-2020 10:39:36', 'dd-mm-yyyy hh24:mi:ss'), 10444, to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51742, to_date('05-10-2020 10:39:41', 'dd-mm-yyyy hh24:mi:ss'), 10444, to_date('30-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51743, to_date('05-10-2020 10:39:50', 'dd-mm-yyyy hh24:mi:ss'), 7992, to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51744, to_date('05-10-2020 10:39:55', 'dd-mm-yyyy hh24:mi:ss'), 7992, to_date('30-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51745, to_date('05-10-2020 10:40:03', 'dd-mm-yyyy hh24:mi:ss'), 7997, to_date('30-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51746, to_date('05-10-2020 10:40:09', 'dd-mm-yyyy hh24:mi:ss'), 7997, to_date('30-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51747, to_date('05-10-2020 10:40:20', 'dd-mm-yyyy hh24:mi:ss'), 10419, to_date('30-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
commit;
prompt 1200 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51748, to_date('05-10-2020 10:40:37', 'dd-mm-yyyy hh24:mi:ss'), 10418, to_date('30-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:24:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51749, to_date('05-10-2020 10:40:44', 'dd-mm-yyyy hh24:mi:ss'), 10417, to_date('30-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51750, to_date('05-10-2020 10:40:52', 'dd-mm-yyyy hh24:mi:ss'), 10416, to_date('30-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:22:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51751, to_date('05-10-2020 10:40:59', 'dd-mm-yyyy hh24:mi:ss'), 10415, to_date('30-10-2020 23:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:21:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51752, to_date('05-10-2020 10:41:07', 'dd-mm-yyyy hh24:mi:ss'), 10414, to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51753, to_date('05-10-2020 10:41:15', 'dd-mm-yyyy hh24:mi:ss'), 9443, to_date('30-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51754, to_date('05-10-2020 10:41:22', 'dd-mm-yyyy hh24:mi:ss'), 10413, to_date('30-10-2020 23:19:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 23:19:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51755, to_date('05-10-2020 10:41:30', 'dd-mm-yyyy hh24:mi:ss'), 9506, to_date('30-10-2020 21:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 21:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51756, to_date('05-10-2020 10:41:36', 'dd-mm-yyyy hh24:mi:ss'), 9506, to_date('30-10-2020 21:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 21:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51757, to_date('05-10-2020 10:41:43', 'dd-mm-yyyy hh24:mi:ss'), 5294, to_date('30-10-2020 15:12:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:12:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51758, to_date('05-10-2020 10:41:54', 'dd-mm-yyyy hh24:mi:ss'), 5292, to_date('30-10-2020 15:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:10:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51759, to_date('05-10-2020 10:42:02', 'dd-mm-yyyy hh24:mi:ss'), 5291, to_date('30-10-2020 15:09:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:09:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51760, to_date('05-10-2020 10:42:08', 'dd-mm-yyyy hh24:mi:ss'), 5291, to_date('30-10-2020 15:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:09:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51761, to_date('05-10-2020 10:42:16', 'dd-mm-yyyy hh24:mi:ss'), 5290, to_date('30-10-2020 15:08:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:08:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51762, to_date('05-10-2020 10:42:21', 'dd-mm-yyyy hh24:mi:ss'), 5290, to_date('30-10-2020 15:09:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:08:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51763, to_date('05-10-2020 10:42:29', 'dd-mm-yyyy hh24:mi:ss'), 5289, to_date('30-10-2020 15:07:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:07:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51764, to_date('05-10-2020 10:42:38', 'dd-mm-yyyy hh24:mi:ss'), 5288, to_date('30-10-2020 15:06:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:06:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51765, to_date('05-10-2020 10:42:43', 'dd-mm-yyyy hh24:mi:ss'), 5288, to_date('30-10-2020 15:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:06:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51766, to_date('05-10-2020 10:42:51', 'dd-mm-yyyy hh24:mi:ss'), 5287, to_date('30-10-2020 15:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:05:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51767, to_date('05-10-2020 10:42:59', 'dd-mm-yyyy hh24:mi:ss'), 5286, to_date('30-10-2020 15:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:04:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51768, to_date('05-10-2020 10:43:08', 'dd-mm-yyyy hh24:mi:ss'), 5285, to_date('30-10-2020 15:03:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:03:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51769, to_date('05-10-2020 10:43:16', 'dd-mm-yyyy hh24:mi:ss'), 5284, to_date('30-10-2020 15:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:02:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51770, to_date('05-10-2020 10:43:21', 'dd-mm-yyyy hh24:mi:ss'), 5284, to_date('30-10-2020 15:03:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:02:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51771, to_date('05-10-2020 10:43:28', 'dd-mm-yyyy hh24:mi:ss'), 5283, to_date('30-10-2020 15:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 15:01:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51772, to_date('05-10-2020 10:43:36', 'dd-mm-yyyy hh24:mi:ss'), 5309, to_date('30-10-2020 14:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 14:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51773, to_date('05-10-2020 10:43:45', 'dd-mm-yyyy hh24:mi:ss'), 5312, to_date('30-10-2020 14:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 14:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51774, to_date('05-10-2020 10:43:51', 'dd-mm-yyyy hh24:mi:ss'), 5312, to_date('30-10-2020 14:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 14:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51775, to_date('05-10-2020 10:44:35', 'dd-mm-yyyy hh24:mi:ss'), 5314, to_date('30-10-2020 14:49:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 14:49:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51776, to_date('05-10-2020 10:44:51', 'dd-mm-yyyy hh24:mi:ss'), 5321, to_date('30-10-2020 14:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 14:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51777, to_date('05-10-2020 10:44:59', 'dd-mm-yyyy hh24:mi:ss'), 5322, to_date('30-10-2020 14:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 14:45:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51778, to_date('05-10-2020 10:45:23', 'dd-mm-yyyy hh24:mi:ss'), 5324, to_date('30-10-2020 14:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 14:43:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51779, to_date('05-10-2020 10:45:31', 'dd-mm-yyyy hh24:mi:ss'), 7972, to_date('30-10-2020 13:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 13:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51780, to_date('05-10-2020 10:45:39', 'dd-mm-yyyy hh24:mi:ss'), 7971, to_date('30-10-2020 13:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 13:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51781, to_date('05-10-2020 10:45:45', 'dd-mm-yyyy hh24:mi:ss'), 7971, to_date('30-10-2020 13:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 13:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51782, to_date('05-10-2020 10:45:55', 'dd-mm-yyyy hh24:mi:ss'), 7973, to_date('30-10-2020 13:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 13:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51783, to_date('05-10-2020 10:46:00', 'dd-mm-yyyy hh24:mi:ss'), 7973, to_date('30-10-2020 13:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 13:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51784, to_date('05-10-2020 10:46:08', 'dd-mm-yyyy hh24:mi:ss'), 7996, to_date('30-10-2020 12:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 12:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51785, to_date('05-10-2020 10:46:21', 'dd-mm-yyyy hh24:mi:ss'), 988002, to_date('30-10-2020 08:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 08:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51786, to_date('05-10-2020 10:46:27', 'dd-mm-yyyy hh24:mi:ss'), 988002, to_date('30-10-2020 08:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 08:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51787, to_date('05-10-2020 10:46:36', 'dd-mm-yyyy hh24:mi:ss'), 985221, to_date('30-10-2020 06:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('04-10-2020 06:02:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51788, to_date('05-10-2020 10:46:41', 'dd-mm-yyyy hh24:mi:ss'), 985221, to_date('30-10-2020 06:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 06:02:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51789, to_date('05-10-2020 11:24:39', 'dd-mm-yyyy hh24:mi:ss'), 84638, to_date('06-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51790, to_date('05-10-2020 11:24:58', 'dd-mm-yyyy hh24:mi:ss'), 84638, to_date('06-10-2020 11:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51791, to_date('05-10-2020 11:28:09', 'dd-mm-yyyy hh24:mi:ss'), 84637, to_date('06-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51792, to_date('05-10-2020 11:28:37', 'dd-mm-yyyy hh24:mi:ss'), 84637, to_date('06-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51793, to_date('05-10-2020 11:28:45', 'dd-mm-yyyy hh24:mi:ss'), 84637, to_date('06-10-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51794, to_date('05-10-2020 11:28:58', 'dd-mm-yyyy hh24:mi:ss'), 84636, to_date('06-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51795, to_date('05-10-2020 11:29:04', 'dd-mm-yyyy hh24:mi:ss'), 84636, to_date('06-10-2020 11:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51796, to_date('05-10-2020 11:29:10', 'dd-mm-yyyy hh24:mi:ss'), 84636, to_date('06-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 11:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51797, to_date('05-10-2020 11:29:34', 'dd-mm-yyyy hh24:mi:ss'), 84635, to_date('06-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51798, to_date('05-10-2020 11:29:39', 'dd-mm-yyyy hh24:mi:ss'), 84635, to_date('06-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51799, to_date('05-10-2020 11:29:45', 'dd-mm-yyyy hh24:mi:ss'), 84635, to_date('06-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51800, to_date('05-10-2020 11:30:34', 'dd-mm-yyyy hh24:mi:ss'), 84634, to_date('06-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51801, to_date('05-10-2020 11:30:41', 'dd-mm-yyyy hh24:mi:ss'), 84634, to_date('06-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51802, to_date('05-10-2020 11:30:47', 'dd-mm-yyyy hh24:mi:ss'), 84634, to_date('06-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51803, to_date('05-10-2020 11:31:02', 'dd-mm-yyyy hh24:mi:ss'), 84633, to_date('05-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51804, to_date('05-10-2020 11:31:45', 'dd-mm-yyyy hh24:mi:ss'), 84632, to_date('05-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51805, to_date('05-10-2020 11:32:05', 'dd-mm-yyyy hh24:mi:ss'), 84631, to_date('05-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51806, to_date('05-10-2020 11:32:16', 'dd-mm-yyyy hh24:mi:ss'), 84630, to_date('05-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51807, to_date('05-10-2020 11:32:28', 'dd-mm-yyyy hh24:mi:ss'), 84629, to_date('05-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51808, to_date('05-10-2020 11:32:40', 'dd-mm-yyyy hh24:mi:ss'), 84628, to_date('05-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51809, to_date('05-10-2020 11:32:52', 'dd-mm-yyyy hh24:mi:ss'), 84627, to_date('05-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51810, to_date('05-10-2020 11:33:02', 'dd-mm-yyyy hh24:mi:ss'), 84626, to_date('05-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51811, to_date('05-10-2020 11:33:13', 'dd-mm-yyyy hh24:mi:ss'), 84625, to_date('05-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51812, to_date('05-10-2020 11:33:48', 'dd-mm-yyyy hh24:mi:ss'), 84624, to_date('05-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51813, to_date('05-10-2020 11:34:12', 'dd-mm-yyyy hh24:mi:ss'), 84623, to_date('05-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51814, to_date('05-10-2020 11:34:26', 'dd-mm-yyyy hh24:mi:ss'), 84622, to_date('05-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51815, to_date('05-10-2020 11:34:36', 'dd-mm-yyyy hh24:mi:ss'), 84621, to_date('05-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51816, to_date('05-10-2020 11:34:48', 'dd-mm-yyyy hh24:mi:ss'), 84620, to_date('05-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51817, to_date('05-10-2020 11:35:01', 'dd-mm-yyyy hh24:mi:ss'), 84619, to_date('05-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51818, to_date('05-10-2020 11:35:14', 'dd-mm-yyyy hh24:mi:ss'), 84618, to_date('05-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51819, to_date('05-10-2020 11:35:25', 'dd-mm-yyyy hh24:mi:ss'), 84617, to_date('05-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51820, to_date('05-10-2020 11:35:38', 'dd-mm-yyyy hh24:mi:ss'), 84616, to_date('05-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51821, to_date('05-10-2020 11:35:50', 'dd-mm-yyyy hh24:mi:ss'), 84615, to_date('05-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51822, to_date('05-10-2020 11:36:02', 'dd-mm-yyyy hh24:mi:ss'), 84614, to_date('05-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51823, to_date('05-10-2020 11:36:13', 'dd-mm-yyyy hh24:mi:ss'), 84613, to_date('05-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51824, to_date('05-10-2020 11:36:25', 'dd-mm-yyyy hh24:mi:ss'), 84612, to_date('05-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('05-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51942, to_date('07-10-2020 06:24:09', 'dd-mm-yyyy hh24:mi:ss'), 93801, to_date('07-10-2020 09:25:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51943, to_date('07-10-2020 06:24:28', 'dd-mm-yyyy hh24:mi:ss'), 93802, to_date('07-10-2020 09:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51944, to_date('07-10-2020 06:25:00', 'dd-mm-yyyy hh24:mi:ss'), 93803, to_date('07-10-2020 11:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51945, to_date('07-10-2020 06:25:10', 'dd-mm-yyyy hh24:mi:ss'), 93803, to_date('07-10-2020 10:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 11:30:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51946, to_date('07-10-2020 06:25:29', 'dd-mm-yyyy hh24:mi:ss'), 93804, to_date('07-10-2020 10:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51964, to_date('07-10-2020 10:29:12', 'dd-mm-yyyy hh24:mi:ss'), 93808, to_date('07-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51972, to_date('07-10-2020 13:10:41', 'dd-mm-yyyy hh24:mi:ss'), 93830, to_date('07-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51973, to_date('07-10-2020 13:10:52', 'dd-mm-yyyy hh24:mi:ss'), 93829, to_date('07-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51974, to_date('07-10-2020 13:11:03', 'dd-mm-yyyy hh24:mi:ss'), 93828, to_date('07-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51975, to_date('07-10-2020 13:11:13', 'dd-mm-yyyy hh24:mi:ss'), 93827, to_date('07-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51976, to_date('07-10-2020 13:11:25', 'dd-mm-yyyy hh24:mi:ss'), 93826, to_date('07-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51977, to_date('07-10-2020 13:11:35', 'dd-mm-yyyy hh24:mi:ss'), 93825, to_date('07-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51978, to_date('07-10-2020 13:11:48', 'dd-mm-yyyy hh24:mi:ss'), 93824, to_date('07-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51979, to_date('07-10-2020 13:11:59', 'dd-mm-yyyy hh24:mi:ss'), 93823, to_date('07-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51980, to_date('07-10-2020 13:12:10', 'dd-mm-yyyy hh24:mi:ss'), 93822, to_date('07-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51981, to_date('07-10-2020 13:12:24', 'dd-mm-yyyy hh24:mi:ss'), 93821, to_date('07-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51982, to_date('07-10-2020 13:12:42', 'dd-mm-yyyy hh24:mi:ss'), 93820, to_date('07-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51983, to_date('07-10-2020 13:12:58', 'dd-mm-yyyy hh24:mi:ss'), 93819, to_date('07-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51470, to_date('30-09-2020 08:22:55', 'dd-mm-yyyy hh24:mi:ss'), 72505, to_date('30-09-2020 11:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51471, to_date('30-09-2020 08:23:09', 'dd-mm-yyyy hh24:mi:ss'), 72506, to_date('30-09-2020 11:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51482, to_date('30-09-2020 09:42:29', 'dd-mm-yyyy hh24:mi:ss'), 72507, to_date('30-09-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51483, to_date('30-09-2020 09:42:42', 'dd-mm-yyyy hh24:mi:ss'), 72508, to_date('30-09-2020 13:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51484, to_date('30-09-2020 09:42:57', 'dd-mm-yyyy hh24:mi:ss'), 72509, to_date('30-09-2020 13:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
commit;
prompt 1300 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51935, to_date('06-10-2020 16:47:16', 'dd-mm-yyyy hh24:mi:ss'), 89213, to_date('06-10-2020 19:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51936, to_date('06-10-2020 16:47:35', 'dd-mm-yyyy hh24:mi:ss'), 89214, to_date('06-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51937, to_date('06-10-2020 16:48:21', 'dd-mm-yyyy hh24:mi:ss'), 89215, to_date('06-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51961, to_date('07-10-2020 09:33:18', 'dd-mm-yyyy hh24:mi:ss'), 93805, to_date('07-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51962, to_date('07-10-2020 09:33:31', 'dd-mm-yyyy hh24:mi:ss'), 93806, to_date('07-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51963, to_date('07-10-2020 09:33:46', 'dd-mm-yyyy hh24:mi:ss'), 93807, to_date('07-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('07-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52171, to_date('12-10-2020 11:08:52', 'dd-mm-yyyy hh24:mi:ss'), 110817, to_date('13-10-2020', 'dd-mm-yyyy'), to_date('12-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52172, to_date('12-10-2020 11:09:03', 'dd-mm-yyyy hh24:mi:ss'), 110816, to_date('12-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52173, to_date('12-10-2020 11:09:35', 'dd-mm-yyyy hh24:mi:ss'), 110815, to_date('12-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52174, to_date('12-10-2020 11:10:03', 'dd-mm-yyyy hh24:mi:ss'), 110814, to_date('12-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52175, to_date('12-10-2020 11:10:12', 'dd-mm-yyyy hh24:mi:ss'), 110813, to_date('12-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52176, to_date('12-10-2020 11:10:49', 'dd-mm-yyyy hh24:mi:ss'), 110812, to_date('12-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52177, to_date('12-10-2020 11:10:59', 'dd-mm-yyyy hh24:mi:ss'), 110811, to_date('12-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52178, to_date('12-10-2020 11:11:12', 'dd-mm-yyyy hh24:mi:ss'), 110810, to_date('12-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52179, to_date('12-10-2020 11:11:43', 'dd-mm-yyyy hh24:mi:ss'), 110809, to_date('12-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52180, to_date('12-10-2020 11:11:54', 'dd-mm-yyyy hh24:mi:ss'), 110808, to_date('12-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52181, to_date('12-10-2020 11:12:05', 'dd-mm-yyyy hh24:mi:ss'), 110807, to_date('12-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52182, to_date('12-10-2020 11:12:20', 'dd-mm-yyyy hh24:mi:ss'), 110806, to_date('12-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52183, to_date('12-10-2020 11:12:31', 'dd-mm-yyyy hh24:mi:ss'), 110805, to_date('12-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52184, to_date('12-10-2020 11:12:43', 'dd-mm-yyyy hh24:mi:ss'), 110804, to_date('12-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52185, to_date('12-10-2020 11:12:55', 'dd-mm-yyyy hh24:mi:ss'), 110803, to_date('12-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52186, to_date('12-10-2020 11:13:12', 'dd-mm-yyyy hh24:mi:ss'), 110802, to_date('12-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52187, to_date('12-10-2020 11:13:23', 'dd-mm-yyyy hh24:mi:ss'), 110801, to_date('12-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52188, to_date('12-10-2020 11:14:27', 'dd-mm-yyyy hh24:mi:ss'), 110800, to_date('12-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52189, to_date('12-10-2020 11:14:38', 'dd-mm-yyyy hh24:mi:ss'), 110799, to_date('12-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52190, to_date('12-10-2020 11:15:05', 'dd-mm-yyyy hh24:mi:ss'), 110798, to_date('12-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52191, to_date('12-10-2020 11:15:20', 'dd-mm-yyyy hh24:mi:ss'), 110797, to_date('12-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52192, to_date('12-10-2020 11:15:53', 'dd-mm-yyyy hh24:mi:ss'), 110796, to_date('12-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52193, to_date('12-10-2020 11:16:04', 'dd-mm-yyyy hh24:mi:ss'), 110795, to_date('12-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52194, to_date('12-10-2020 11:17:07', 'dd-mm-yyyy hh24:mi:ss'), 110794, to_date('12-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52195, to_date('12-10-2020 11:17:21', 'dd-mm-yyyy hh24:mi:ss'), 110793, to_date('12-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52196, to_date('12-10-2020 11:17:34', 'dd-mm-yyyy hh24:mi:ss'), 110792, to_date('12-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52405, to_date('16-10-2020 10:27:06', 'dd-mm-yyyy hh24:mi:ss'), 124630, to_date('16-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52406, to_date('16-10-2020 10:27:17', 'dd-mm-yyyy hh24:mi:ss'), 124629, to_date('16-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52407, to_date('16-10-2020 10:27:28', 'dd-mm-yyyy hh24:mi:ss'), 124628, to_date('16-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52408, to_date('16-10-2020 10:27:38', 'dd-mm-yyyy hh24:mi:ss'), 124627, to_date('16-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52409, to_date('16-10-2020 10:27:52', 'dd-mm-yyyy hh24:mi:ss'), 124626, to_date('16-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52410, to_date('16-10-2020 10:29:09', 'dd-mm-yyyy hh24:mi:ss'), 124625, to_date('16-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52411, to_date('16-10-2020 10:29:21', 'dd-mm-yyyy hh24:mi:ss'), 124624, to_date('16-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52412, to_date('16-10-2020 10:29:34', 'dd-mm-yyyy hh24:mi:ss'), 124623, to_date('16-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52413, to_date('16-10-2020 10:31:42', 'dd-mm-yyyy hh24:mi:ss'), 124622, to_date('16-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52414, to_date('16-10-2020 10:32:01', 'dd-mm-yyyy hh24:mi:ss'), 124621, to_date('16-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52415, to_date('16-10-2020 10:32:11', 'dd-mm-yyyy hh24:mi:ss'), 124620, to_date('16-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52416, to_date('16-10-2020 10:32:22', 'dd-mm-yyyy hh24:mi:ss'), 124619, to_date('16-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52417, to_date('16-10-2020 10:32:34', 'dd-mm-yyyy hh24:mi:ss'), 124618, to_date('16-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52418, to_date('16-10-2020 10:32:47', 'dd-mm-yyyy hh24:mi:ss'), 124617, to_date('16-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('16-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52584, to_date('22-10-2020 21:21:04', 'dd-mm-yyyy hh24:mi:ss'), 151325, to_date('23-10-2020 10:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 01:59:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52585, to_date('22-10-2020 21:21:17', 'dd-mm-yyyy hh24:mi:ss'), 151324, to_date('23-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52715, to_date('27-10-2020 19:41:59', 'dd-mm-yyyy hh24:mi:ss'), 165128, to_date('27-10-2020 22:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52716, to_date('27-10-2020 19:42:16', 'dd-mm-yyyy hh24:mi:ss'), 165129, to_date('27-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52717, to_date('27-10-2020 19:42:39', 'dd-mm-yyyy hh24:mi:ss'), 165130, to_date('27-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52718, to_date('27-10-2020 19:42:50', 'dd-mm-yyyy hh24:mi:ss'), 165130, to_date('27-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52719, to_date('27-10-2020 19:43:17', 'dd-mm-yyyy hh24:mi:ss'), 165131, to_date('27-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52749, to_date('29-10-2020 15:30:00', 'dd-mm-yyyy hh24:mi:ss'), 177391, to_date('29-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52750, to_date('29-10-2020 15:30:19', 'dd-mm-yyyy hh24:mi:ss'), 177390, to_date('29-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52751, to_date('29-10-2020 15:30:33', 'dd-mm-yyyy hh24:mi:ss'), 177389, to_date('29-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52752, to_date('29-10-2020 15:31:04', 'dd-mm-yyyy hh24:mi:ss'), 177388, to_date('29-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52753, to_date('29-10-2020 15:31:18', 'dd-mm-yyyy hh24:mi:ss'), 177387, to_date('29-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52754, to_date('29-10-2020 15:31:32', 'dd-mm-yyyy hh24:mi:ss'), 177386, to_date('29-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52755, to_date('29-10-2020 15:31:52', 'dd-mm-yyyy hh24:mi:ss'), 177385, to_date('29-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52756, to_date('29-10-2020 15:32:05', 'dd-mm-yyyy hh24:mi:ss'), 177384, to_date('29-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52757, to_date('29-10-2020 15:32:20', 'dd-mm-yyyy hh24:mi:ss'), 177383, to_date('29-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52758, to_date('29-10-2020 15:32:40', 'dd-mm-yyyy hh24:mi:ss'), 177382, to_date('29-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52759, to_date('29-10-2020 15:33:20', 'dd-mm-yyyy hh24:mi:ss'), 177381, to_date('29-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52760, to_date('29-10-2020 15:33:46', 'dd-mm-yyyy hh24:mi:ss'), 177380, to_date('29-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52498, to_date('20-10-2020 10:24:46', 'dd-mm-yyyy hh24:mi:ss'), 135424, to_date('20-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52499, to_date('20-10-2020 10:25:07', 'dd-mm-yyyy hh24:mi:ss'), 135422, to_date('20-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52500, to_date('20-10-2020 10:25:18', 'dd-mm-yyyy hh24:mi:ss'), 135421, to_date('20-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52501, to_date('20-10-2020 10:25:28', 'dd-mm-yyyy hh24:mi:ss'), 135420, to_date('20-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52502, to_date('20-10-2020 10:25:38', 'dd-mm-yyyy hh24:mi:ss'), 135419, to_date('20-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52503, to_date('20-10-2020 10:25:50', 'dd-mm-yyyy hh24:mi:ss'), 135418, to_date('20-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52504, to_date('20-10-2020 10:26:26', 'dd-mm-yyyy hh24:mi:ss'), 135417, to_date('20-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51096, to_date('25-09-2020 11:13:30', 'dd-mm-yyyy hh24:mi:ss'), 60136, to_date('25-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51097, to_date('25-09-2020 11:13:43', 'dd-mm-yyyy hh24:mi:ss'), 60136, to_date('25-09-2020 11:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51300, to_date('28-09-2020 16:40:32', 'dd-mm-yyyy hh24:mi:ss'), 60129, to_date('29-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51301, to_date('28-09-2020 16:40:40', 'dd-mm-yyyy hh24:mi:ss'), 60129, to_date('29-09-2020', 'dd-mm-yyyy'), to_date('29-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51302, to_date('28-09-2020 16:40:58', 'dd-mm-yyyy hh24:mi:ss'), 60128, to_date('29-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51303, to_date('28-09-2020 16:41:13', 'dd-mm-yyyy hh24:mi:ss'), 60128, to_date('28-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51304, to_date('28-09-2020 16:41:28', 'dd-mm-yyyy hh24:mi:ss'), 60127, to_date('28-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51305, to_date('28-09-2020 16:41:42', 'dd-mm-yyyy hh24:mi:ss'), 60126, to_date('28-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51306, to_date('28-09-2020 16:41:58', 'dd-mm-yyyy hh24:mi:ss'), 60125, to_date('28-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51307, to_date('28-09-2020 16:42:14', 'dd-mm-yyyy hh24:mi:ss'), 60122, to_date('28-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51308, to_date('28-09-2020 17:58:57', 'dd-mm-yyyy hh24:mi:ss'), 60122, to_date('28-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51309, to_date('28-09-2020 17:59:25', 'dd-mm-yyyy hh24:mi:ss'), 60122, to_date('28-09-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51310, to_date('28-09-2020 19:37:08', 'dd-mm-yyyy hh24:mi:ss'), 60128, to_date('29-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51311, to_date('28-09-2020 19:37:20', 'dd-mm-yyyy hh24:mi:ss'), 60128, to_date('29-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51312, to_date('28-09-2020 19:38:27', 'dd-mm-yyyy hh24:mi:ss'), 60127, to_date('29-09-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51313, to_date('28-09-2020 19:38:57', 'dd-mm-yyyy hh24:mi:ss'), 60126, to_date('29-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51314, to_date('28-09-2020 19:39:26', 'dd-mm-yyyy hh24:mi:ss'), 60126, to_date('29-09-2020', 'dd-mm-yyyy'), to_date('29-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51315, to_date('28-09-2020 19:39:48', 'dd-mm-yyyy hh24:mi:ss'), 60125, to_date('28-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51316, to_date('28-09-2020 20:35:08', 'dd-mm-yyyy hh24:mi:ss'), 60125, to_date('28-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51317, to_date('28-09-2020 21:00:28', 'dd-mm-yyyy hh24:mi:ss'), 60129, to_date('29-09-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51318, to_date('28-09-2020 21:09:02', 'dd-mm-yyyy hh24:mi:ss'), 60128, to_date('29-09-2020 08:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51319, to_date('28-09-2020 21:16:33', 'dd-mm-yyyy hh24:mi:ss'), 60127, to_date('29-09-2020 08:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51873, to_date('06-10-2020 00:28:31', 'dd-mm-yyyy hh24:mi:ss'), 89213, to_date('06-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51874, to_date('06-10-2020 00:28:46', 'dd-mm-yyyy hh24:mi:ss'), 89212, to_date('06-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51875, to_date('06-10-2020 00:28:57', 'dd-mm-yyyy hh24:mi:ss'), 89211, to_date('06-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51876, to_date('06-10-2020 00:29:10', 'dd-mm-yyyy hh24:mi:ss'), 89210, to_date('06-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51877, to_date('06-10-2020 00:29:23', 'dd-mm-yyyy hh24:mi:ss'), 89209, to_date('06-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51878, to_date('06-10-2020 00:29:36', 'dd-mm-yyyy hh24:mi:ss'), 89208, to_date('06-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
commit;
prompt 1400 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51879, to_date('06-10-2020 00:29:48', 'dd-mm-yyyy hh24:mi:ss'), 89207, to_date('06-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51880, to_date('06-10-2020 00:30:02', 'dd-mm-yyyy hh24:mi:ss'), 89206, to_date('06-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 15:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51881, to_date('06-10-2020 00:30:14', 'dd-mm-yyyy hh24:mi:ss'), 89205, to_date('06-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 15:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51882, to_date('06-10-2020 00:30:35', 'dd-mm-yyyy hh24:mi:ss'), 89204, to_date('06-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 15:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51883, to_date('06-10-2020 00:30:48', 'dd-mm-yyyy hh24:mi:ss'), 89203, to_date('06-10-2020 16:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51884, to_date('06-10-2020 00:31:33', 'dd-mm-yyyy hh24:mi:ss'), 89201, to_date('06-10-2020 16:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51885, to_date('06-10-2020 00:32:00', 'dd-mm-yyyy hh24:mi:ss'), 89202, to_date('06-10-2020 16:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51889, to_date('06-10-2020 09:27:07', 'dd-mm-yyyy hh24:mi:ss'), 89222, to_date('07-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51890, to_date('06-10-2020 09:27:13', 'dd-mm-yyyy hh24:mi:ss'), 89222, to_date('07-10-2020', 'dd-mm-yyyy'), to_date('07-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51891, to_date('06-10-2020 09:27:35', 'dd-mm-yyyy hh24:mi:ss'), 89221, to_date('06-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51892, to_date('06-10-2020 09:27:45', 'dd-mm-yyyy hh24:mi:ss'), 89220, to_date('06-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51893, to_date('06-10-2020 09:27:57', 'dd-mm-yyyy hh24:mi:ss'), 89219, to_date('06-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51894, to_date('06-10-2020 09:28:09', 'dd-mm-yyyy hh24:mi:ss'), 89218, to_date('06-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51895, to_date('06-10-2020 09:28:23', 'dd-mm-yyyy hh24:mi:ss'), 89217, to_date('06-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51896, to_date('06-10-2020 09:29:03', 'dd-mm-yyyy hh24:mi:ss'), 89216, to_date('06-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51897, to_date('06-10-2020 09:29:14', 'dd-mm-yyyy hh24:mi:ss'), 89215, to_date('06-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51898, to_date('06-10-2020 09:29:24', 'dd-mm-yyyy hh24:mi:ss'), 89214, to_date('06-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51899, to_date('06-10-2020 09:29:34', 'dd-mm-yyyy hh24:mi:ss'), 89213, to_date('06-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51900, to_date('06-10-2020 09:29:48', 'dd-mm-yyyy hh24:mi:ss'), 89212, to_date('06-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51901, to_date('06-10-2020 09:30:02', 'dd-mm-yyyy hh24:mi:ss'), 89211, to_date('06-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51902, to_date('06-10-2020 09:30:13', 'dd-mm-yyyy hh24:mi:ss'), 89210, to_date('06-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51903, to_date('06-10-2020 09:30:25', 'dd-mm-yyyy hh24:mi:ss'), 89209, to_date('06-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51904, to_date('06-10-2020 09:30:39', 'dd-mm-yyyy hh24:mi:ss'), 89208, to_date('06-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51905, to_date('06-10-2020 09:30:50', 'dd-mm-yyyy hh24:mi:ss'), 89207, to_date('06-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51906, to_date('06-10-2020 09:31:02', 'dd-mm-yyyy hh24:mi:ss'), 89206, to_date('06-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51907, to_date('06-10-2020 09:31:12', 'dd-mm-yyyy hh24:mi:ss'), 89205, to_date('06-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51909, to_date('06-10-2020 09:31:33', 'dd-mm-yyyy hh24:mi:ss'), 89200, to_date('06-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51910, to_date('06-10-2020 09:31:47', 'dd-mm-yyyy hh24:mi:ss'), 89199, to_date('06-10-2020 14:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52061, to_date('08-10-2020 16:46:17', 'dd-mm-yyyy hh24:mi:ss'), 96725, to_date('09-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52062, to_date('08-10-2020 16:46:32', 'dd-mm-yyyy hh24:mi:ss'), 96724, to_date('09-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52063, to_date('08-10-2020 16:46:53', 'dd-mm-yyyy hh24:mi:ss'), 96724, to_date('09-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52064, to_date('08-10-2020 16:47:04', 'dd-mm-yyyy hh24:mi:ss'), 96723, to_date('09-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52065, to_date('08-10-2020 16:47:11', 'dd-mm-yyyy hh24:mi:ss'), 96723, to_date('09-10-2020', 'dd-mm-yyyy'), to_date('09-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52066, to_date('08-10-2020 16:47:28', 'dd-mm-yyyy hh24:mi:ss'), 96722, to_date('08-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52067, to_date('08-10-2020 16:47:48', 'dd-mm-yyyy hh24:mi:ss'), 96721, to_date('08-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52068, to_date('08-10-2020 16:48:00', 'dd-mm-yyyy hh24:mi:ss'), 96720, to_date('08-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52069, to_date('08-10-2020 16:48:11', 'dd-mm-yyyy hh24:mi:ss'), 96719, to_date('08-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52070, to_date('08-10-2020 16:48:23', 'dd-mm-yyyy hh24:mi:ss'), 96718, to_date('08-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52071, to_date('08-10-2020 16:48:34', 'dd-mm-yyyy hh24:mi:ss'), 96717, to_date('08-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52072, to_date('08-10-2020 16:48:48', 'dd-mm-yyyy hh24:mi:ss'), 96716, to_date('08-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52073, to_date('08-10-2020 16:49:04', 'dd-mm-yyyy hh24:mi:ss'), 96715, to_date('08-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52074, to_date('08-10-2020 16:49:16', 'dd-mm-yyyy hh24:mi:ss'), 96714, to_date('08-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52139, to_date('09-10-2020 17:03:47', 'dd-mm-yyyy hh24:mi:ss'), 110823, to_date('24-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52140, to_date('09-10-2020 17:03:55', 'dd-mm-yyyy hh24:mi:ss'), 110823, to_date('24-10-2020 23:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52141, to_date('09-10-2020 17:04:04', 'dd-mm-yyyy hh24:mi:ss'), 110824, to_date('24-10-2020 23:03:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:03:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52142, to_date('09-10-2020 17:04:14', 'dd-mm-yyyy hh24:mi:ss'), 110824, to_date('24-10-2020 23:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:03:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52143, to_date('09-10-2020 17:04:31', 'dd-mm-yyyy hh24:mi:ss'), 110825, to_date('24-10-2020 23:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:04:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52144, to_date('09-10-2020 17:04:38', 'dd-mm-yyyy hh24:mi:ss'), 110825, to_date('24-10-2020 23:03:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:04:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52145, to_date('09-10-2020 17:04:55', 'dd-mm-yyyy hh24:mi:ss'), 110826, to_date('24-10-2020 23:05:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:05:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52146, to_date('09-10-2020 17:12:50', 'dd-mm-yyyy hh24:mi:ss'), 103446, to_date('10-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52147, to_date('09-10-2020 17:13:14', 'dd-mm-yyyy hh24:mi:ss'), 103445, to_date('10-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52148, to_date('09-10-2020 17:13:25', 'dd-mm-yyyy hh24:mi:ss'), 103445, to_date('10-10-2020', 'dd-mm-yyyy'), to_date('10-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52149, to_date('09-10-2020 17:13:38', 'dd-mm-yyyy hh24:mi:ss'), 103444, to_date('09-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52150, to_date('09-10-2020 17:13:50', 'dd-mm-yyyy hh24:mi:ss'), 103443, to_date('09-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52151, to_date('09-10-2020 17:14:02', 'dd-mm-yyyy hh24:mi:ss'), 103442, to_date('09-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52152, to_date('09-10-2020 17:14:15', 'dd-mm-yyyy hh24:mi:ss'), 103441, to_date('09-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52153, to_date('09-10-2020 17:14:27', 'dd-mm-yyyy hh24:mi:ss'), 103440, to_date('09-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52154, to_date('09-10-2020 17:14:42', 'dd-mm-yyyy hh24:mi:ss'), 103439, to_date('09-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('09-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52239, to_date('12-10-2020 23:49:36', 'dd-mm-yyyy hh24:mi:ss'), 110814, to_date('13-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52240, to_date('12-10-2020 23:49:48', 'dd-mm-yyyy hh24:mi:ss'), 110815, to_date('13-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52241, to_date('12-10-2020 23:50:01', 'dd-mm-yyyy hh24:mi:ss'), 110816, to_date('13-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52242, to_date('12-10-2020 23:50:20', 'dd-mm-yyyy hh24:mi:ss'), 110817, to_date('13-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52326, to_date('13-10-2020 14:25:52', 'dd-mm-yyyy hh24:mi:ss'), 114730, to_date('13-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52327, to_date('13-10-2020 14:26:16', 'dd-mm-yyyy hh24:mi:ss'), 114729, to_date('13-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52328, to_date('13-10-2020 14:26:29', 'dd-mm-yyyy hh24:mi:ss'), 114728, to_date('13-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52329, to_date('13-10-2020 17:13:58', 'dd-mm-yyyy hh24:mi:ss'), 114732, to_date('13-10-2020 20:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52330, to_date('13-10-2020 17:14:16', 'dd-mm-yyyy hh24:mi:ss'), 114733, to_date('13-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52331, to_date('13-10-2020 17:14:24', 'dd-mm-yyyy hh24:mi:ss'), 114733, to_date('13-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52335, to_date('13-10-2020 21:05:04', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('14-10-2020 00:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52336, to_date('13-10-2020 21:05:16', 'dd-mm-yyyy hh24:mi:ss'), 114740, to_date('14-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52337, to_date('13-10-2020 21:05:28', 'dd-mm-yyyy hh24:mi:ss'), 114741, to_date('14-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52377, to_date('15-10-2020 13:46:16', 'dd-mm-yyyy hh24:mi:ss'), 121251, to_date('15-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52378, to_date('15-10-2020 13:46:25', 'dd-mm-yyyy hh24:mi:ss'), 121250, to_date('15-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52379, to_date('15-10-2020 13:46:35', 'dd-mm-yyyy hh24:mi:ss'), 121249, to_date('15-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52380, to_date('15-10-2020 13:46:45', 'dd-mm-yyyy hh24:mi:ss'), 121248, to_date('15-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52381, to_date('15-10-2020 13:46:56', 'dd-mm-yyyy hh24:mi:ss'), 121247, to_date('15-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52382, to_date('15-10-2020 13:47:08', 'dd-mm-yyyy hh24:mi:ss'), 121246, to_date('15-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52383, to_date('15-10-2020 13:47:18', 'dd-mm-yyyy hh24:mi:ss'), 121245, to_date('15-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52384, to_date('15-10-2020 13:47:31', 'dd-mm-yyyy hh24:mi:ss'), 121244, to_date('15-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52385, to_date('15-10-2020 13:47:42', 'dd-mm-yyyy hh24:mi:ss'), 121243, to_date('15-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52386, to_date('15-10-2020 13:47:52', 'dd-mm-yyyy hh24:mi:ss'), 121242, to_date('15-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52387, to_date('15-10-2020 13:48:09', 'dd-mm-yyyy hh24:mi:ss'), 121241, to_date('15-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52388, to_date('15-10-2020 13:48:37', 'dd-mm-yyyy hh24:mi:ss'), 121240, to_date('15-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52389, to_date('15-10-2020 13:49:09', 'dd-mm-yyyy hh24:mi:ss'), 121239, to_date('15-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52390, to_date('15-10-2020 13:49:20', 'dd-mm-yyyy hh24:mi:ss'), 121238, to_date('15-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('15-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52497, to_date('20-10-2020 10:24:34', 'dd-mm-yyyy hh24:mi:ss'), 135425, to_date('20-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52332, to_date('13-10-2020 19:33:11', 'dd-mm-yyyy hh24:mi:ss'), 114736, to_date('13-10-2020 22:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52333, to_date('13-10-2020 19:33:21', 'dd-mm-yyyy hh24:mi:ss'), 114737, to_date('13-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52334, to_date('13-10-2020 19:33:33', 'dd-mm-yyyy hh24:mi:ss'), 114738, to_date('13-10-2020 23:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52513, to_date('21-10-2020 09:25:51', 'dd-mm-yyyy hh24:mi:ss'), 140378, to_date('21-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52514, to_date('21-10-2020 09:26:06', 'dd-mm-yyyy hh24:mi:ss'), 140379, to_date('21-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52515, to_date('21-10-2020 09:27:17', 'dd-mm-yyyy hh24:mi:ss'), 140380, to_date('21-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52654, to_date('26-10-2020 11:27:11', 'dd-mm-yyyy hh24:mi:ss'), 47128, to_date('26-10-2020 13:22:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('31-10-2020 13:22:00', 'dd-mm-yyyy hh24:mi:ss'), 12114);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52657, to_date('26-10-2020 11:28:00', 'dd-mm-yyyy hh24:mi:ss'), 54055, to_date('26-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('31-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 12114);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52675, to_date('26-10-2020 17:13:02', 'dd-mm-yyyy hh24:mi:ss'), 160015, to_date('27-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52676, to_date('26-10-2020 17:13:14', 'dd-mm-yyyy hh24:mi:ss'), 160014, to_date('27-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52677, to_date('26-10-2020 17:13:30', 'dd-mm-yyyy hh24:mi:ss'), 160013, to_date('27-10-2020 10:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 00:01:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52678, to_date('26-10-2020 17:13:45', 'dd-mm-yyyy hh24:mi:ss'), 160012, to_date('27-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52679, to_date('26-10-2020 17:13:52', 'dd-mm-yyyy hh24:mi:ss'), 160012, to_date('27-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52680, to_date('26-10-2020 17:14:05', 'dd-mm-yyyy hh24:mi:ss'), 160011, to_date('27-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
commit;
prompt 1500 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52682, to_date('26-10-2020 17:14:28', 'dd-mm-yyyy hh24:mi:ss'), 160010, to_date('27-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52683, to_date('26-10-2020 17:14:58', 'dd-mm-yyyy hh24:mi:ss'), 160009, to_date('26-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52684, to_date('26-10-2020 17:15:13', 'dd-mm-yyyy hh24:mi:ss'), 160008, to_date('26-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52685, to_date('26-10-2020 17:15:24', 'dd-mm-yyyy hh24:mi:ss'), 160007, to_date('26-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52686, to_date('26-10-2020 17:15:41', 'dd-mm-yyyy hh24:mi:ss'), 160006, to_date('26-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52687, to_date('26-10-2020 17:15:55', 'dd-mm-yyyy hh24:mi:ss'), 160005, to_date('26-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52688, to_date('26-10-2020 17:16:07', 'dd-mm-yyyy hh24:mi:ss'), 160004, to_date('26-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52689, to_date('26-10-2020 17:16:20', 'dd-mm-yyyy hh24:mi:ss'), 160003, to_date('26-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52690, to_date('26-10-2020 17:16:32', 'dd-mm-yyyy hh24:mi:ss'), 160002, to_date('26-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52691, to_date('26-10-2020 18:11:28', 'dd-mm-yyyy hh24:mi:ss'), 160009, to_date('27-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52692, to_date('26-10-2020 18:11:37', 'dd-mm-yyyy hh24:mi:ss'), 160009, to_date('27-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52693, to_date('26-10-2020 18:11:55', 'dd-mm-yyyy hh24:mi:ss'), 160008, to_date('27-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52694, to_date('26-10-2020 18:12:08', 'dd-mm-yyyy hh24:mi:ss'), 160008, to_date('27-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52695, to_date('26-10-2020 18:12:21', 'dd-mm-yyyy hh24:mi:ss'), 160007, to_date('27-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52696, to_date('26-10-2020 18:12:28', 'dd-mm-yyyy hh24:mi:ss'), 160007, to_date('27-10-2020', 'dd-mm-yyyy'), to_date('27-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52697, to_date('26-10-2020 18:12:41', 'dd-mm-yyyy hh24:mi:ss'), 160006, to_date('26-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52698, to_date('26-10-2020 18:12:57', 'dd-mm-yyyy hh24:mi:ss'), 160005, to_date('26-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52200, to_date('12-10-2020 14:23:40', 'dd-mm-yyyy hh24:mi:ss'), 110817, to_date('13-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52201, to_date('12-10-2020 14:24:03', 'dd-mm-yyyy hh24:mi:ss'), 110816, to_date('13-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52202, to_date('12-10-2020 14:24:17', 'dd-mm-yyyy hh24:mi:ss'), 110815, to_date('13-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52203, to_date('12-10-2020 14:24:36', 'dd-mm-yyyy hh24:mi:ss'), 110815, to_date('13-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52204, to_date('12-10-2020 14:25:19', 'dd-mm-yyyy hh24:mi:ss'), 110814, to_date('13-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52205, to_date('12-10-2020 14:25:44', 'dd-mm-yyyy hh24:mi:ss'), 110813, to_date('13-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52206, to_date('12-10-2020 14:25:58', 'dd-mm-yyyy hh24:mi:ss'), 110812, to_date('13-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52207, to_date('12-10-2020 14:26:12', 'dd-mm-yyyy hh24:mi:ss'), 110811, to_date('13-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52208, to_date('12-10-2020 14:26:35', 'dd-mm-yyyy hh24:mi:ss'), 110810, to_date('13-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52209, to_date('12-10-2020 14:26:49', 'dd-mm-yyyy hh24:mi:ss'), 110809, to_date('13-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52210, to_date('12-10-2020 14:27:03', 'dd-mm-yyyy hh24:mi:ss'), 110808, to_date('13-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52211, to_date('12-10-2020 14:27:15', 'dd-mm-yyyy hh24:mi:ss'), 110808, to_date('13-10-2020', 'dd-mm-yyyy'), to_date('13-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52212, to_date('12-10-2020 14:27:28', 'dd-mm-yyyy hh24:mi:ss'), 110807, to_date('12-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52213, to_date('12-10-2020 14:27:44', 'dd-mm-yyyy hh24:mi:ss'), 110806, to_date('12-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52214, to_date('12-10-2020 14:27:59', 'dd-mm-yyyy hh24:mi:ss'), 110805, to_date('12-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52215, to_date('12-10-2020 14:28:20', 'dd-mm-yyyy hh24:mi:ss'), 110804, to_date('12-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52216, to_date('12-10-2020 14:28:34', 'dd-mm-yyyy hh24:mi:ss'), 110803, to_date('12-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52217, to_date('12-10-2020 14:28:52', 'dd-mm-yyyy hh24:mi:ss'), 110802, to_date('12-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52218, to_date('12-10-2020 14:29:25', 'dd-mm-yyyy hh24:mi:ss'), 110801, to_date('12-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52219, to_date('12-10-2020 14:29:44', 'dd-mm-yyyy hh24:mi:ss'), 110799, to_date('12-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52220, to_date('12-10-2020 14:29:57', 'dd-mm-yyyy hh24:mi:ss'), 110800, to_date('12-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52221, to_date('12-10-2020 15:20:12', 'dd-mm-yyyy hh24:mi:ss'), 110799, to_date('12-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52222, to_date('12-10-2020 15:20:23', 'dd-mm-yyyy hh24:mi:ss'), 110799, to_date('12-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52223, to_date('12-10-2020 15:20:35', 'dd-mm-yyyy hh24:mi:ss'), 110800, to_date('12-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52224, to_date('12-10-2020 15:20:44', 'dd-mm-yyyy hh24:mi:ss'), 110800, to_date('12-10-2020 18:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52225, to_date('12-10-2020 15:21:03', 'dd-mm-yyyy hh24:mi:ss'), 110801, to_date('12-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52226, to_date('12-10-2020 17:03:51', 'dd-mm-yyyy hh24:mi:ss'), 110802, to_date('12-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52227, to_date('12-10-2020 17:04:11', 'dd-mm-yyyy hh24:mi:ss'), 110803, to_date('12-10-2020 20:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52228, to_date('12-10-2020 17:04:28', 'dd-mm-yyyy hh24:mi:ss'), 110804, to_date('12-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52229, to_date('12-10-2020 18:18:32', 'dd-mm-yyyy hh24:mi:ss'), 110805, to_date('12-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52230, to_date('12-10-2020 18:18:44', 'dd-mm-yyyy hh24:mi:ss'), 110806, to_date('12-10-2020 21:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52231, to_date('12-10-2020 18:18:57', 'dd-mm-yyyy hh24:mi:ss'), 110807, to_date('12-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('12-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52232, to_date('12-10-2020 19:16:31', 'dd-mm-yyyy hh24:mi:ss'), 110808, to_date('12-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52233, to_date('12-10-2020 19:16:48', 'dd-mm-yyyy hh24:mi:ss'), 110809, to_date('12-10-2020 22:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52234, to_date('12-10-2020 19:17:42', 'dd-mm-yyyy hh24:mi:ss'), 110810, to_date('12-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52235, to_date('12-10-2020 21:55:57', 'dd-mm-yyyy hh24:mi:ss'), 110811, to_date('13-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52236, to_date('12-10-2020 21:56:10', 'dd-mm-yyyy hh24:mi:ss'), 110812, to_date('13-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52237, to_date('12-10-2020 21:56:17', 'dd-mm-yyyy hh24:mi:ss'), 110812, to_date('13-10-2020 01:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52238, to_date('12-10-2020 21:56:32', 'dd-mm-yyyy hh24:mi:ss'), 110813, to_date('13-10-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52319, to_date('13-10-2020 14:22:47', 'dd-mm-yyyy hh24:mi:ss'), 114743, to_date('14-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52320, to_date('13-10-2020 14:23:16', 'dd-mm-yyyy hh24:mi:ss'), 114742, to_date('14-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52321, to_date('13-10-2020 14:23:28', 'dd-mm-yyyy hh24:mi:ss'), 114741, to_date('14-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52322, to_date('13-10-2020 14:23:38', 'dd-mm-yyyy hh24:mi:ss'), 114740, to_date('14-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52323, to_date('13-10-2020 14:23:50', 'dd-mm-yyyy hh24:mi:ss'), 114739, to_date('14-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('14-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52324, to_date('13-10-2020 14:25:26', 'dd-mm-yyyy hh24:mi:ss'), 114732, to_date('13-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52325, to_date('13-10-2020 14:25:39', 'dd-mm-yyyy hh24:mi:ss'), 114731, to_date('13-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('13-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52727, to_date('28-10-2020 15:06:55', 'dd-mm-yyyy hh24:mi:ss'), 172293, to_date('28-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52728, to_date('28-10-2020 15:07:05', 'dd-mm-yyyy hh24:mi:ss'), 172292, to_date('28-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52729, to_date('28-10-2020 15:07:16', 'dd-mm-yyyy hh24:mi:ss'), 172291, to_date('28-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52730, to_date('28-10-2020 15:07:29', 'dd-mm-yyyy hh24:mi:ss'), 172290, to_date('28-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52731, to_date('28-10-2020 15:07:40', 'dd-mm-yyyy hh24:mi:ss'), 172289, to_date('28-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52732, to_date('28-10-2020 15:08:27', 'dd-mm-yyyy hh24:mi:ss'), 172288, to_date('28-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52733, to_date('28-10-2020 15:08:39', 'dd-mm-yyyy hh24:mi:ss'), 172287, to_date('28-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52734, to_date('28-10-2020 15:08:50', 'dd-mm-yyyy hh24:mi:ss'), 172286, to_date('28-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52735, to_date('28-10-2020 15:09:04', 'dd-mm-yyyy hh24:mi:ss'), 172285, to_date('28-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51089, to_date('25-09-2020 09:40:25', 'dd-mm-yyyy hh24:mi:ss'), 50667, to_date('25-09-2020 09:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 06:15:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51090, to_date('25-09-2020 09:41:28', 'dd-mm-yyyy hh24:mi:ss'), 50668, to_date('25-09-2020 09:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 06:17:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51091, to_date('25-09-2020 09:42:34', 'dd-mm-yyyy hh24:mi:ss'), 50670, to_date('25-09-2020 09:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 06:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51092, to_date('25-09-2020 09:43:08', 'dd-mm-yyyy hh24:mi:ss'), 50669, to_date('25-09-2020 09:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 06:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51093, to_date('25-09-2020 09:44:09', 'dd-mm-yyyy hh24:mi:ss'), 54068, to_date('25-09-2020 09:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51094, to_date('25-09-2020 09:45:03', 'dd-mm-yyyy hh24:mi:ss'), 54070, to_date('25-09-2020 09:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 07:01:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51095, to_date('25-09-2020 09:45:39', 'dd-mm-yyyy hh24:mi:ss'), 54080, to_date('25-09-2020 09:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-09-2020 07:04:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51244, to_date('28-09-2020 14:32:13', 'dd-mm-yyyy hh24:mi:ss'), 60133, to_date('29-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51245, to_date('28-09-2020 14:32:22', 'dd-mm-yyyy hh24:mi:ss'), 60133, to_date('29-09-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51246, to_date('28-09-2020 14:32:59', 'dd-mm-yyyy hh24:mi:ss'), 60132, to_date('29-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51247, to_date('28-09-2020 14:33:23', 'dd-mm-yyyy hh24:mi:ss'), 60132, to_date('29-09-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51248, to_date('28-09-2020 14:34:29', 'dd-mm-yyyy hh24:mi:ss'), 60131, to_date('29-09-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51249, to_date('28-09-2020 14:34:49', 'dd-mm-yyyy hh24:mi:ss'), 60130, to_date('29-09-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51250, to_date('28-09-2020 14:35:04', 'dd-mm-yyyy hh24:mi:ss'), 66113, to_date('28-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51251, to_date('28-09-2020 14:35:21', 'dd-mm-yyyy hh24:mi:ss'), 66113, to_date('28-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51252, to_date('28-09-2020 14:35:56', 'dd-mm-yyyy hh24:mi:ss'), 66114, to_date('24-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51253, to_date('28-09-2020 14:36:05', 'dd-mm-yyyy hh24:mi:ss'), 66114, to_date('24-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51254, to_date('28-09-2020 14:36:21', 'dd-mm-yyyy hh24:mi:ss'), 60129, to_date('28-09-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51255, to_date('28-09-2020 14:37:01', 'dd-mm-yyyy hh24:mi:ss'), 60128, to_date('28-09-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51256, to_date('28-09-2020 14:37:15', 'dd-mm-yyyy hh24:mi:ss'), 60127, to_date('28-09-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51257, to_date('28-09-2020 14:37:30', 'dd-mm-yyyy hh24:mi:ss'), 60126, to_date('28-09-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51258, to_date('28-09-2020 14:37:44', 'dd-mm-yyyy hh24:mi:ss'), 60125, to_date('28-09-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51259, to_date('28-09-2020 14:38:15', 'dd-mm-yyyy hh24:mi:ss'), 60124, to_date('28-09-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51260, to_date('28-09-2020 14:38:27', 'dd-mm-yyyy hh24:mi:ss'), 60123, to_date('28-09-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51261, to_date('28-09-2020 14:38:40', 'dd-mm-yyyy hh24:mi:ss'), 60122, to_date('28-09-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51262, to_date('28-09-2020 14:39:15', 'dd-mm-yyyy hh24:mi:ss'), 66115, to_date('24-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51263, to_date('28-09-2020 14:39:23', 'dd-mm-yyyy hh24:mi:ss'), 66115, to_date('24-10-2020 23:29:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51264, to_date('28-09-2020 14:39:34', 'dd-mm-yyyy hh24:mi:ss'), 66116, to_date('24-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
commit;
prompt 1600 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51265, to_date('28-09-2020 14:39:49', 'dd-mm-yyyy hh24:mi:ss'), 66116, to_date('24-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51266, to_date('28-09-2020 14:40:01', 'dd-mm-yyyy hh24:mi:ss'), 66118, to_date('24-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51267, to_date('28-09-2020 14:40:08', 'dd-mm-yyyy hh24:mi:ss'), 66118, to_date('24-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51268, to_date('28-09-2020 14:40:20', 'dd-mm-yyyy hh24:mi:ss'), 66119, to_date('29-09-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51269, to_date('28-09-2020 14:40:26', 'dd-mm-yyyy hh24:mi:ss'), 66119, to_date('29-09-2020 23:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51270, to_date('28-09-2020 14:40:38', 'dd-mm-yyyy hh24:mi:ss'), 66110, to_date('24-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51271, to_date('28-09-2020 14:40:51', 'dd-mm-yyyy hh24:mi:ss'), 66112, to_date('24-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51272, to_date('28-09-2020 14:40:58', 'dd-mm-yyyy hh24:mi:ss'), 66112, to_date('24-10-2020 23:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51273, to_date('28-09-2020 14:41:08', 'dd-mm-yyyy hh24:mi:ss'), 66098, to_date('24-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51274, to_date('28-09-2020 14:41:15', 'dd-mm-yyyy hh24:mi:ss'), 66098, to_date('24-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51275, to_date('28-09-2020 14:41:25', 'dd-mm-yyyy hh24:mi:ss'), 66111, to_date('24-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51276, to_date('28-09-2020 14:41:31', 'dd-mm-yyyy hh24:mi:ss'), 66111, to_date('24-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51277, to_date('28-09-2020 14:41:41', 'dd-mm-yyyy hh24:mi:ss'), 66099, to_date('24-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51278, to_date('28-09-2020 14:41:49', 'dd-mm-yyyy hh24:mi:ss'), 66099, to_date('24-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51279, to_date('28-09-2020 14:42:01', 'dd-mm-yyyy hh24:mi:ss'), 66100, to_date('24-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51280, to_date('28-09-2020 14:42:16', 'dd-mm-yyyy hh24:mi:ss'), 66100, to_date('24-10-2020 23:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51281, to_date('28-09-2020 14:42:29', 'dd-mm-yyyy hh24:mi:ss'), 66101, to_date('24-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52726, to_date('28-10-2020 15:06:44', 'dd-mm-yyyy hh24:mi:ss'), 172294, to_date('28-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52441, to_date('19-10-2020 09:35:17', 'dd-mm-yyyy hh24:mi:ss'), 130469, to_date('19-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52442, to_date('19-10-2020 09:35:27', 'dd-mm-yyyy hh24:mi:ss'), 130468, to_date('19-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52443, to_date('19-10-2020 09:35:38', 'dd-mm-yyyy hh24:mi:ss'), 130467, to_date('19-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52444, to_date('19-10-2020 09:35:50', 'dd-mm-yyyy hh24:mi:ss'), 130466, to_date('19-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52445, to_date('19-10-2020 09:36:01', 'dd-mm-yyyy hh24:mi:ss'), 130465, to_date('19-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52446, to_date('19-10-2020 09:36:12', 'dd-mm-yyyy hh24:mi:ss'), 130464, to_date('19-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52447, to_date('19-10-2020 09:36:23', 'dd-mm-yyyy hh24:mi:ss'), 130463, to_date('19-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52448, to_date('19-10-2020 09:36:34', 'dd-mm-yyyy hh24:mi:ss'), 130462, to_date('19-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52449, to_date('19-10-2020 09:36:51', 'dd-mm-yyyy hh24:mi:ss'), 130461, to_date('19-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52450, to_date('19-10-2020 09:37:04', 'dd-mm-yyyy hh24:mi:ss'), 130460, to_date('19-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52451, to_date('19-10-2020 09:37:25', 'dd-mm-yyyy hh24:mi:ss'), 130458, to_date('19-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52452, to_date('19-10-2020 09:37:37', 'dd-mm-yyyy hh24:mi:ss'), 130457, to_date('19-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52453, to_date('19-10-2020 09:37:50', 'dd-mm-yyyy hh24:mi:ss'), 130456, to_date('19-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52454, to_date('19-10-2020 09:38:12', 'dd-mm-yyyy hh24:mi:ss'), 130454, to_date('19-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52455, to_date('19-10-2020 09:38:22', 'dd-mm-yyyy hh24:mi:ss'), 130453, to_date('19-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 17:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52456, to_date('19-10-2020 09:38:33', 'dd-mm-yyyy hh24:mi:ss'), 130452, to_date('19-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('19-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52494, to_date('20-10-2020 06:50:41', 'dd-mm-yyyy hh24:mi:ss'), 135401, to_date('20-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52495, to_date('20-10-2020 06:50:58', 'dd-mm-yyyy hh24:mi:ss'), 135402, to_date('20-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52496, to_date('20-10-2020 06:51:15', 'dd-mm-yyyy hh24:mi:ss'), 135403, to_date('20-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52506, to_date('20-10-2020 16:36:25', 'dd-mm-yyyy hh24:mi:ss'), 135423, to_date('20-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('20-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52507, to_date('20-10-2020 20:57:22', 'dd-mm-yyyy hh24:mi:ss'), 140374, to_date('21-10-2020', 'dd-mm-yyyy'), to_date('21-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52508, to_date('20-10-2020 20:57:36', 'dd-mm-yyyy hh24:mi:ss'), 140375, to_date('21-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52509, to_date('20-10-2020 20:57:44', 'dd-mm-yyyy hh24:mi:ss'), 140375, to_date('21-10-2020 00:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52510, to_date('20-10-2020 20:58:01', 'dd-mm-yyyy hh24:mi:ss'), 140376, to_date('21-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52511, to_date('20-10-2020 20:58:08', 'dd-mm-yyyy hh24:mi:ss'), 140376, to_date('21-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52516, to_date('21-10-2020 13:15:55', 'dd-mm-yyyy hh24:mi:ss'), 140402, to_date('21-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52517, to_date('21-10-2020 13:16:04', 'dd-mm-yyyy hh24:mi:ss'), 140401, to_date('21-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52518, to_date('21-10-2020 13:16:14', 'dd-mm-yyyy hh24:mi:ss'), 140400, to_date('21-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52519, to_date('21-10-2020 13:16:24', 'dd-mm-yyyy hh24:mi:ss'), 140399, to_date('21-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52520, to_date('21-10-2020 13:16:35', 'dd-mm-yyyy hh24:mi:ss'), 140398, to_date('21-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52521, to_date('21-10-2020 13:16:50', 'dd-mm-yyyy hh24:mi:ss'), 140397, to_date('21-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52522, to_date('21-10-2020 13:17:11', 'dd-mm-yyyy hh24:mi:ss'), 140395, to_date('21-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52523, to_date('21-10-2020 13:17:21', 'dd-mm-yyyy hh24:mi:ss'), 140394, to_date('21-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52524, to_date('21-10-2020 13:17:33', 'dd-mm-yyyy hh24:mi:ss'), 140393, to_date('21-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52525, to_date('21-10-2020 13:17:45', 'dd-mm-yyyy hh24:mi:ss'), 140392, to_date('21-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52526, to_date('21-10-2020 13:17:59', 'dd-mm-yyyy hh24:mi:ss'), 140391, to_date('21-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('21-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52539, to_date('22-10-2020 06:13:54', 'dd-mm-yyyy hh24:mi:ss'), 151292, to_date('22-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52540, to_date('22-10-2020 06:14:04', 'dd-mm-yyyy hh24:mi:ss'), 151293, to_date('22-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52541, to_date('22-10-2020 07:44:37', 'dd-mm-yyyy hh24:mi:ss'), 151294, to_date('22-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 13:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52542, to_date('22-10-2020 07:44:51', 'dd-mm-yyyy hh24:mi:ss'), 151295, to_date('22-10-2020 12:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 14:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52784, to_date('30-10-2020 08:14:08', 'dd-mm-yyyy hh24:mi:ss'), 181576, to_date('30-10-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52785, to_date('30-10-2020 08:14:34', 'dd-mm-yyyy hh24:mi:ss'), 181577, to_date('30-10-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52786, to_date('30-10-2020 08:14:51', 'dd-mm-yyyy hh24:mi:ss'), 181577, to_date('30-10-2020 11:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52787, to_date('30-10-2020 08:15:04', 'dd-mm-yyyy hh24:mi:ss'), 181578, to_date('30-10-2020 11:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51282, to_date('28-09-2020 14:42:36', 'dd-mm-yyyy hh24:mi:ss'), 66101, to_date('24-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51283, to_date('28-09-2020 14:42:47', 'dd-mm-yyyy hh24:mi:ss'), 66102, to_date('24-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51284, to_date('28-09-2020 14:42:54', 'dd-mm-yyyy hh24:mi:ss'), 66102, to_date('24-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51285, to_date('28-09-2020 14:43:05', 'dd-mm-yyyy hh24:mi:ss'), 66103, to_date('24-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51286, to_date('28-09-2020 14:43:18', 'dd-mm-yyyy hh24:mi:ss'), 66103, to_date('24-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51287, to_date('28-09-2020 14:43:30', 'dd-mm-yyyy hh24:mi:ss'), 66104, to_date('24-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51288, to_date('28-09-2020 14:43:36', 'dd-mm-yyyy hh24:mi:ss'), 66104, to_date('24-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:44:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51289, to_date('28-09-2020 14:43:46', 'dd-mm-yyyy hh24:mi:ss'), 66105, to_date('24-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51290, to_date('28-09-2020 14:44:00', 'dd-mm-yyyy hh24:mi:ss'), 66105, to_date('24-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51291, to_date('28-09-2020 14:44:13', 'dd-mm-yyyy hh24:mi:ss'), 66106, to_date('24-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51292, to_date('28-09-2020 14:44:19', 'dd-mm-yyyy hh24:mi:ss'), 66106, to_date('24-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51293, to_date('28-09-2020 14:44:57', 'dd-mm-yyyy hh24:mi:ss'), 66107, to_date('24-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51294, to_date('28-09-2020 14:45:06', 'dd-mm-yyyy hh24:mi:ss'), 66107, to_date('24-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51295, to_date('28-09-2020 14:45:18', 'dd-mm-yyyy hh24:mi:ss'), 66108, to_date('24-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51296, to_date('28-09-2020 14:45:30', 'dd-mm-yyyy hh24:mi:ss'), 66108, to_date('24-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:48:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51297, to_date('28-09-2020 14:45:46', 'dd-mm-yyyy hh24:mi:ss'), 66117, to_date('24-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51298, to_date('28-09-2020 14:45:52', 'dd-mm-yyyy hh24:mi:ss'), 66117, to_date('24-10-2020 23:32:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:33:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51299, to_date('28-09-2020 14:48:36', 'dd-mm-yyyy hh24:mi:ss'), 60122, to_date('28-09-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('28-09-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51376, to_date('29-09-2020 09:55:16', 'dd-mm-yyyy hh24:mi:ss'), 66111, to_date('29-09-2020 09:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:37:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51378, to_date('29-09-2020 10:00:16', 'dd-mm-yyyy hh24:mi:ss'), 66099, to_date('29-09-2020 10:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51381, to_date('29-09-2020 10:03:47', 'dd-mm-yyyy hh24:mi:ss'), 66104, to_date('29-09-2020 10:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51385, to_date('29-09-2020 10:06:45', 'dd-mm-yyyy hh24:mi:ss'), 66104, to_date('29-09-2020 10:07:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 10:04:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51388, to_date('29-09-2020 10:11:53', 'dd-mm-yyyy hh24:mi:ss'), 66106, to_date('29-09-2020 10:12:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51390, to_date('29-09-2020 10:12:39', 'dd-mm-yyyy hh24:mi:ss'), 66106, to_date('29-09-2020 10:13:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 10:12:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51392, to_date('29-09-2020 10:15:12', 'dd-mm-yyyy hh24:mi:ss'), 66107, to_date('29-09-2020 10:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:45:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51393, to_date('29-09-2020 10:18:43', 'dd-mm-yyyy hh24:mi:ss'), 60149, to_date('29-09-2020 10:19:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:42:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51394, to_date('29-09-2020 10:20:15', 'dd-mm-yyyy hh24:mi:ss'), 60149, to_date('29-09-2020 10:21:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 10:19:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51395, to_date('29-09-2020 10:22:44', 'dd-mm-yyyy hh24:mi:ss'), 60150, to_date('29-09-2020 10:23:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:43:00', 'dd-mm-yyyy hh24:mi:ss'), 12140);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51515, to_date('01-10-2020 07:11:26', 'dd-mm-yyyy hh24:mi:ss'), 76350, to_date('01-10-2020 10:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51516, to_date('01-10-2020 07:11:44', 'dd-mm-yyyy hh24:mi:ss'), 76351, to_date('01-10-2020 10:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51517, to_date('01-10-2020 07:24:56', 'dd-mm-yyyy hh24:mi:ss'), 79883, to_date('02-10-2020', 'dd-mm-yyyy'), to_date('30-09-2020', 'dd-mm-yyyy'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51518, to_date('01-10-2020 07:25:07', 'dd-mm-yyyy hh24:mi:ss'), 79883, to_date('02-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020', 'dd-mm-yyyy'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51519, to_date('01-10-2020 07:25:23', 'dd-mm-yyyy hh24:mi:ss'), 79890, to_date('02-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51520, to_date('01-10-2020 07:25:30', 'dd-mm-yyyy hh24:mi:ss'), 79890, to_date('02-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51521, to_date('01-10-2020 07:25:43', 'dd-mm-yyyy hh24:mi:ss'), 79889, to_date('02-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51522, to_date('01-10-2020 07:25:49', 'dd-mm-yyyy hh24:mi:ss'), 79889, to_date('02-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51523, to_date('01-10-2020 07:26:01', 'dd-mm-yyyy hh24:mi:ss'), 79888, to_date('02-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('29-09-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51524, to_date('01-10-2020 07:26:07', 'dd-mm-yyyy hh24:mi:ss'), 79888, to_date('02-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
commit;
prompt 1700 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51525, to_date('01-10-2020 07:26:32', 'dd-mm-yyyy hh24:mi:ss'), 79885, to_date('02-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51526, to_date('01-10-2020 07:26:38', 'dd-mm-yyyy hh24:mi:ss'), 79885, to_date('02-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51527, to_date('01-10-2020 07:26:51', 'dd-mm-yyyy hh24:mi:ss'), 79884, to_date('02-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51528, to_date('01-10-2020 07:26:56', 'dd-mm-yyyy hh24:mi:ss'), 79884, to_date('02-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51529, to_date('01-10-2020 07:27:13', 'dd-mm-yyyy hh24:mi:ss'), 79887, to_date('02-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51530, to_date('01-10-2020 07:27:22', 'dd-mm-yyyy hh24:mi:ss'), 79887, to_date('02-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51531, to_date('01-10-2020 07:27:38', 'dd-mm-yyyy hh24:mi:ss'), 79886, to_date('02-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-09-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51532, to_date('01-10-2020 07:27:44', 'dd-mm-yyyy hh24:mi:ss'), 79886, to_date('02-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51576, to_date('02-10-2020 07:05:25', 'dd-mm-yyyy hh24:mi:ss'), 79892, to_date('26-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51577, to_date('02-10-2020 07:05:31', 'dd-mm-yyyy hh24:mi:ss'), 79892, to_date('26-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51578, to_date('02-10-2020 07:05:41', 'dd-mm-yyyy hh24:mi:ss'), 79891, to_date('26-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51579, to_date('02-10-2020 07:05:47', 'dd-mm-yyyy hh24:mi:ss'), 79891, to_date('26-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51580, to_date('02-10-2020 07:05:57', 'dd-mm-yyyy hh24:mi:ss'), 79894, to_date('26-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51581, to_date('02-10-2020 07:06:03', 'dd-mm-yyyy hh24:mi:ss'), 79894, to_date('26-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51582, to_date('02-10-2020 07:06:15', 'dd-mm-yyyy hh24:mi:ss'), 79893, to_date('26-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('01-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51583, to_date('02-10-2020 07:06:23', 'dd-mm-yyyy hh24:mi:ss'), 79893, to_date('26-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51603, to_date('05-10-2020 08:52:46', 'dd-mm-yyyy hh24:mi:ss'), 79889, to_date('05-10-2020 08:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('02-10-2020 23:57:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52001, to_date('08-10-2020 06:10:39', 'dd-mm-yyyy hh24:mi:ss'), 5287, to_date('08-10-2020 06:12:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 15:05:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52002, to_date('08-10-2020 06:11:58', 'dd-mm-yyyy hh24:mi:ss'), 7977, to_date('08-10-2020 06:13:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52003, to_date('08-10-2020 06:13:18', 'dd-mm-yyyy hh24:mi:ss'), 7973, to_date('08-10-2020 06:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 13:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52005, to_date('08-10-2020 06:14:37', 'dd-mm-yyyy hh24:mi:ss'), 7975, to_date('08-10-2020 06:19:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52016, to_date('08-10-2020 07:56:42', 'dd-mm-yyyy hh24:mi:ss'), 96696, to_date('08-10-2020 11:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52017, to_date('08-10-2020 07:56:58', 'dd-mm-yyyy hh24:mi:ss'), 96697, to_date('08-10-2020 11:15:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 12:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52018, to_date('08-10-2020 07:57:11', 'dd-mm-yyyy hh24:mi:ss'), 96698, to_date('08-10-2020 11:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 12:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52019, to_date('08-10-2020 07:57:25', 'dd-mm-yyyy hh24:mi:ss'), 96699, to_date('08-10-2020 11:45:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 13:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52024, to_date('08-10-2020 09:53:04', 'dd-mm-yyyy hh24:mi:ss'), 10427, to_date('08-10-2020 09:54:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:55:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52025, to_date('08-10-2020 09:54:33', 'dd-mm-yyyy hh24:mi:ss'), 10426, to_date('08-10-2020 09:56:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:54:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52026, to_date('08-10-2020 09:56:04', 'dd-mm-yyyy hh24:mi:ss'), 10422, to_date('08-10-2020 09:57:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:58:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52027, to_date('08-10-2020 09:59:20', 'dd-mm-yyyy hh24:mi:ss'), 10430, to_date('08-10-2020 10:01:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:51:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52028, to_date('08-10-2020 10:01:11', 'dd-mm-yyyy hh24:mi:ss'), 7985, to_date('08-10-2020 10:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52029, to_date('08-10-2020 10:10:50', 'dd-mm-yyyy hh24:mi:ss'), 7991, to_date('08-10-2020 10:12:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52030, to_date('08-10-2020 10:12:07', 'dd-mm-yyyy hh24:mi:ss'), 7982, to_date('08-10-2020 10:13:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52031, to_date('08-10-2020 10:15:19', 'dd-mm-yyyy hh24:mi:ss'), 7997, to_date('08-10-2020 10:17:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:31:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52044, to_date('08-10-2020 11:59:10', 'dd-mm-yyyy hh24:mi:ss'), 10417, to_date('08-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:23:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52045, to_date('08-10-2020 12:00:40', 'dd-mm-yyyy hh24:mi:ss'), 10424, to_date('08-10-2020 12:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:56:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52046, to_date('08-10-2020 12:01:50', 'dd-mm-yyyy hh24:mi:ss'), 10419, to_date('08-10-2020 12:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:25:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52050, to_date('08-10-2020 12:32:45', 'dd-mm-yyyy hh24:mi:ss'), 10433, to_date('08-10-2020 12:34:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52051, to_date('08-10-2020 12:33:57', 'dd-mm-yyyy hh24:mi:ss'), 7986, to_date('08-10-2020 12:35:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:46:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52053, to_date('08-10-2020 12:35:19', 'dd-mm-yyyy hh24:mi:ss'), 10442, to_date('08-10-2020 12:37:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:36:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52055, to_date('08-10-2020 12:36:33', 'dd-mm-yyyy hh24:mi:ss'), 10441, to_date('08-10-2020 12:38:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:39:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52056, to_date('08-10-2020 12:38:03', 'dd-mm-yyyy hh24:mi:ss'), 10440, to_date('08-10-2020 12:39:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:38:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52057, to_date('08-10-2020 12:59:51', 'dd-mm-yyyy hh24:mi:ss'), 7988, to_date('08-10-2020 13:02:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:41:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52058, to_date('08-10-2020 13:01:20', 'dd-mm-yyyy hh24:mi:ss'), 7976, to_date('08-10-2020 13:04:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:52:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52059, to_date('08-10-2020 13:02:30', 'dd-mm-yyyy hh24:mi:ss'), 7974, to_date('08-10-2020 13:06:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('30-10-2020 23:53:00', 'dd-mm-yyyy hh24:mi:ss'), 14506);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52060, to_date('08-10-2020 16:46:05', 'dd-mm-yyyy hh24:mi:ss'), 96725, to_date('09-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('08-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52549, to_date('22-10-2020 14:16:09', 'dd-mm-yyyy hh24:mi:ss'), 151307, to_date('22-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52550, to_date('22-10-2020 14:16:15', 'dd-mm-yyyy hh24:mi:ss'), 151307, to_date('22-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 17:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52551, to_date('22-10-2020 14:16:42', 'dd-mm-yyyy hh24:mi:ss'), 151308, to_date('22-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52552, to_date('22-10-2020 14:17:05', 'dd-mm-yyyy hh24:mi:ss'), 151309, to_date('22-10-2020 18:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52553, to_date('22-10-2020 14:17:28', 'dd-mm-yyyy hh24:mi:ss'), 151310, to_date('22-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52554, to_date('22-10-2020 14:17:39', 'dd-mm-yyyy hh24:mi:ss'), 151310, to_date('22-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 18:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52555, to_date('22-10-2020 16:36:48', 'dd-mm-yyyy hh24:mi:ss'), 151325, to_date('23-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52556, to_date('22-10-2020 16:36:54', 'dd-mm-yyyy hh24:mi:ss'), 151325, to_date('23-10-2020 00:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:59:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52557, to_date('22-10-2020 16:37:06', 'dd-mm-yyyy hh24:mi:ss'), 151324, to_date('23-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52558, to_date('22-10-2020 16:37:11', 'dd-mm-yyyy hh24:mi:ss'), 151324, to_date('23-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52559, to_date('22-10-2020 16:37:29', 'dd-mm-yyyy hh24:mi:ss'), 151323, to_date('23-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52560, to_date('22-10-2020 16:37:36', 'dd-mm-yyyy hh24:mi:ss'), 151323, to_date('23-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52561, to_date('22-10-2020 16:37:50', 'dd-mm-yyyy hh24:mi:ss'), 151322, to_date('23-10-2020', 'dd-mm-yyyy'), to_date('22-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52562, to_date('22-10-2020 16:38:02', 'dd-mm-yyyy hh24:mi:ss'), 151321, to_date('22-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52563, to_date('22-10-2020 16:38:15', 'dd-mm-yyyy hh24:mi:ss'), 151320, to_date('22-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52564, to_date('22-10-2020 16:38:27', 'dd-mm-yyyy hh24:mi:ss'), 151319, to_date('22-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52565, to_date('22-10-2020 16:38:38', 'dd-mm-yyyy hh24:mi:ss'), 151318, to_date('22-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52566, to_date('22-10-2020 16:38:53', 'dd-mm-yyyy hh24:mi:ss'), 151317, to_date('22-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52567, to_date('22-10-2020 16:39:05', 'dd-mm-yyyy hh24:mi:ss'), 151316, to_date('22-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52568, to_date('22-10-2020 16:39:16', 'dd-mm-yyyy hh24:mi:ss'), 151315, to_date('22-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52569, to_date('22-10-2020 16:39:35', 'dd-mm-yyyy hh24:mi:ss'), 151314, to_date('22-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52570, to_date('22-10-2020 18:41:50', 'dd-mm-yyyy hh24:mi:ss'), 151325, to_date('23-10-2020 01:59:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 00:59:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52571, to_date('22-10-2020 18:42:07', 'dd-mm-yyyy hh24:mi:ss'), 151324, to_date('23-10-2020 01:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52572, to_date('22-10-2020 18:42:21', 'dd-mm-yyyy hh24:mi:ss'), 151323, to_date('23-10-2020 01:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52573, to_date('22-10-2020 18:42:34', 'dd-mm-yyyy hh24:mi:ss'), 151322, to_date('23-10-2020 01:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52574, to_date('22-10-2020 18:42:47', 'dd-mm-yyyy hh24:mi:ss'), 151321, to_date('23-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52575, to_date('22-10-2020 18:43:01', 'dd-mm-yyyy hh24:mi:ss'), 151320, to_date('23-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52576, to_date('22-10-2020 18:43:14', 'dd-mm-yyyy hh24:mi:ss'), 151319, to_date('23-10-2020', 'dd-mm-yyyy'), to_date('22-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52577, to_date('22-10-2020 18:43:26', 'dd-mm-yyyy hh24:mi:ss'), 151318, to_date('22-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52578, to_date('22-10-2020 18:43:38', 'dd-mm-yyyy hh24:mi:ss'), 151317, to_date('22-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52579, to_date('22-10-2020 19:31:05', 'dd-mm-yyyy hh24:mi:ss'), 151317, to_date('22-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52580, to_date('22-10-2020 19:31:28', 'dd-mm-yyyy hh24:mi:ss'), 151318, to_date('22-10-2020 23:10:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52581, to_date('22-10-2020 20:06:36', 'dd-mm-yyyy hh24:mi:ss'), 151319, to_date('22-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020', 'dd-mm-yyyy'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52582, to_date('22-10-2020 20:07:01', 'dd-mm-yyyy hh24:mi:ss'), 151320, to_date('22-10-2020 23:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 00:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52583, to_date('22-10-2020 20:07:17', 'dd-mm-yyyy hh24:mi:ss'), 151321, to_date('22-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 00:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52586, to_date('23-10-2020 08:34:40', 'dd-mm-yyyy hh24:mi:ss'), 157573, to_date('23-10-2020 11:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 12:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52587, to_date('23-10-2020 10:19:32', 'dd-mm-yyyy hh24:mi:ss'), 47128, to_date('23-10-2020 13:22:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('24-10-2020 23:50:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52588, to_date('23-10-2020 10:20:53', 'dd-mm-yyyy hh24:mi:ss'), 54055, to_date('23-10-2020 13:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('25-10-2020 23:47:00', 'dd-mm-yyyy hh24:mi:ss'), 14575);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52589, to_date('23-10-2020 11:13:48', 'dd-mm-yyyy hh24:mi:ss'), 157608, to_date('26-10-2020 10:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52590, to_date('23-10-2020 11:14:32', 'dd-mm-yyyy hh24:mi:ss'), 157607, to_date('26-10-2020 10:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52591, to_date('23-10-2020 11:14:48', 'dd-mm-yyyy hh24:mi:ss'), 157606, to_date('26-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52592, to_date('23-10-2020 11:15:07', 'dd-mm-yyyy hh24:mi:ss'), 157605, to_date('26-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52593, to_date('23-10-2020 11:15:37', 'dd-mm-yyyy hh24:mi:ss'), 157604, to_date('23-10-2020 23:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52594, to_date('23-10-2020 11:15:47', 'dd-mm-yyyy hh24:mi:ss'), 157603, to_date('23-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52595, to_date('23-10-2020 11:15:56', 'dd-mm-yyyy hh24:mi:ss'), 157602, to_date('23-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52596, to_date('23-10-2020 11:18:58', 'dd-mm-yyyy hh24:mi:ss'), 157601, to_date('23-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52597, to_date('23-10-2020 11:19:09', 'dd-mm-yyyy hh24:mi:ss'), 157600, to_date('23-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52598, to_date('23-10-2020 11:19:22', 'dd-mm-yyyy hh24:mi:ss'), 157599, to_date('23-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52599, to_date('23-10-2020 11:19:34', 'dd-mm-yyyy hh24:mi:ss'), 157598, to_date('23-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52600, to_date('23-10-2020 11:19:46', 'dd-mm-yyyy hh24:mi:ss'), 157597, to_date('23-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52601, to_date('23-10-2020 11:20:00', 'dd-mm-yyyy hh24:mi:ss'), 157596, to_date('23-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52602, to_date('23-10-2020 11:20:14', 'dd-mm-yyyy hh24:mi:ss'), 157595, to_date('23-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52603, to_date('23-10-2020 11:20:28', 'dd-mm-yyyy hh24:mi:ss'), 157594, to_date('23-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52604, to_date('23-10-2020 11:20:39', 'dd-mm-yyyy hh24:mi:ss'), 157593, to_date('23-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52605, to_date('23-10-2020 11:20:55', 'dd-mm-yyyy hh24:mi:ss'), 157592, to_date('23-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('23-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 14639);
commit;
prompt 1800 records committed...
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52634, to_date('26-10-2020 06:24:52', 'dd-mm-yyyy hh24:mi:ss'), 165133, to_date('26-10-2020 06:52:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 08:52:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52636, to_date('26-10-2020 06:39:35', 'dd-mm-yyyy hh24:mi:ss'), 165133, to_date('26-10-2020 06:42:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 06:52:00', 'dd-mm-yyyy hh24:mi:ss'), 12596);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52642, to_date('26-10-2020 10:49:52', 'dd-mm-yyyy hh24:mi:ss'), 159988, to_date('26-10-2020 14:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('26-10-2020 14:30:00', 'dd-mm-yyyy hh24:mi:ss'), 12547);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52701, to_date('27-10-2020 14:20:37', 'dd-mm-yyyy hh24:mi:ss'), 165131, to_date('28-10-2020 10:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52702, to_date('27-10-2020 14:20:52', 'dd-mm-yyyy hh24:mi:ss'), 165130, to_date('28-10-2020 09:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52703, to_date('27-10-2020 14:21:08', 'dd-mm-yyyy hh24:mi:ss'), 165129, to_date('28-10-2020 09:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52704, to_date('27-10-2020 14:21:22', 'dd-mm-yyyy hh24:mi:ss'), 165128, to_date('28-10-2020 09:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52705, to_date('27-10-2020 14:21:59', 'dd-mm-yyyy hh24:mi:ss'), 165127, to_date('27-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52706, to_date('27-10-2020 14:22:11', 'dd-mm-yyyy hh24:mi:ss'), 165126, to_date('27-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52707, to_date('27-10-2020 14:22:22', 'dd-mm-yyyy hh24:mi:ss'), 165125, to_date('27-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52708, to_date('27-10-2020 14:22:36', 'dd-mm-yyyy hh24:mi:ss'), 165124, to_date('27-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52709, to_date('27-10-2020 14:23:44', 'dd-mm-yyyy hh24:mi:ss'), 165123, to_date('27-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52710, to_date('27-10-2020 14:23:56', 'dd-mm-yyyy hh24:mi:ss'), 165122, to_date('27-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52711, to_date('27-10-2020 17:58:23', 'dd-mm-yyyy hh24:mi:ss'), 165127, to_date('27-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52712, to_date('27-10-2020 17:58:52', 'dd-mm-yyyy hh24:mi:ss'), 165126, to_date('27-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52713, to_date('27-10-2020 17:59:05', 'dd-mm-yyyy hh24:mi:ss'), 165125, to_date('27-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('27-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51858, to_date('06-10-2020 00:24:32', 'dd-mm-yyyy hh24:mi:ss'), 89222, to_date('06-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51859, to_date('06-10-2020 00:24:45', 'dd-mm-yyyy hh24:mi:ss'), 89221, to_date('06-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51860, to_date('06-10-2020 00:25:13', 'dd-mm-yyyy hh24:mi:ss'), 89220, to_date('06-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51861, to_date('06-10-2020 00:25:26', 'dd-mm-yyyy hh24:mi:ss'), 89219, to_date('06-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51862, to_date('06-10-2020 00:25:39', 'dd-mm-yyyy hh24:mi:ss'), 89222, to_date('06-10-2020 23:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51863, to_date('06-10-2020 00:25:52', 'dd-mm-yyyy hh24:mi:ss'), 89221, to_date('06-10-2020 22:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51864, to_date('06-10-2020 00:26:06', 'dd-mm-yyyy hh24:mi:ss'), 89220, to_date('06-10-2020 22:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51865, to_date('06-10-2020 00:26:21', 'dd-mm-yyyy hh24:mi:ss'), 89219, to_date('06-10-2020 22:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51866, to_date('06-10-2020 00:26:56', 'dd-mm-yyyy hh24:mi:ss'), 89218, to_date('06-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51867, to_date('06-10-2020 00:27:05', 'dd-mm-yyyy hh24:mi:ss'), 89218, to_date('06-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 23:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51868, to_date('06-10-2020 00:27:23', 'dd-mm-yyyy hh24:mi:ss'), 89218, to_date('06-10-2020 21:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51869, to_date('06-10-2020 00:27:41', 'dd-mm-yyyy hh24:mi:ss'), 89217, to_date('06-10-2020 21:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51870, to_date('06-10-2020 00:27:53', 'dd-mm-yyyy hh24:mi:ss'), 89216, to_date('06-10-2020 21:00:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 19:00:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51871, to_date('06-10-2020 00:28:05', 'dd-mm-yyyy hh24:mi:ss'), 89215, to_date('06-10-2020 20:40:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (51872, to_date('06-10-2020 00:28:17', 'dd-mm-yyyy hh24:mi:ss'), 89214, to_date('06-10-2020 20:20:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('06-10-2020 18:20:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
insert into ZZ_DEPARTDATE (dd_ref, moddate, lrou_ref, newdepart, olddepart, mod_userno)
values (52548, to_date('22-10-2020 14:15:50', 'dd-mm-yyyy hh24:mi:ss'), 151306, to_date('22-10-2020 17:30:00', 'dd-mm-yyyy hh24:mi:ss'), to_date('22-10-2020 17:40:00', 'dd-mm-yyyy hh24:mi:ss'), 15233);
commit;
prompt 1832 records loaded
set feedback on
set define on
prompt Done.

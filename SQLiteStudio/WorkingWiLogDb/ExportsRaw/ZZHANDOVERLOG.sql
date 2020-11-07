prompt PL/SQL Developer import file
prompt Created on Friday, October 30, 2020 by c067460
set feedback off
set define off
prompt Creating ZZHANDOVERLOG...
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
comment on table ZZHANDOVERLOG
  is 'Witron on-site support pass downs';
comment on column ZZHANDOVERLOG.zzhol_ref
  is 'Ref';
comment on column ZZHANDOVERLOG.zzhol_state
  is '0 started, 10 planned, 20 needs review, 30 inprocess, 99 complete';
comment on column ZZHANDOVERLOG.zzhol_wotype
  is 'Planned,Unplanned,Improvment,Project,Facility,Admin,Other';
comment on column ZZHANDOVERLOG.zzhol_woasset
  is 'GC.LAC.Ele  or WSxxx or CRAxxx';
comment on column ZZHANDOVERLOG.zzhol_woarea
  is 'DPS , MPS, Outbound, Repack';
comment on column ZZHANDOVERLOG.zzhol_wocomplaint
  is 'text of complaint';
comment on column ZZHANDOVERLOG.zzhol_worootcause
  is 'text of cause';
comment on column ZZHANDOVERLOG.zzhol_wocorrection
  is 'text of correction made';
comment on column ZZHANDOVERLOG.zzhol_wodowntime
  is 'downtime in mins';
comment on column ZZHANDOVERLOG.zzhol_printdate
  is 'date WO was printed last';
comment on column ZZHANDOVERLOG.zzhol_genuser
  is 'ams_user.usr_name';
comment on column ZZHANDOVERLOG.zzhol_moduser
  is 'ams_user.usr_name';
alter table ZZHANDOVERLOG
  add constraint HOL_PK primary key (ZZHOL_REF)
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

prompt Loading ZZHANDOVERLOG...
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (68, 'Planned', 'Planned', null, null, 're', 'er', 'ewr', null, null, to_date('20-11-2014 18:23:28', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('20-11-2014 18:23:28', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('20-11-2014 18:23:28', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (58, 'Planned', 'Planned', 'Asset goes here', null, 'Mouse over tooltips have lots of info!', null, 'This becomes a tooltip of Complaint cell on the main form.' || chr(13) || '' || chr(10) || 'Pretty nice I think', 0, 'NOTES', to_date('12-11-2014 22:16:39', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('12-11-2014 22:16:39', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('20-11-2014 18:25:27', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (61, 'In-process', 'Improvement', 'REPORTS!!', null, 'Reports are NOT complete! Just a start not much configured but it begins ..', 'We need alist of reports', 'Any ideas for a few?', 999, 'NOTES', to_date('14-11-2014 23:27:02', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('14-11-2014 23:27:02', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('14-11-2014 23:27:02', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (43, 'Entered', 'Planned', 'WiLog', null, 'What is a fair amount of default time when entering a work order?', 'asdfgafg', 'afgdasfg', 0, 'NOTES', to_date('06-11-2014 14:43:36', 'dd-mm-yyyy hh24:mi:ss'), 'Farnell, Brian', to_date('06-11-2014 14:43:36', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('19-11-2014 22:45:59', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (63, 'Review', 'Admin', null, null, 'Nope I cant modify work orders! Yes you can!', null, null, 0, 'NOTES', to_date('17-11-2014 12:16:02', 'dd-mm-yyyy hh24:mi:ss'), 'Farnell, Brian', to_date('17-11-2014 12:16:02', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('19-11-2014 20:06:10', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (59, 'In-process', 'Passdown', 'WiLog', null, 'Parts grid appears to work, needs more testing', 'Cause works!', 'Correction also', 0, 'NOTES', to_date('12-11-2014 22:22:10', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('12-11-2014 22:22:10', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('20-11-2014 18:12:31', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (66, 'Entered', 'Planned', null, null, 'test', 'test', 'test', null, null, to_date('19-11-2014 19:17:55', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('19-11-2014 19:17:55', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('19-11-2014 21:30:33', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (67, 'Planned', 'Planned', 'N/A', null, 'NICE! Entered works perfectly!', null, null, null, null, to_date('20-11-2014 10:51:54', 'dd-mm-yyyy hh24:mi:ss'), 'Farnell, Brian', to_date('20-11-2014 10:51:54', 'dd-mm-yyyy hh24:mi:ss'), 'Farnell, Brian', to_date('20-11-2014 10:51:54', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (44, 'Planned', 'Planned', 'WiLog', null, 'Brian and Dan can edit / delete other users work orders.  This is a very very long text line so i can test the word wraping of the text lines on the report layout form. I hope this line is long enough to work!', 'vgfrgtrgt', 'wdcwecded', 0, 'NOTES', to_date('06-11-2014 14:45:49', 'dd-mm-yyyy hh24:mi:ss'), 'Farnell, Brian', to_date('06-11-2014 14:45:49', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('20-11-2014 18:20:15', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (60, 'Review', 'Facility', 'MPS Deck', null, 'I picked on the deck!', 'did i make rate', null, 0, 'NOTES', to_date('14-11-2014 22:32:34', 'dd-mm-yyyy hh24:mi:ss'), 'Steinke, Stephen', to_date('14-11-2014 22:32:34', 'dd-mm-yyyy hh24:mi:ss'), 'MITCHELL, DAN', to_date('17-11-2014 23:14:47', 'dd-mm-yyyy hh24:mi:ss'));
insert into ZZHANDOVERLOG (zzhol_ref, zzhol_state, zzhol_wotype, zzhol_woasset, zzhol_woarea, zzhol_wocomplaint, zzhol_worootcause, zzhol_wocorrection, zzhol_wodowntime, zzhol_wonotes, zzhol_printdate, zzhol_genuser, zzhol_gendate, zzhol_moduser, zzhol_moddate)
values (65, 'Entered', 'Planned', null, null, 'Add state Entered, grey out feilds, prevent this from showing up in report', 'asd', 'asd', 999, 'NOTES', to_date('19-11-2014 14:08:45', 'dd-mm-yyyy hh24:mi:ss'), 'Farnell, Brian', to_date('19-11-2014 14:08:45', 'dd-mm-yyyy hh24:mi:ss'), 'Farnell, Brian', to_date('20-11-2014 10:51:15', 'dd-mm-yyyy hh24:mi:ss'));
commit;
prompt 11 records loaded
set feedback on
set define on
prompt Done.

@echo on

REG QUERY HKEY_USERS\S-1-5-21-1409082233-764733703-1177238915-500\Software\CBV\M-TRiX\M-TRiX /v m_strDbConnPrefix


REG ADD HKEY_USERS\S-1-5-21-1409082233-764733703-1177238915-500\Software\CBV\M-TRiX\M-TRiX /v m_strDbConnPrefix Provider=1SQLNCLI10;Data Source=.\SQLEXPRESS;Integrated Security=SSPI;


pause
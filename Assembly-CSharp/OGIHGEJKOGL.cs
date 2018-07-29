using System;
using System.Text.RegularExpressions;
using Crosstales.BWF;
using Crosstales.BWF.Model;
using PSXAPI.Request;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x0200012F RID: 303
public class OGIHGEJKOGL : MonoBehaviour
{
	// Token: 0x06002354 RID: 9044 RVA: 0x000E73CC File Offset: 0x000E55CC
	public void OBKBOMPEQHI()
	{
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[0].SetActive(false);
		this.NGIMLFCHNFI.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("[00DD00]Equipped", 423f);
	}

	// Token: 0x06002355 RID: 9045 RVA: 0x00012F6A File Offset: 0x0001116A
	public void QMCOBCBMFKB()
	{
		Application.OpenURL("(P)");
	}

	// Token: 0x06002356 RID: 9046 RVA: 0x000E7430 File Offset: 0x000E5630
	public void EPQJDPBNHEL(PSXAPI.Response.CheckEmail BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == CheckEmailResult.Failed)
		{
			if (BJGCBDNBQCJ.Email == this.IGIFQJGMLJN.BGBMIEJJQKC)
			{
				this.OBEIDGJGLEJ.PIDLOFMIEFQ = "Email Address already in use";
				this.OBEIDGJGLEJ.gameObject.SetActive(true);
				this.OBEIDGJGLEJ.DIIHJCJOKMP = 1f;
				this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().enabled = false;
			}
		}
		else if (BJGCBDNBQCJ.Email == this.IGIFQJGMLJN.BGBMIEJJQKC)
		{
			this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.OBEIDGJGLEJ.gameObject.SetActive(false);
		}
	}

	// Token: 0x06002357 RID: 9047 RVA: 0x000E74DC File Offset: 0x000E56DC
	public void LBNJJBMDIHO(PSXAPI.Response.CreateUser BJGCBDNBQCJ)
	{
		this.IQDCDBCPBEN[0].SetActive(false);
		if (BJGCBDNBQCJ.Result == CreateUserResult.Error)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC
			}, true);
			this.NGIMLFCHNFI.gameObject.SetActive(false);
			this.NGIMLFCHNFI.LKPOBCBOFIC("grass");
			base.Invoke("teravolt", 1587f);
			this.MBPHKDQMJJH.GetComponent<PDCGOFBNGBN>().IJDNKOJOIIF();
			this.IGIFQJGMLJN.GetComponent<PDCGOFBNGBN>().LLFBHQMIOPO();
		}
		else
		{
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.PIDLOFMIEFQ = "uproar" + this.MBPHKDQMJJH.BGBMIEJJQKC + "\n[PD]";
			this.NGIMLFCHNFI.LJGQIHIPOMD();
			base.Invoke(" attack!\r\n", 1825f);
			GDDKPIHHICF.QOQONHOOLNE.QIOFBCDMLCB.BGBMIEJJQKC = this.MBPHKDQMJJH.HJMJDJKOILH();
			GDDKPIHHICF.QOQONHOOLNE.LFGLJBKOFIN.NCBFKNGMKPB(string.Empty);
		}
	}

	// Token: 0x06002358 RID: 9048 RVA: 0x000E75F4 File Offset: 0x000E57F4
	public void QMHNGILQJNG()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.EIJOKECKIPE.IGFBEQNDQNC();
			return;
		}
		bool flag = this.QLBIIJHJPEP();
		bool flag2 = this.CheckName();
		bool flag3 = this.ICQPKOBDQBN();
		if (this.QHNLDODGGQB.PIDLOFMIEFQ == "Tough Claws")
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = " Obtained";
			this.QHNLDODGGQB.gameObject.SetActive(false);
			this.QHNLDODGGQB.DIIHJCJOKMP = 989f;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.HJMJDJKOILH()
			}, false);
		}
		if (this.GJKHLQHINNI.PIDLOFMIEFQ != this.QFQKHIMFMND.BGBMIEJJQKC)
		{
			return;
		}
		if (flag && flag2 && flag3 && this.QHNLDODGGQB.PIDLOFMIEFQ != "No Animation found for ItemID ")
		{
			this.IQDCDBCPBEN[1].SetActive(true);
			this.IQDCDBCPBEN[0].SetActive(true);
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.LKPOBCBOFIC("Player/Hair");
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.CreateUser
			{
				Name = this.MBPHKDQMJJH.HJMJDJKOILH(),
				Password = this.QENGKJHCBJB.HJMJDJKOILH(),
				EMail = this.IGIFQJGMLJN.HJMJDJKOILH()
			}, true);
		}
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x000E777C File Offset: 0x000E597C
	public bool MJBMBBFOQPF()
	{
		if (this.MBPHKDQMJJH.BGBMIEJJQKC.Length < 3)
		{
			this.QHNLDODGGQB.LKPOBCBOFIC(" days ago");
			this.QHNLDODGGQB.gameObject.SetActive(false);
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().PlayForward();
			return true;
		}
		int num = 0;
		for (int i = 1; i < this.MBPHKDQMJJH.BGBMIEJJQKC.Length; i += 0)
		{
			if (char.IsUpper(this.MBPHKDQMJJH.HJMJDJKOILH()[i]))
			{
				num++;
			}
		}
		if (num > 0)
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = "50/50";
			this.QHNLDODGGQB.gameObject.SetActive(false);
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		if (BWFManager.Contains(this.MBPHKDQMJJH.HJMJDJKOILH(), ManagerMask.None, Array.Empty<string>()))
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = "a";
			this.QHNLDODGGQB.gameObject.SetActive(true);
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
		this.QHNLDODGGQB.gameObject.SetActive(false);
		return false;
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x00012F76 File Offset: 0x00011176
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x000E7910 File Offset: 0x000E5B10
	public bool JLIEQJLJMKE(string OHMEPJOFOPE)
	{
		if (string.IsNullOrEmpty(OHMEPJOFOPE))
		{
			return true;
		}
		bool result;
		try
		{
			Regex regex = new Regex("Assets/AssetBundles/MapAssets/Models/Mansion/Materials/com_chip_mado1.mat", RegexOptions.Multiline | RegexOptions.ExplicitCapture | RegexOptions.Compiled);
			result = regex.IsMatch(OHMEPJOFOPE);
		}
		catch
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600235C RID: 9052 RVA: 0x000E7954 File Offset: 0x000E5B54
	public void Close()
	{
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.NGIMLFCHNFI.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x0600235D RID: 9053 RVA: 0x000E79B8 File Offset: 0x000E5BB8
	public bool BDPFEEFDJQB(string OHMEPJOFOPE)
	{
		if (string.IsNullOrEmpty(OHMEPJOFOPE))
		{
			return false;
		}
		bool result;
		try
		{
			Regex regex = new Regex("^((([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+(\\.([a-z]|\\d|[!#\\$%&'\\*\\+\\-\\/=\\?\\^_`{\\|}~]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])+)*)|((\\x22)((((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(([\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x7f]|\\x21|[\\x23-\\x5b]|[\\x5d-\\x7e]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(\\\\([\\x01-\\x09\\x0b\\x0c\\x0d-\\x7f]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF]))))*(((\\x20|\\x09)*(\\x0d\\x0a))?(\\x20|\\x09)+)?(\\x22)))@((([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?$", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled);
			result = regex.IsMatch(OHMEPJOFOPE);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x000E79FC File Offset: 0x000E5BFC
	public void PCJBGJKHOEB(PSXAPI.Response.CreateUser BJGCBDNBQCJ)
	{
		this.IQDCDBCPBEN[1].SetActive(true);
		if (BJGCBDNBQCJ.Result == CreateUserResult.Error)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC
			}, false);
			this.NGIMLFCHNFI.gameObject.SetActive(false);
			this.NGIMLFCHNFI.PIDLOFMIEFQ = "[-]\r\nPP ";
			base.Invoke("#,##0", 1077f);
			this.MBPHKDQMJJH.GetComponent<PDCGOFBNGBN>().HBCKCHJLJCG();
			this.IGIFQJGMLJN.GetComponent<PDCGOFBNGBN>().HBCKCHJLJCG();
		}
		else
		{
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.PIDLOFMIEFQ = "ability" + this.MBPHKDQMJJH.BGBMIEJJQKC + "Boosts the Speed stat if the Pokémon's held item is used or lost.";
			this.NGIMLFCHNFI.MHINGEGBFNO();
			base.Invoke("BattlePoke", 1998f);
			GDDKPIHHICF.QOQONHOOLNE.QIOFBCDMLCB.NCBFKNGMKPB(this.MBPHKDQMJJH.HJMJDJKOILH());
			GDDKPIHHICF.QOQONHOOLNE.LFGLJBKOFIN.BGBMIEJJQKC = string.Empty;
		}
	}

	// Token: 0x0600235F RID: 9055 RVA: 0x000E7B14 File Offset: 0x000E5D14
	private bool GIEEMKGDLKJ()
	{
		if (this.QENGKJHCBJB.HJMJDJKOILH() != this.BIHFHCNGBBI.HJMJDJKOILH())
		{
			this.DNOQNHNDCDO.LKPOBCBOFIC("default");
			this.DNOQNHNDCDO.gameObject.SetActive(false);
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().PlayForward();
			return true;
		}
		if (this.QENGKJHCBJB.BGBMIEJJQKC.Length < 1)
		{
			this.DNOQNHNDCDO.LKPOBCBOFIC("[");
			this.DNOQNHNDCDO.gameObject.SetActive(false);
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		this.DNOQNHNDCDO.gameObject.SetActive(true);
		this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = true;
		return false;
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x000E7C1C File Offset: 0x000E5E1C
	public void CKILPPEKJKJ()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.EIJOKECKIPE.NBMEDLGFPPP();
			return;
		}
		bool flag = this.QLBIIJHJPEP();
		bool flag2 = this.MJBMBBFOQPF();
		bool flag3 = this.ICQPKOBDQBN();
		if (this.QHNLDODGGQB.PIDLOFMIEFQ == "#,##0")
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = "[url=";
			this.QHNLDODGGQB.gameObject.SetActive(true);
			this.QHNLDODGGQB.DIIHJCJOKMP = 880f;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC
			}, true);
		}
		if (this.GJKHLQHINNI.PIDLOFMIEFQ != this.QFQKHIMFMND.BGBMIEJJQKC)
		{
			return;
		}
		if (flag && flag2 && flag3 && this.QHNLDODGGQB.PIDLOFMIEFQ != "Sound")
		{
			this.IQDCDBCPBEN[0].SetActive(true);
			this.IQDCDBCPBEN[1].SetActive(true);
			this.NGIMLFCHNFI.gameObject.SetActive(false);
			this.NGIMLFCHNFI.LKPOBCBOFIC("´");
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.CreateUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC,
				Password = this.QENGKJHCBJB.HJMJDJKOILH(),
				EMail = this.IGIFQJGMLJN.HJMJDJKOILH()
			}, true);
		}
	}

	// Token: 0x06002361 RID: 9057 RVA: 0x00012F89 File Offset: 0x00011189
	public void GJKDKICBBOM()
	{
		Application.OpenURL("'s [ffff00]");
	}

	// Token: 0x06002362 RID: 9058 RVA: 0x000E7DA4 File Offset: 0x000E5FA4
	public void GPKHMHCOFBK(PSXAPI.Response.CreateUser BJGCBDNBQCJ)
	{
		this.IQDCDBCPBEN[1].SetActive(true);
		if (BJGCBDNBQCJ.Result == CreateUserResult.Error)
		{
			GDDKPIHHICF.QOQONHOOLNE.KNFHIKIONMF(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.HJMJDJKOILH()
			}, true);
			this.NGIMLFCHNFI.gameObject.SetActive(false);
			this.NGIMLFCHNFI.PIDLOFMIEFQ = "Battle Update: ";
			base.Invoke("HidePanel", 1619f);
			this.MBPHKDQMJJH.GetComponent<PDCGOFBNGBN>().NJKKHPMHDOO();
			this.IGIFQJGMLJN.GetComponent<PDCGOFBNGBN>().KBNOJGGLQPI();
		}
		else
		{
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.PIDLOFMIEFQ = "detailschange" + this.MBPHKDQMJJH.HJMJDJKOILH() + "sniper";
			this.NGIMLFCHNFI.MHINGEGBFNO();
			base.Invoke("mist", 1191f);
			GDDKPIHHICF.QOQONHOOLNE.QIOFBCDMLCB.NCBFKNGMKPB(this.MBPHKDQMJJH.HJMJDJKOILH());
			GDDKPIHHICF.QOQONHOOLNE.LFGLJBKOFIN.NCBFKNGMKPB(string.Empty);
		}
	}

	// Token: 0x06002364 RID: 9060 RVA: 0x000E7EBC File Offset: 0x000E60BC
	public bool CheckName()
	{
		if (this.MBPHKDQMJJH.BGBMIEJJQKC.Length < 3)
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = "Username is too short";
			this.QHNLDODGGQB.gameObject.SetActive(true);
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		int num = 0;
		for (int i = 0; i < this.MBPHKDQMJJH.BGBMIEJJQKC.Length; i++)
		{
			if (char.IsUpper(this.MBPHKDQMJJH.BGBMIEJJQKC[i]))
			{
				num++;
			}
		}
		if (num > 3)
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = "Username can only contain 3 capitals";
			this.QHNLDODGGQB.gameObject.SetActive(true);
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		if (BWFManager.Contains(this.MBPHKDQMJJH.BGBMIEJJQKC, ManagerMask.BadWord, Array.Empty<string>()))
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = "You can not use this username";
			this.QHNLDODGGQB.gameObject.SetActive(true);
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
		this.QHNLDODGGQB.gameObject.SetActive(false);
		return true;
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x000E8050 File Offset: 0x000E6250
	public void IPDFDFHIPJE(PSXAPI.Response.CheckEmail BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == CheckEmailResult.Failed)
		{
			if (BJGCBDNBQCJ.Email == this.IGIFQJGMLJN.HJMJDJKOILH())
			{
				this.OBEIDGJGLEJ.LKPOBCBOFIC("solarbeam");
				this.OBEIDGJGLEJ.gameObject.SetActive(true);
				this.OBEIDGJGLEJ.DIIHJCJOKMP = 1361f;
				this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().enabled = false;
			}
		}
		else if (BJGCBDNBQCJ.Email == this.IGIFQJGMLJN.BGBMIEJJQKC)
		{
			this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.OBEIDGJGLEJ.gameObject.SetActive(false);
		}
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x00012F76 File Offset: 0x00011176
	private void DJPGCPMOJDK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06002367 RID: 9063 RVA: 0x00012F95 File Offset: 0x00011195
	public void ComparePasswords()
	{
		this.QLBIIJHJPEP();
	}

	// Token: 0x06002368 RID: 9064 RVA: 0x000E80FC File Offset: 0x000E62FC
	public void LNELQGQDMCL(PSXAPI.Response.CreateUser BJGCBDNBQCJ)
	{
		this.IQDCDBCPBEN[1].SetActive(false);
		if (BJGCBDNBQCJ.Result == CreateUserResult.Error)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC
			}, true);
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.LKPOBCBOFIC("BuffIcon_Repel");
			base.Invoke("[ff9900]", 716f);
			this.MBPHKDQMJJH.GetComponent<PDCGOFBNGBN>().IJDNKOJOIIF();
			this.IGIFQJGMLJN.GetComponent<PDCGOFBNGBN>().BOOODECGPQL();
		}
		else
		{
			this.NGIMLFCHNFI.gameObject.SetActive(false);
			this.NGIMLFCHNFI.LKPOBCBOFIC("Fog Volume exited by " + this.MBPHKDQMJJH.HJMJDJKOILH() + "UI");
			this.NGIMLFCHNFI.LJGQIHIPOMD();
			base.Invoke("The [ffff00]", 311f);
			GDDKPIHHICF.QOQONHOOLNE.QIOFBCDMLCB.NCBFKNGMKPB(this.MBPHKDQMJJH.HJMJDJKOILH());
			GDDKPIHHICF.QOQONHOOLNE.LFGLJBKOFIN.BGBMIEJJQKC = string.Empty;
		}
	}

	// Token: 0x06002369 RID: 9065 RVA: 0x000E8214 File Offset: 0x000E6414
	private bool QLBIIJHJPEP()
	{
		if (this.QENGKJHCBJB.BGBMIEJJQKC != this.BIHFHCNGBBI.BGBMIEJJQKC)
		{
			this.DNOQNHNDCDO.PIDLOFMIEFQ = "Passwords do not match";
			this.DNOQNHNDCDO.gameObject.SetActive(true);
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		if (this.QENGKJHCBJB.BGBMIEJJQKC.Length < 5)
		{
			this.DNOQNHNDCDO.PIDLOFMIEFQ = "Password is too short";
			this.DNOQNHNDCDO.gameObject.SetActive(true);
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		this.DNOQNHNDCDO.gameObject.SetActive(false);
		this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = false;
		return true;
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x0600236A RID: 9066 RVA: 0x00012F9E File Offset: 0x0001119E
	public static OGIHGEJKOGL QOQONHOOLNE
	{
		get
		{
			return OGIHGEJKOGL.HBFFCJHOCPE;
		}
	}

	// Token: 0x0600236B RID: 9067 RVA: 0x000E831C File Offset: 0x000E651C
	private bool ICQPKOBDQBN()
	{
		if (this.IGIFQJGMLJN.BGBMIEJJQKC != this.OLDNIIDBDKJ.BGBMIEJJQKC)
		{
			this.OBEIDGJGLEJ.PIDLOFMIEFQ = "Emails do not match";
			this.OBEIDGJGLEJ.gameObject.SetActive(true);
			this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		if (this.IGIFQJGMLJN.BGBMIEJJQKC.Length >= 5 && this.BDPFEEFDJQB(this.IGIFQJGMLJN.BGBMIEJJQKC))
		{
			this.OBEIDGJGLEJ.gameObject.SetActive(false);
			this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().enabled = false;
			return true;
		}
		this.OBEIDGJGLEJ.PIDLOFMIEFQ = "Email is invalid";
		this.OBEIDGJGLEJ.gameObject.SetActive(true);
		this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
		this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().enabled = true;
		this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().PlayForward();
		return false;
	}

	// Token: 0x0600236C RID: 9068 RVA: 0x00012FA5 File Offset: 0x000111A5
	public void OpenPolicy()
	{
		Application.OpenURL("http://poke.one/privacy.html");
	}

	// Token: 0x0600236D RID: 9069 RVA: 0x000E8438 File Offset: 0x000E6638
	public void MDKQBGJKHCF()
	{
		this.IQDCDBCPBEN[1].SetActive(false);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.NGIMLFCHNFI.gameObject.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Keen eyes prevent other Pokémon from lowering this Pokémon's accuracy.", 109f);
	}

	// Token: 0x0600236E RID: 9070 RVA: 0x00012FB1 File Offset: 0x000111B1
	private void Awake()
	{
		OGIHGEJKOGL.HBFFCJHOCPE = this;
	}

	// Token: 0x0600236F RID: 9071 RVA: 0x000E849C File Offset: 0x000E669C
	public void Open()
	{
		string text = KGQECFKLKOP.NNHFLHEQMOI(UnityEngine.Random.Range(1, 700));
		string text2 = string.Empty;
		foreach (char c in text)
		{
			if (UnityEngine.Random.Range(0, 100) > 50)
			{
				text2 += c.ToString().ToLowerInvariant();
			}
			else
			{
				text2 += c.ToString().ToUpperInvariant();
			}
		}
		this.GJKHLQHINNI.PIDLOFMIEFQ = text2;
		this.IQDCDBCPBEN[0].SetActive(true);
		this.IQDCDBCPBEN[1].SetActive(false);
		this.NGIMLFCHNFI.gameObject.SetActive(false);
		this.OBEIDGJGLEJ.gameObject.SetActive(false);
		this.DNOQNHNDCDO.gameObject.SetActive(false);
		this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = false;
		this.OBEIDGJGLEJ.GetComponent<EPIJJNOIKEK>().enabled = false;
		this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
		this.QHNLDODGGQB.gameObject.SetActive(false);
		this.MBPHKDQMJJH.BGBMIEJJQKC = string.Empty;
		this.QENGKJHCBJB.BGBMIEJJQKC = string.Empty;
		this.BIHFHCNGBBI.BGBMIEJJQKC = string.Empty;
		this.IGIFQJGMLJN.BGBMIEJJQKC = string.Empty;
		this.OLDNIIDBDKJ.BGBMIEJJQKC = string.Empty;
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.EIJOKECKIPE.IGFBEQNDQNC();
	}

	// Token: 0x06002370 RID: 9072 RVA: 0x000E8660 File Offset: 0x000E6860
	private bool CLDBKJIGPFN()
	{
		if (this.QENGKJHCBJB.BGBMIEJJQKC != this.BIHFHCNGBBI.BGBMIEJJQKC)
		{
			this.DNOQNHNDCDO.LKPOBCBOFIC("1");
			this.DNOQNHNDCDO.gameObject.SetActive(false);
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().PlayForward();
			return true;
		}
		if (this.QENGKJHCBJB.BGBMIEJJQKC.Length < 0)
		{
			this.DNOQNHNDCDO.LKPOBCBOFIC("Icon_Status_Frozen");
			this.DNOQNHNDCDO.gameObject.SetActive(true);
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().ResetToBeginning();
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = true;
			this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().PlayForward();
			return false;
		}
		this.DNOQNHNDCDO.gameObject.SetActive(false);
		this.DNOQNHNDCDO.GetComponent<EPIJJNOIKEK>().enabled = true;
		return false;
	}

	// Token: 0x06002371 RID: 9073 RVA: 0x00012FB9 File Offset: 0x000111B9
	public void CheckUsername()
	{
		this.CheckName();
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x00012FC2 File Offset: 0x000111C2
	public void CheckEmails()
	{
		this.ICQPKOBDQBN();
	}

	// Token: 0x06002373 RID: 9075 RVA: 0x00012FCB File Offset: 0x000111CB
	public void HMKLQLLFIMD()
	{
		this.GIEEMKGDLKJ();
	}

	// Token: 0x06002374 RID: 9076 RVA: 0x000E8768 File Offset: 0x000E6968
	public void GDQKNBGCCPI(PSXAPI.Response.CreateUser BJGCBDNBQCJ)
	{
		this.IQDCDBCPBEN[1].SetActive(true);
		if (BJGCBDNBQCJ.Result == CreateUserResult.Error)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC
			}, false);
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.LKPOBCBOFIC("stockpile2");
			base.Invoke("Take 001", 482f);
			this.MBPHKDQMJJH.GetComponent<PDCGOFBNGBN>().KBNOJGGLQPI();
			this.IGIFQJGMLJN.GetComponent<PDCGOFBNGBN>().IJDNKOJOIIF();
		}
		else
		{
			this.NGIMLFCHNFI.gameObject.SetActive(false);
			this.NGIMLFCHNFI.LKPOBCBOFIC("a" + this.MBPHKDQMJJH.BGBMIEJJQKC + "_FogParams");
			this.NGIMLFCHNFI.MHINGEGBFNO();
			base.Invoke("berry_16", 1811f);
			GDDKPIHHICF.QOQONHOOLNE.QIOFBCDMLCB.NCBFKNGMKPB(this.MBPHKDQMJJH.HJMJDJKOILH());
			GDDKPIHHICF.QOQONHOOLNE.LFGLJBKOFIN.NCBFKNGMKPB(string.Empty);
		}
	}

	// Token: 0x06002375 RID: 9077 RVA: 0x000E8880 File Offset: 0x000E6A80
	public void QMMDGPGDFOG(PSXAPI.Response.CreateUser BJGCBDNBQCJ)
	{
		this.IQDCDBCPBEN[1].SetActive(false);
		if (BJGCBDNBQCJ.Result == CreateUserResult.Error)
		{
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC
			}, false);
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.PIDLOFMIEFQ = "Account creation failed!";
			base.Invoke("HidePanel", 3f);
			this.MBPHKDQMJJH.GetComponent<PDCGOFBNGBN>().BOOODECGPQL();
			this.IGIFQJGMLJN.GetComponent<PDCGOFBNGBN>().BOOODECGPQL();
		}
		else
		{
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.PIDLOFMIEFQ = "Welcome " + this.MBPHKDQMJJH.BGBMIEJJQKC + ", Account creation successful!";
			this.NGIMLFCHNFI.LJGQIHIPOMD();
			base.Invoke("HidePanel", 3f);
			GDDKPIHHICF.QOQONHOOLNE.QIOFBCDMLCB.BGBMIEJJQKC = this.MBPHKDQMJJH.BGBMIEJJQKC;
			GDDKPIHHICF.QOQONHOOLNE.LFGLJBKOFIN.BGBMIEJJQKC = string.Empty;
		}
	}

	// Token: 0x06002376 RID: 9078 RVA: 0x000E8998 File Offset: 0x000E6B98
	public void CCGFFHJPNKB(PSXAPI.Response.CheckUser BJGCBDNBQCJ)
	{
		if (BJGCBDNBQCJ.Result == CheckUserResult.Failed)
		{
			if (BJGCBDNBQCJ.Name == this.MBPHKDQMJJH.BGBMIEJJQKC)
			{
				this.QHNLDODGGQB.PIDLOFMIEFQ = "Username already in use";
				this.QHNLDODGGQB.gameObject.SetActive(true);
				this.QHNLDODGGQB.DIIHJCJOKMP = 1f;
				this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
			}
		}
		else if (BJGCBDNBQCJ.Name == this.MBPHKDQMJJH.BGBMIEJJQKC)
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = string.Empty;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
			this.QHNLDODGGQB.gameObject.SetActive(false);
		}
	}

	// Token: 0x06002377 RID: 9079 RVA: 0x000E8A58 File Offset: 0x000E6C58
	public void Sumbit()
	{
		if (!GDDKPIHHICF.QOQONHOOLNE.JOQBIMQCNDO)
		{
			this.EIJOKECKIPE.IGFBEQNDQNC();
			return;
		}
		bool flag = this.QLBIIJHJPEP();
		bool flag2 = this.CheckName();
		bool flag3 = this.ICQPKOBDQBN();
		if (this.QHNLDODGGQB.PIDLOFMIEFQ == "Username already in use")
		{
			this.QHNLDODGGQB.PIDLOFMIEFQ = "Username already in use";
			this.QHNLDODGGQB.gameObject.SetActive(true);
			this.QHNLDODGGQB.DIIHJCJOKMP = 1f;
			this.QHNLDODGGQB.GetComponent<EPIJJNOIKEK>().enabled = false;
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.CheckUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC
			}, false);
		}
		if (this.GJKHLQHINNI.PIDLOFMIEFQ != this.QFQKHIMFMND.BGBMIEJJQKC)
		{
			return;
		}
		if (flag && flag2 && flag3 && this.QHNLDODGGQB.PIDLOFMIEFQ != "Username already in use")
		{
			this.IQDCDBCPBEN[0].SetActive(false);
			this.IQDCDBCPBEN[1].SetActive(true);
			this.NGIMLFCHNFI.gameObject.SetActive(true);
			this.NGIMLFCHNFI.PIDLOFMIEFQ = "Creating Account";
			GDDKPIHHICF.QOQONHOOLNE.HLIOFPONLLE(new PSXAPI.Request.CreateUser
			{
				Name = this.MBPHKDQMJJH.BGBMIEJJQKC,
				Password = this.QENGKJHCBJB.BGBMIEJJQKC,
				EMail = this.IGIFQJGMLJN.BGBMIEJJQKC
			}, false);
		}
	}

	// Token: 0x06002378 RID: 9080 RVA: 0x00012FD4 File Offset: 0x000111D4
	public void OpenTerms()
	{
		Application.OpenURL("http://poke.one/terms.html");
	}

	// Token: 0x040007A2 RID: 1954
	private static OGIHGEJKOGL HBFFCJHOCPE;

	// Token: 0x040007A3 RID: 1955
	public BKKHLBCLPJM GJKHLQHINNI;

	// Token: 0x040007A4 RID: 1956
	public JIMBBPLINGI QFQKHIMFMND;

	// Token: 0x040007A5 RID: 1957
	public PDCGOFBNGBN EIJOKECKIPE;

	// Token: 0x040007A6 RID: 1958
	public JIMBBPLINGI MBPHKDQMJJH;

	// Token: 0x040007A7 RID: 1959
	public JIMBBPLINGI QENGKJHCBJB;

	// Token: 0x040007A8 RID: 1960
	public JIMBBPLINGI BIHFHCNGBBI;

	// Token: 0x040007A9 RID: 1961
	public BKKHLBCLPJM QHNLDODGGQB;

	// Token: 0x040007AA RID: 1962
	public BKKHLBCLPJM DNOQNHNDCDO;

	// Token: 0x040007AB RID: 1963
	public BKKHLBCLPJM OBEIDGJGLEJ;

	// Token: 0x040007AC RID: 1964
	public JIMBBPLINGI IGIFQJGMLJN;

	// Token: 0x040007AD RID: 1965
	public JIMBBPLINGI OLDNIIDBDKJ;

	// Token: 0x040007AE RID: 1966
	public GameObject EPNBECQFKEK;

	// Token: 0x040007AF RID: 1967
	public BKKHLBCLPJM NGIMLFCHNFI;

	// Token: 0x040007B0 RID: 1968
	public GameObject[] IQDCDBCPBEN;

	// Token: 0x040007B1 RID: 1969
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x040007B2 RID: 1970
	public EPIJJNOIKEK JDPBPOKJFQK;
}

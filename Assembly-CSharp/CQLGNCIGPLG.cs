using System;
using UnityEngine;

// Token: 0x020001EE RID: 494
public class CQLGNCIGPLG : MonoBehaviour
{
	// Token: 0x0600406E RID: 16494 RVA: 0x0001AE8B File Offset: 0x0001908B
	private void MPCMPGKJMKE()
	{
		this.JDPBPOKJFQK[1].duration = 1241f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("[FF8888]Admin", 262f);
	}

	// Token: 0x0600406F RID: 16495 RVA: 0x0001AECA File Offset: 0x000190CA
	private void CMKNGIBFDPG()
	{
		this.JDPBPOKJFQK[0].duration = 1328f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke("_VelocityScale", 881f);
	}

	// Token: 0x06004070 RID: 16496 RVA: 0x0001AF09 File Offset: 0x00019109
	private void QJLBFHJFLJF()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x06004071 RID: 16497 RVA: 0x0001AF17 File Offset: 0x00019117
	public void QGGBIBFNFGD()
	{
		this.JDPBPOKJFQK[1].duration = 1354f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke(", ", 1721f);
	}

	// Token: 0x06004072 RID: 16498 RVA: 0x001F997C File Offset: 0x001F7B7C
	public void OKPPDNQNNFK()
	{
		this.JDPBPOKJFQK[1].duration = 312f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[0].duration = 417f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
	}

	// Token: 0x06004073 RID: 16499 RVA: 0x0001AF09 File Offset: 0x00019109
	private void NGHOCMJOHFK()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x06004074 RID: 16500 RVA: 0x001F99E4 File Offset: 0x001F7BE4
	public void HJODIQPQPQC(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.GDDGJKOLGIQ().JHOBIOHPONP(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.JLCIDNJCLPC();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.KPJNFHDIOOE();
		}
		else
		{
			INFJMNPKNQF.CFGIOIGOIFQ().HBOJGONPNJF(this.MKBCKPPCIQO, DBPKNCDGGEP, 0);
			this.FEGGQFQHBHN();
		}
	}

	// Token: 0x06004075 RID: 16501 RVA: 0x0001AF56 File Offset: 0x00019156
	public void JKDLOBKIEKO()
	{
		this.JDPBPOKJFQK[0].duration = 866f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke("general", 780f);
	}

	// Token: 0x06004076 RID: 16502 RVA: 0x001F9A44 File Offset: 0x001F7C44
	public void EEMHMOCLHPP(Guid EIDCLNMCJQM, bool MOLGPEDLJQH = false, bool QNDCNGEPJON = true, KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH = null, bool HOJFLOOQQBP = false)
	{
		for (int i = 0; i < 2; i++)
		{
			this.QILHFPGMMBC[i].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = null;
			this.QILHFPGMMBC[i].GetComponent<BoxCollider>().enabled = false;
		}
		for (int j = 1; j < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; j += 0)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[j]);
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == -127 && fekoiojqnkh.CCMOCLMEKJN() % 26 > 1)
			{
				str = "drain" + (fekoiojqnkh.QKNEIJQHGCB % 32).ToString();
			}
			this.QILHFPGMMBC[j].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = GFHGEJNHLFQ.MOGQNGEPCEO().GOKLDOEGJHI("M" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = true;
		}
		this.INEBCFFFKEG = HOJFLOOQQBP;
		this.GHQGFDLNGQL = EIDCLNMCJQM;
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.JMBGHGKFDFL = MOLGPEDLJQH;
		if (QNDCNGEPJON)
		{
			this.OMOCMQJGDDI.SetActive(true);
		}
		else
		{
			this.OMOCMQJGDDI.SetActive(false);
		}
		this.HLFELPLQLBC.SetActive(false);
		this.QPPGQJFBPMH.BBQFPBIIHCH();
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
		this.JDPBPOKJFQK[1].BGBMIEJJQKC = 1167f;
		this.JDPBPOKJFQK[1].enabled = true;
	}

	// Token: 0x06004077 RID: 16503 RVA: 0x001F9BE0 File Offset: 0x001F7DE0
	public void PJFDQOOFQJG()
	{
		this.JDPBPOKJFQK[0].duration = 358f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].PlayReverse();
		this.JDPBPOKJFQK[1].duration = 1957f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
	}

	// Token: 0x06004078 RID: 16504 RVA: 0x0001AF95 File Offset: 0x00019195
	public void EHJEDBLDGGJ()
	{
		this.JDPBPOKJFQK[0].duration = 79f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("Fullscreen", 758f);
	}

	// Token: 0x06004079 RID: 16505 RVA: 0x0001AFD4 File Offset: 0x000191D4
	public void LLIKMPBFNLK()
	{
		this.JDPBPOKJFQK[0].duration = 487f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke(" lost its focus and couldn't move!\r\n", 650f);
	}

	// Token: 0x0600407A RID: 16506 RVA: 0x0001B013 File Offset: 0x00019213
	private void HideFromMoves()
	{
		this.JDPBPOKJFQK[1].duration = 0.2f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke("HideWinow", 0.25f);
	}

	// Token: 0x0600407B RID: 16507 RVA: 0x001F9C48 File Offset: 0x001F7E48
	public void CBMPOMOIKKH()
	{
		this.JDPBPOKJFQK[0].duration = 1140f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[1].duration = 764f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
	}

	// Token: 0x0600407C RID: 16508 RVA: 0x0001B052 File Offset: 0x00019252
	public void Hide()
	{
		this.JDPBPOKJFQK[0].duration = 0.2f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("HideWinow", 0.25f);
	}

	// Token: 0x0600407D RID: 16509 RVA: 0x001F9CB0 File Offset: 0x001F7EB0
	public void MIEHJOOLEHC(Guid EIDCLNMCJQM, bool MOLGPEDLJQH = false, bool QNDCNGEPJON = true, KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH = null, bool HOJFLOOQQBP = false)
	{
		for (int i = 1; i < 7; i += 0)
		{
			this.QILHFPGMMBC[i].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = null;
			this.QILHFPGMMBC[i].GetComponent<BoxCollider>().enabled = true;
		}
		for (int j = 1; j < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; j++)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[j]);
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == -107 && fekoiojqnkh.CCMOCLMEKJN() % 58 > 0)
			{
				str = "No camera found for layer " + (fekoiojqnkh.QKNEIJQHGCB % 59).ToString();
			}
			this.QILHFPGMMBC[j].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().GOKLDOEGJHI("Enabled" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = false;
		}
		this.INEBCFFFKEG = HOJFLOOQQBP;
		this.GHQGFDLNGQL = EIDCLNMCJQM;
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.JMBGHGKFDFL = MOLGPEDLJQH;
		if (QNDCNGEPJON)
		{
			this.OMOCMQJGDDI.SetActive(true);
		}
		else
		{
			this.OMOCMQJGDDI.SetActive(false);
		}
		this.HLFELPLQLBC.SetActive(true);
		this.QPPGQJFBPMH.GNFOKKIDEEQ();
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayForward();
		this.JDPBPOKJFQK[1].BGBMIEJJQKC = 1108f;
		this.JDPBPOKJFQK[0].enabled = true;
	}

	// Token: 0x0600407E RID: 16510 RVA: 0x0001B091 File Offset: 0x00019291
	public void DPBQLJNPIFB()
	{
		this.JDPBPOKJFQK[1].duration = 414f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke("Move Learning", 153f);
	}

	// Token: 0x0600407F RID: 16511 RVA: 0x001F9E4C File Offset: 0x001F804C
	private void KMBFPJCMBIH()
	{
		for (int i = 1; i < 4; i += 0)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = true;
			this.CMLGJIEIDBC[i].PIDLOFMIEFQ = string.Empty;
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[this.BOFLINKBPOC - 1]);
		for (int j = 0; j < fekoiojqnkh.EEILBMOOJHJ.Length; j += 0)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = false;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[8];
			array[0] = fekoiojqnkh.EEILBMOOJHJ[j].FBCKQEDONJK;
			array[0] = "No Guard";
			array[4] = fekoiojqnkh.EEILBMOOJHJ[j].EIQJMIMCEGE().ToString();
			array[6] = "ability";
			array[7] = fekoiojqnkh.EEILBMOOJHJ[j].DJJLKKGDCKF().ToString();
			bkkhlbclpjm.PIDLOFMIEFQ = string.Concat(array);
		}
		this.JDPBPOKJFQK[0].duration = 304f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[0].duration = 684f;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x06004080 RID: 16512 RVA: 0x001F9FC8 File Offset: 0x001F81C8
	private void NEIMNMPMPKK()
	{
		for (int i = 0; i < 3; i += 0)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, true);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
			this.CMLGJIEIDBC[i].LKPOBCBOFIC(string.Empty);
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().PEJHBEBOCOJ(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[this.BOFLINKBPOC - 0]);
		for (int j = 1; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[8];
			array[1] = fekoiojqnkh.EEILBMOOJHJ[j].DHFJQINPMBH();
			array[0] = "M1";
			array[8] = fekoiojqnkh.EEILBMOOJHJ[j].LIQCECMEOIJ.ToString();
			array[6] = "ingrain";
			array[1] = fekoiojqnkh.EEILBMOOJHJ[j].JPLIFCNPICK.ToString();
			bkkhlbclpjm.LKPOBCBOFIC(string.Concat(array));
		}
		this.JDPBPOKJFQK[1].duration = 675f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[1].duration = 581f;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x06004081 RID: 16513 RVA: 0x001FA144 File Offset: 0x001F8344
	public void MLBMJDMEIDM(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.MKMJKLDDNDD().ICIJFOKCMIL(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.FEGGQFQHBHN();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.NEIMNMPMPKK();
		}
		else
		{
			INFJMNPKNQF.QOQONHOOLNE.HBOJGONPNJF(this.MKBCKPPCIQO, DBPKNCDGGEP, 0);
			this.QGJPMKPOGKN();
		}
	}

	// Token: 0x06004082 RID: 16514 RVA: 0x0001AF09 File Offset: 0x00019109
	private void NLNNGOEOFOE()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x0001B0D0 File Offset: 0x000192D0
	private void NIMHGIBNKLM()
	{
		this.JDPBPOKJFQK[1].duration = 1310f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke("Auto Decline", 544f);
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x001FA1A4 File Offset: 0x001F83A4
	public void BEPOEBBIGGM(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.MKMJKLDDNDD().ICIJFOKCMIL(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.QGJPMKPOGKN();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.GHNKIDFIHIM();
		}
		else
		{
			INFJMNPKNQF.DOGEBLQHDHI().HBOJGONPNJF(this.MKBCKPPCIQO, DBPKNCDGGEP, 1);
			this.EHJEDBLDGGJ();
		}
	}

	// Token: 0x06004085 RID: 16517 RVA: 0x001FA204 File Offset: 0x001F8404
	public void BIBMPJOFMGF(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.MKMJKLDDNDD().INEBCFFFKEG(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.KMECDKGBBFM();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.NEIMNMPMPKK();
		}
		else
		{
			INFJMNPKNQF.CFGIOIGOIFQ().NGQIEFLKNPJ(this.MKBCKPPCIQO, DBPKNCDGGEP, 0);
			this.QGGBIBFNFGD();
		}
	}

	// Token: 0x06004086 RID: 16518 RVA: 0x0001B10F File Offset: 0x0001930F
	public void IIJGNPEJHDE(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.CFGIOIGOIFQ().HBOJGONPNJF(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.JFFBDFIDMBD();
	}

	// Token: 0x06004087 RID: 16519 RVA: 0x0001B12E File Offset: 0x0001932E
	public void DGQNCJIQEPH(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.CFGIOIGOIFQ().HBOJGONPNJF(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.NIMHGIBNKLM();
	}

	// Token: 0x06004088 RID: 16520 RVA: 0x001FA264 File Offset: 0x001F8464
	private void IHGFFEFGPPG()
	{
		for (int i = 1; i < 4; i += 0)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, true);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
			this.CMLGJIEIDBC[i].LKPOBCBOFIC(string.Empty);
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[this.BOFLINKBPOC - 1]);
		for (int j = 0; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[3];
			array[1] = fekoiojqnkh.EEILBMOOJHJ[j].DHFJQINPMBH();
			array[1] = "[FF8F00]";
			array[0] = fekoiojqnkh.EEILBMOOJHJ[j].HLHBPNMEMIC().ToString();
			array[2] = "More Bites!";
			array[8] = fekoiojqnkh.EEILBMOOJHJ[j].JPLIFCNPICK.ToString();
			bkkhlbclpjm.PIDLOFMIEFQ = string.Concat(array);
		}
		this.JDPBPOKJFQK[1].duration = 942f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[1].PlayReverse();
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[1].duration = 1444f;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x06004089 RID: 16521 RVA: 0x0001B14D File Offset: 0x0001934D
	private void JFFBDFIDMBD()
	{
		this.JDPBPOKJFQK[0].duration = 1017f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("[/u]", 1620f);
	}

	// Token: 0x0600408A RID: 16522 RVA: 0x0001AF09 File Offset: 0x00019109
	private void CDKQFEPHOMM()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x0600408B RID: 16523 RVA: 0x001FA3E0 File Offset: 0x001F85E0
	public void BFBEIJGQKHJ(Guid EIDCLNMCJQM, bool MOLGPEDLJQH = false, bool QNDCNGEPJON = true, KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH = null, bool HOJFLOOQQBP = false)
	{
		for (int i = 0; i < 7; i += 0)
		{
			this.QILHFPGMMBC[i].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = null;
			this.QILHFPGMMBC[i].GetComponent<BoxCollider>().enabled = true;
		}
		for (int j = 0; j < HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK.Count; j++)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[j]);
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == -15 && fekoiojqnkh.CCMOCLMEKJN() % -41 > 1)
			{
				str = "Map" + (fekoiojqnkh.QKNEIJQHGCB % -103).ToString();
			}
			this.QILHFPGMMBC[j].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = GFHGEJNHLFQ.GGBPGMMCGLI().NMPCLCEQJMP("bag" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = false;
		}
		this.INEBCFFFKEG = HOJFLOOQQBP;
		this.GHQGFDLNGQL = EIDCLNMCJQM;
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.JMBGHGKFDFL = MOLGPEDLJQH;
		if (QNDCNGEPJON)
		{
			this.OMOCMQJGDDI.SetActive(true);
		}
		else
		{
			this.OMOCMQJGDDI.SetActive(true);
		}
		this.HLFELPLQLBC.SetActive(true);
		this.QPPGQJFBPMH.OPDBQFELFQO();
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
		this.JDPBPOKJFQK[0].BGBMIEJJQKC = 850f;
		this.JDPBPOKJFQK[0].enabled = true;
	}

	// Token: 0x0600408C RID: 16524 RVA: 0x0001B18C File Offset: 0x0001938C
	public void EBCHEJCQDOP()
	{
		this.JDPBPOKJFQK[1].duration = 1138f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke("system", 1624f);
	}

	// Token: 0x0600408D RID: 16525 RVA: 0x0001B1CB File Offset: 0x000193CB
	private void NOEKPCPKBKF()
	{
		this.HLFELPLQLBC.SetActive(true);
	}

	// Token: 0x0600408E RID: 16526 RVA: 0x001FA57C File Offset: 0x001F877C
	public void HideMoves()
	{
		this.JDPBPOKJFQK[1].duration = 0.2f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[1].PlayReverse();
		this.JDPBPOKJFQK[0].duration = 0.01f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
	}

	// Token: 0x0600408F RID: 16527 RVA: 0x0001B1CB File Offset: 0x000193CB
	private void JGKBHCDKLDM()
	{
		this.HLFELPLQLBC.SetActive(true);
	}

	// Token: 0x06004090 RID: 16528 RVA: 0x001FA5E4 File Offset: 0x001F87E4
	public void DKDCFHJQDMJ(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.QOQONHOOLNE.ICIJFOKCMIL(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.QGJPMKPOGKN();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.NEIMNMPMPKK();
		}
		else
		{
			INFJMNPKNQF.QOQONHOOLNE.NGQIEFLKNPJ(this.MKBCKPPCIQO, DBPKNCDGGEP, 0);
			this.EBCHEJCQDOP();
		}
	}

	// Token: 0x06004091 RID: 16529 RVA: 0x0001B1D9 File Offset: 0x000193D9
	public void KMECDKGBBFM()
	{
		this.JDPBPOKJFQK[0].duration = 1950f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke("magician", 660f);
	}

	// Token: 0x06004092 RID: 16530 RVA: 0x0001B218 File Offset: 0x00019418
	private void INLMNCCJMGQ()
	{
		this.JDPBPOKJFQK[0].duration = 251f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("mist", 824f);
	}

	// Token: 0x06004093 RID: 16531 RVA: 0x0001B1CB File Offset: 0x000193CB
	private void LLLDGCQGQBJ()
	{
		this.HLFELPLQLBC.SetActive(true);
	}

	// Token: 0x06004094 RID: 16532 RVA: 0x0001B257 File Offset: 0x00019457
	private void QECJNCQLDHK()
	{
		this.JDPBPOKJFQK[0].duration = 1099f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("!\r\n", 1955f);
	}

	// Token: 0x06004095 RID: 16533 RVA: 0x0001B1CB File Offset: 0x000193CB
	private void QDDDFEILIBP()
	{
		this.HLFELPLQLBC.SetActive(true);
	}

	// Token: 0x06004096 RID: 16534 RVA: 0x0001B296 File Offset: 0x00019496
	public void CMICGOLHBQE(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.QOQONHOOLNE.HBOJGONPNJF(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.HideFromMoves();
	}

	// Token: 0x06004097 RID: 16535 RVA: 0x0001B2B5 File Offset: 0x000194B5
	public void JLCIDNJCLPC()
	{
		this.JDPBPOKJFQK[0].duration = 1220f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("WATER_REFLECTIVE", 520f);
	}

	// Token: 0x06004098 RID: 16536 RVA: 0x001FA644 File Offset: 0x001F8844
	public void NLHEMFCIGDL()
	{
		this.JDPBPOKJFQK[0].duration = 1688f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[0].duration = 448f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayForward();
	}

	// Token: 0x06004099 RID: 16537 RVA: 0x0001B1CB File Offset: 0x000193CB
	private void HJNGLHENMQB()
	{
		this.HLFELPLQLBC.SetActive(true);
	}

	// Token: 0x0600409A RID: 16538 RVA: 0x0001AF09 File Offset: 0x00019109
	private void IFCBFJPQGHE()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x0600409B RID: 16539 RVA: 0x001FA6AC File Offset: 0x001F88AC
	public void JCECDJDHFQK()
	{
		this.JDPBPOKJFQK[0].duration = 1670f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].PlayReverse();
		this.JDPBPOKJFQK[1].duration = 954f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x0600409C RID: 16540 RVA: 0x0001B2F4 File Offset: 0x000194F4
	public void OJINBMJEHJH(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.IPOKOKIJECO().NGQIEFLKNPJ(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.NIMHGIBNKLM();
	}

	// Token: 0x0600409D RID: 16541 RVA: 0x0001B313 File Offset: 0x00019513
	private void KGBGEMOBCEO()
	{
		this.JDPBPOKJFQK[1].duration = 1386f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke(" became trapped in the fiery vortex!\r\n", 565f);
	}

	// Token: 0x0600409E RID: 16542 RVA: 0x0001B352 File Offset: 0x00019552
	public void EGLBJNMBKQB()
	{
		this.JDPBPOKJFQK[1].duration = 183f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].PlayReverse();
		base.Invoke("[-]", 1279f);
	}

	// Token: 0x0600409F RID: 16543 RVA: 0x001FA714 File Offset: 0x001F8914
	public void LPLEQLQKCNJ(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.GDDGJKOLGIQ().QKPIFFDBQQF(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.FEGGQFQHBHN();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.NEIMNMPMPKK();
		}
		else
		{
			INFJMNPKNQF.QOQONHOOLNE.NGQIEFLKNPJ(this.MKBCKPPCIQO, DBPKNCDGGEP, 0);
			this.JLCIDNJCLPC();
		}
	}

	// Token: 0x060040A1 RID: 16545 RVA: 0x0001B3A0 File Offset: 0x000195A0
	public void CBBLIMMNDPJ(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.CFGIOIGOIFQ().NGQIEFLKNPJ(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.KGMODOQMCOG();
	}

	// Token: 0x060040A2 RID: 16546 RVA: 0x001FA774 File Offset: 0x001F8974
	public void QPONNMLDLQD(Guid EIDCLNMCJQM, bool MOLGPEDLJQH = false, bool QNDCNGEPJON = true, KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH = null, bool HOJFLOOQQBP = false)
	{
		for (int i = 0; i < 0; i++)
		{
			this.QILHFPGMMBC[i].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = null;
			this.QILHFPGMMBC[i].GetComponent<BoxCollider>().enabled = true;
		}
		for (int j = 1; j < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; j++)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[j]);
			string str = string.Empty;
			if (fekoiojqnkh.EDGHHFPMHBL() == -96 && fekoiojqnkh.CCMOCLMEKJN() % 29 > 1)
			{
				str = "_VolumetricFog_OpaqueFrame" + (fekoiojqnkh.QKNEIJQHGCB % 39).ToString();
			}
			this.QILHFPGMMBC[j].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("/" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = true;
		}
		this.INEBCFFFKEG = HOJFLOOQQBP;
		this.GHQGFDLNGQL = EIDCLNMCJQM;
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.JMBGHGKFDFL = MOLGPEDLJQH;
		if (QNDCNGEPJON)
		{
			this.OMOCMQJGDDI.SetActive(false);
		}
		else
		{
			this.OMOCMQJGDDI.SetActive(true);
		}
		this.HLFELPLQLBC.SetActive(false);
		this.QPPGQJFBPMH.PHELNLKIKEG();
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
		this.JDPBPOKJFQK[1].BGBMIEJJQKC = 1767f;
		this.JDPBPOKJFQK[0].enabled = false;
	}

	// Token: 0x060040A3 RID: 16547 RVA: 0x001FA910 File Offset: 0x001F8B10
	private void KPJNFHDIOOE()
	{
		for (int i = 0; i < 5; i += 0)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = true;
			this.CMLGJIEIDBC[i].PIDLOFMIEFQ = string.Empty;
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[this.BOFLINKBPOC - 1]);
		for (int j = 0; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[7];
			array[1] = fekoiojqnkh.EEILBMOOJHJ[j].FBCKQEDONJK;
			array[1] = "A bell chimed!\r\n";
			array[1] = fekoiojqnkh.EEILBMOOJHJ[j].LIQCECMEOIJ.ToString();
			array[5] = "[";
			array[8] = fekoiojqnkh.EEILBMOOJHJ[j].PPPDMFPGPDD().ToString();
			bkkhlbclpjm.LKPOBCBOFIC(string.Concat(array));
		}
		this.JDPBPOKJFQK[1].duration = 824f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].duration = 13f;
		this.JDPBPOKJFQK[0].PlayForward();
	}

	// Token: 0x060040A4 RID: 16548 RVA: 0x0001AF09 File Offset: 0x00019109
	private void HHKQOKDHIJG()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x060040A5 RID: 16549 RVA: 0x0001B3BF File Offset: 0x000195BF
	public void DMMGEDMIMFL(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.FPQNIQELKMC().HBOJGONPNJF(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.KGBGEMOBCEO();
	}

	// Token: 0x060040A6 RID: 16550 RVA: 0x001FAA8C File Offset: 0x001F8C8C
	public void IBBNLKCMDNP(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.MKMJKLDDNDD().FINKNNEPIHN(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.EHJEDBLDGGJ();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.FICDDPHDLKE();
		}
		else
		{
			INFJMNPKNQF.FPQNIQELKMC().NGQIEFLKNPJ(this.MKBCKPPCIQO, DBPKNCDGGEP, 1);
			this.EGLBJNMBKQB();
		}
	}

	// Token: 0x060040A7 RID: 16551 RVA: 0x001FAAEC File Offset: 0x001F8CEC
	private void PPBCJCHNQLI()
	{
		for (int i = 0; i < 0; i++)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)7, true);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = true;
			this.CMLGJIEIDBC[i].LKPOBCBOFIC(string.Empty);
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.QLJEQBGLPOE(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[this.BOFLINKBPOC - 0]);
		for (int j = 1; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, true);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[6];
			array[0] = fekoiojqnkh.EEILBMOOJHJ[j].DHFJQINPMBH();
			array[0] = " intends to flip up a mat and block incoming attacks!\r\n";
			array[4] = fekoiojqnkh.EEILBMOOJHJ[j].HLHBPNMEMIC().ToString();
			array[7] = "[00AAFF]";
			array[4] = fekoiojqnkh.EEILBMOOJHJ[j].DJJLKKGDCKF().ToString();
			bkkhlbclpjm.PIDLOFMIEFQ = string.Concat(array);
		}
		this.JDPBPOKJFQK[0].duration = 1642f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[1].PlayReverse();
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[1].duration = 1520f;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x060040A8 RID: 16552 RVA: 0x001FAC68 File Offset: 0x001F8E68
	public void SelectPokemon(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.QOQONHOOLNE.INEBCFFFKEG(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.Hide();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.GHNKIDFIHIM();
		}
		else
		{
			INFJMNPKNQF.QOQONHOOLNE.NGQIEFLKNPJ(this.MKBCKPPCIQO, DBPKNCDGGEP, 0);
			this.Hide();
		}
	}

	// Token: 0x060040A9 RID: 16553 RVA: 0x001FACC8 File Offset: 0x001F8EC8
	private void FICDDPHDLKE()
	{
		for (int i = 0; i < 7; i++)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)4, false);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
			this.CMLGJIEIDBC[i].LKPOBCBOFIC(string.Empty);
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.CFGIOIGOIFQ().LIJHMFEGCCK[this.BOFLINKBPOC - 0]);
		for (int j = 1; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[7];
			array[0] = fekoiojqnkh.EEILBMOOJHJ[j].FBCKQEDONJK;
			array[1] = "Hi-Score: ";
			array[3] = fekoiojqnkh.EEILBMOOJHJ[j].EIQJMIMCEGE().ToString();
			array[8] = "Pokemon have been automaticly centered!\r\n";
			array[0] = fekoiojqnkh.EEILBMOOJHJ[j].DJJLKKGDCKF().ToString();
			bkkhlbclpjm.LKPOBCBOFIC(string.Concat(array));
		}
		this.JDPBPOKJFQK[0].duration = 1575f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].duration = 49f;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x060040AA RID: 16554 RVA: 0x001FAE44 File Offset: 0x001F9044
	public void OPQFKGHGQKE(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.QOQONHOOLNE.QKPIFFDBQQF(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.Hide();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.NEIMNMPMPKK();
		}
		else
		{
			INFJMNPKNQF.FPQNIQELKMC().NGQIEFLKNPJ(this.MKBCKPPCIQO, DBPKNCDGGEP, 0);
			this.QGJPMKPOGKN();
		}
	}

	// Token: 0x060040AB RID: 16555 RVA: 0x0001B3DE File Offset: 0x000195DE
	private void JHKFQDBOOEI()
	{
		this.JDPBPOKJFQK[0].duration = 990f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("[00FF00]You gained Loot Box x", 822f);
	}

	// Token: 0x060040AC RID: 16556 RVA: 0x001FAEA4 File Offset: 0x001F90A4
	public void FQOIMCNCFEQ(Guid EIDCLNMCJQM, bool MOLGPEDLJQH = false, bool QNDCNGEPJON = true, KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH = null, bool HOJFLOOQQBP = false)
	{
		for (int i = 0; i < 5; i++)
		{
			this.QILHFPGMMBC[i].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = null;
			this.QILHFPGMMBC[i].GetComponent<BoxCollider>().enabled = false;
		}
		for (int j = 1; j < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; j += 0)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.CFGIOIGOIFQ().QLJEQBGLPOE(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[j]);
			string str = string.Empty;
			if (fekoiojqnkh.EDGHHFPMHBL() == -41 && fekoiojqnkh.QKNEIJQHGCB % 122 > 0)
			{
				str = "Guild Request" + (fekoiojqnkh.QKNEIJQHGCB % -70).ToString();
			}
			this.QILHFPGMMBC[j].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.NMPCLCEQJMP("[o]" + fekoiojqnkh.EDGHHFPMHBL().ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = true;
		}
		this.INEBCFFFKEG = HOJFLOOQQBP;
		this.GHQGFDLNGQL = EIDCLNMCJQM;
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.JMBGHGKFDFL = MOLGPEDLJQH;
		if (QNDCNGEPJON)
		{
			this.OMOCMQJGDDI.SetActive(false);
		}
		else
		{
			this.OMOCMQJGDDI.SetActive(true);
		}
		this.HLFELPLQLBC.SetActive(false);
		this.QPPGQJFBPMH.PHELNLKIKEG();
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayForward();
		this.JDPBPOKJFQK[1].BGBMIEJJQKC = 1262f;
		this.JDPBPOKJFQK[0].enabled = true;
	}

	// Token: 0x060040AD RID: 16557 RVA: 0x0001AF09 File Offset: 0x00019109
	private void PCNKNOQBBLB()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x060040AE RID: 16558 RVA: 0x0001B41D File Offset: 0x0001961D
	public void SelectMove(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.QOQONHOOLNE.NGQIEFLKNPJ(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.HideFromMoves();
	}

	// Token: 0x060040AF RID: 16559 RVA: 0x0001B43C File Offset: 0x0001963C
	public void QGJPMKPOGKN()
	{
		this.JDPBPOKJFQK[1].duration = 1550f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("???", 1238f);
	}

	// Token: 0x060040B0 RID: 16560 RVA: 0x001FB040 File Offset: 0x001F9240
	public void EQMIOOOIIJL(int DBPKNCDGGEP)
	{
		if (this.INEBCFFFKEG)
		{
			GNDQBCBDHKD.BJLGEDCPENQ().FINKNNEPIHN(DBPKNCDGGEP, this.GHQGFDLNGQL);
			this.DPBQLJNPIFB();
		}
		else if (this.JMBGHGKFDFL)
		{
			this.BOFLINKBPOC = DBPKNCDGGEP;
			this.KMBFPJCMBIH();
		}
		else
		{
			INFJMNPKNQF.CFGIOIGOIFQ().NGQIEFLKNPJ(this.MKBCKPPCIQO, DBPKNCDGGEP, 1);
			this.Hide();
		}
	}

	// Token: 0x060040B1 RID: 16561 RVA: 0x001FB0A0 File Offset: 0x001F92A0
	private void QMJPMPCNJQJ()
	{
		for (int i = 0; i < 6; i++)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)8, true);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
			this.CMLGJIEIDBC[i].PIDLOFMIEFQ = string.Empty;
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.KQPKDONQCHC(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[this.BOFLINKBPOC - 0]);
		for (int j = 1; j < fekoiojqnkh.EEILBMOOJHJ.Length; j += 0)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = false;
			BKKHLBCLPJM bkkhlbclpjm = this.CMLGJIEIDBC[j];
			string[] array = new string[0];
			array[0] = fekoiojqnkh.EEILBMOOJHJ[j].DHFJQINPMBH();
			array[1] = "!\r\n";
			array[8] = fekoiojqnkh.EEILBMOOJHJ[j].LIQCECMEOIJ.ToString();
			array[7] = "_FogColor";
			array[4] = fekoiojqnkh.EEILBMOOJHJ[j].PPPDMFPGPDD().ToString();
			bkkhlbclpjm.LKPOBCBOFIC(string.Concat(array));
		}
		this.JDPBPOKJFQK[0].duration = 1696f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].duration = 895f;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x060040B2 RID: 16562 RVA: 0x0001B47B File Offset: 0x0001967B
	private void KGMODOQMCOG()
	{
		this.JDPBPOKJFQK[1].duration = 1983f;
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("[", 246f);
	}

	// Token: 0x060040B3 RID: 16563 RVA: 0x001FB21C File Offset: 0x001F941C
	public void BQLIIQIIMDH(Guid EIDCLNMCJQM, bool MOLGPEDLJQH = false, bool QNDCNGEPJON = true, KGQECFKLKOP.IJHPPMDDKIE PDIBIIKFBDH = null, bool HOJFLOOQQBP = false)
	{
		for (int i = 0; i < 6; i++)
		{
			this.QILHFPGMMBC[i].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = null;
			this.QILHFPGMMBC[i].GetComponent<BoxCollider>().enabled = false;
		}
		for (int j = 0; j < HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK.Count; j++)
		{
			KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[j]);
			string str = string.Empty;
			if (fekoiojqnkh.BEQHNFFEHMQ == 201 && fekoiojqnkh.QKNEIJQHGCB % 28 > 0)
			{
				str = "_" + (fekoiojqnkh.QKNEIJQHGCB % 28).ToString();
			}
			this.QILHFPGMMBC[j].GetComponent<JLMPBLMOICG>().GOIHJQNMMJD = GFHGEJNHLFQ.QOQONHOOLNE.CPFJEOGMHOD("Big/" + fekoiojqnkh.BEQHNFFEHMQ.ToString() + str, GFHGEJNHLFQ.DBKNKGJJMJI.Pokemon);
			this.QILHFPGMMBC[j].GetComponent<BoxCollider>().enabled = true;
		}
		this.INEBCFFFKEG = HOJFLOOQQBP;
		this.GHQGFDLNGQL = EIDCLNMCJQM;
		this.MKBCKPPCIQO = PDIBIIKFBDH;
		this.JMBGHGKFDFL = MOLGPEDLJQH;
		if (QNDCNGEPJON)
		{
			this.OMOCMQJGDDI.SetActive(true);
		}
		else
		{
			this.OMOCMQJGDDI.SetActive(false);
		}
		this.HLFELPLQLBC.SetActive(true);
		this.QPPGQJFBPMH.NDIJIFHOMJC();
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
		this.JDPBPOKJFQK[1].BGBMIEJJQKC = 0f;
		this.JDPBPOKJFQK[1].enabled = false;
	}

	// Token: 0x060040B4 RID: 16564 RVA: 0x0001B4BA File Offset: 0x000196BA
	public void FEGGQFQHBHN()
	{
		this.JDPBPOKJFQK[0].duration = 1081f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		base.Invoke("_Texture1", 1555f);
	}

	// Token: 0x060040B5 RID: 16565 RVA: 0x0001B4F9 File Offset: 0x000196F9
	public void QPNHQGOIMKD(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.IPOKOKIJECO().HBOJGONPNJF(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.MPCMPGKJMKE();
	}

	// Token: 0x060040B6 RID: 16566 RVA: 0x0001AF09 File Offset: 0x00019109
	private void HideWinow()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x060040B7 RID: 16567 RVA: 0x0001B518 File Offset: 0x00019718
	public void BMFLBIEKMLO(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.IPOKOKIJECO().HBOJGONPNJF(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.NIMHGIBNKLM();
	}

	// Token: 0x060040B8 RID: 16568 RVA: 0x0001AF09 File Offset: 0x00019109
	private void OQOCEEELNOC()
	{
		this.HLFELPLQLBC.SetActive(false);
	}

	// Token: 0x060040B9 RID: 16569 RVA: 0x001FB3B8 File Offset: 0x001F95B8
	private void GHNKIDFIHIM()
	{
		for (int i = 0; i < 4; i++)
		{
			this.PDFOJLELNHP[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			this.PDFOJLELNHP[i].GetComponent<BoxCollider>().enabled = false;
			this.CMLGJIEIDBC[i].PIDLOFMIEFQ = string.Empty;
		}
		KGQECFKLKOP.FEKOIOJQNKH fekoiojqnkh = HFCMDEQKCKH.QOQONHOOLNE.PEJHBEBOCOJ(HFCMDEQKCKH.QOQONHOOLNE.LIJHMFEGCCK[this.BOFLINKBPOC - 1]);
		for (int j = 0; j < fekoiojqnkh.EEILBMOOJHJ.Length; j++)
		{
			this.PDFOJLELNHP[j].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			this.PDFOJLELNHP[j].GetComponent<BoxCollider>().enabled = true;
			this.CMLGJIEIDBC[j].PIDLOFMIEFQ = string.Concat(new string[]
			{
				fekoiojqnkh.EEILBMOOJHJ[j].FBCKQEDONJK,
				"\r\nPP ",
				fekoiojqnkh.EEILBMOOJHJ[j].LIQCECMEOIJ.ToString(),
				"/",
				fekoiojqnkh.EEILBMOOJHJ[j].JPLIFCNPICK.ToString()
			});
		}
		this.JDPBPOKJFQK[0].duration = 0.2f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[1].enabled = true;
		this.JDPBPOKJFQK[1].duration = 0.01f;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x060040BA RID: 16570 RVA: 0x001FB534 File Offset: 0x001F9734
	public void CNGKOONQKDF()
	{
		this.JDPBPOKJFQK[1].duration = 1106f;
		this.JDPBPOKJFQK[0].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[0].duration = 920f;
		this.JDPBPOKJFQK[0].enabled = true;
		this.JDPBPOKJFQK[0].PlayForward();
	}

	// Token: 0x060040BB RID: 16571 RVA: 0x0001B537 File Offset: 0x00019737
	public void ENIQJHHJMPN(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.DOGEBLQHDHI().NGQIEFLKNPJ(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.JFFBDFIDMBD();
	}

	// Token: 0x060040BC RID: 16572 RVA: 0x0001B3BF File Offset: 0x000195BF
	public void HCDPEELIJIL(int DBPKNCDGGEP)
	{
		INFJMNPKNQF.FPQNIQELKMC().HBOJGONPNJF(this.MKBCKPPCIQO, this.BOFLINKBPOC, DBPKNCDGGEP);
		this.KGBGEMOBCEO();
	}

	// Token: 0x060040BD RID: 16573 RVA: 0x001FB59C File Offset: 0x001F979C
	public void FGLEDCNEELD()
	{
		this.JDPBPOKJFQK[0].duration = 19f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[0].PlayReverse();
		this.JDPBPOKJFQK[1].duration = 1642f;
		this.JDPBPOKJFQK[1].enabled = false;
		this.JDPBPOKJFQK[1].PlayForward();
	}

	// Token: 0x060040BE RID: 16574 RVA: 0x0001B1CB File Offset: 0x000193CB
	private void IMIICGMJIJK()
	{
		this.HLFELPLQLBC.SetActive(true);
	}

	// Token: 0x04000E25 RID: 3621
	public CFDMNELIJLO[] QILHFPGMMBC;

	// Token: 0x04000E26 RID: 3622
	public CFDMNELIJLO[] PDFOJLELNHP;

	// Token: 0x04000E27 RID: 3623
	public BKKHLBCLPJM[] CMLGJIEIDBC;

	// Token: 0x04000E28 RID: 3624
	public EPIJJNOIKEK[] JDPBPOKJFQK;

	// Token: 0x04000E29 RID: 3625
	public KIQKEMNELKN QPPGQJFBPMH;

	// Token: 0x04000E2A RID: 3626
	public GameObject HLFELPLQLBC;

	// Token: 0x04000E2B RID: 3627
	public GameObject OMOCMQJGDDI;

	// Token: 0x04000E2C RID: 3628
	[HideInInspector]
	public EventDelegate EKOLJNGBDKM;

	// Token: 0x04000E2D RID: 3629
	private bool JMBGHGKFDFL;

	// Token: 0x04000E2E RID: 3630
	private KGQECFKLKOP.IJHPPMDDKIE MKBCKPPCIQO;

	// Token: 0x04000E2F RID: 3631
	private bool INEBCFFFKEG;

	// Token: 0x04000E30 RID: 3632
	private Guid GHQGFDLNGQL;

	// Token: 0x04000E31 RID: 3633
	private int BOFLINKBPOC = 1;
}

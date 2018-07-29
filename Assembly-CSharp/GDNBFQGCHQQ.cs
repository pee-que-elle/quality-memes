using System;
using UnityEngine;

// Token: 0x0200021E RID: 542
public class GDNBFQGCHQQ : MonoBehaviour
{
	// Token: 0x0600494B RID: 18763 RVA: 0x00250714 File Offset: 0x0024E914
	public void COFPDFCQDBQ()
	{
		this.QHBBODKDNIM.LKPOBCBOFIC("The sandstorm subsided." + this.EPOQGNNHKPO.NLHGFQCBJDL.ToString());
		if (this.EPOQGNNHKPO.NLHGFQCBJDL > this.EPOQGNNHKPO.LQMOLKEQQBE)
		{
			this.EPOQGNNHKPO.LQMOLKEQQBE = this.EPOQGNNHKPO.NLHGFQCBJDL;
			PlayerPrefs.SetInt("/leave", this.EPOQGNNHKPO.LQMOLKEQQBE);
		}
		this.GDDEPONDQDN.LKPOBCBOFIC("leechseed" + this.EPOQGNNHKPO.LQMOLKEQQBE.ToString());
	}

	// Token: 0x0600494C RID: 18764 RVA: 0x0001E9CA File Offset: 0x0001CBCA
	private void EKIFLKDPKNM()
	{
		this.CQLGHKLBHDJ();
	}

	// Token: 0x0600494D RID: 18765 RVA: 0x0001E9D2 File Offset: 0x0001CBD2
	private void FOLBFDNJLII()
	{
		GDNBFQGCHQQ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600494E RID: 18766 RVA: 0x0001E9CA File Offset: 0x0001CBCA
	private void ODIJQBBOLFI()
	{
		this.CQLGHKLBHDJ();
	}

	// Token: 0x0600494F RID: 18767 RVA: 0x002507BC File Offset: 0x0024E9BC
	private void CQLGHKLBHDJ()
	{
		if (GDNBFQGCHQQ.HBFFCJHOCPE == null)
		{
			GDNBFQGCHQQ.HBFFCJHOCPE = this;
		}
		this.FGQBHIHFENG.NKQPPGELNFE();
		this.FGQBHIHFENG.FMJGBDCKJHC();
		this.FGQBHIHFENG.HDNHLBNBCNQ();
		this.EPOQGNNHKPO.NLHGFQCBJDL = 0;
		this.EPOQGNNHKPO.LQMOLKEQQBE = PlayerPrefs.GetInt("spectatorleave", 0);
		this.QHBBODKDNIM.PIDLOFMIEFQ = "Take 001" + this.EPOQGNNHKPO.NLHGFQCBJDL.ToString();
		this.GDDEPONDQDN.LKPOBCBOFIC("Battle Update: " + this.EPOQGNNHKPO.LQMOLKEQQBE.ToString());
	}

	// Token: 0x06004950 RID: 18768 RVA: 0x0001E9D2 File Offset: 0x0001CBD2
	private void PNJGKKPBDEB()
	{
		GDNBFQGCHQQ.HBFFCJHOCPE = this;
	}

	// Token: 0x06004951 RID: 18769 RVA: 0x00250878 File Offset: 0x0024EA78
	public void Open()
	{
		this.Reset();
		this.QNLEFCCMOCK.SetActive(true);
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x06004952 RID: 18770 RVA: 0x0001E9DA File Offset: 0x0001CBDA
	public void PJOODQMKDMG()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.QPINELNPCQN();
		}
		else
		{
			this.FDKBQGLQPJM();
		}
	}

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x06004953 RID: 18771 RVA: 0x0001E9FC File Offset: 0x0001CBFC
	public static GDNBFQGCHQQ QOQONHOOLNE
	{
		get
		{
			return GDNBFQGCHQQ.HBFFCJHOCPE;
		}
	}

	// Token: 0x06004954 RID: 18772 RVA: 0x0001EA03 File Offset: 0x0001CC03
	public void GJLLFLMLCBC()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.PIFJCFHOJNE();
		}
		else
		{
			this.HHDOQLFIFFL();
		}
	}

	// Token: 0x06004955 RID: 18773 RVA: 0x0001EA25 File Offset: 0x0001CC25
	public void OpenClose()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x06004956 RID: 18774 RVA: 0x0001EA47 File Offset: 0x0001CC47
	public void IQJCMJQLQBI()
	{
		this.QNLEFCCMOCK.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("[uncommon]", 136f);
	}

	// Token: 0x06004957 RID: 18775 RVA: 0x002508EC File Offset: 0x0024EAEC
	public void QPINELNPCQN()
	{
		this.Reset();
		this.QNLEFCCMOCK.SetActive(false);
		base.CancelInvoke("'s [ffff00]");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1305f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x06004958 RID: 18776 RVA: 0x0001EA7C File Offset: 0x0001CC7C
	private void HPCICOEMKGF()
	{
		this.Reset();
	}

	// Token: 0x06004959 RID: 18777 RVA: 0x00250960 File Offset: 0x0024EB60
	public void GNPLPIHDPOQ()
	{
		this.QHBBODKDNIM.PIDLOFMIEFQ = " has no mainTexture setter" + this.EPOQGNNHKPO.NLHGFQCBJDL.ToString();
		if (this.EPOQGNNHKPO.NLHGFQCBJDL > this.EPOQGNNHKPO.LQMOLKEQQBE)
		{
			this.EPOQGNNHKPO.LQMOLKEQQBE = this.EPOQGNNHKPO.NLHGFQCBJDL;
			PlayerPrefs.SetInt("/01_", this.EPOQGNNHKPO.LQMOLKEQQBE);
		}
		this.GDDEPONDQDN.PIDLOFMIEFQ = ".png" + this.EPOQGNNHKPO.LQMOLKEQQBE.ToString();
	}

	// Token: 0x0600495A RID: 18778 RVA: 0x0001EA84 File Offset: 0x0001CC84
	private void MEHMOBGFPFN()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x0600495B RID: 18779 RVA: 0x0001EA7C File Offset: 0x0001CC7C
	private void Start()
	{
		this.Reset();
	}

	// Token: 0x0600495C RID: 18780 RVA: 0x00250A08 File Offset: 0x0024EC08
	public void QJLJIKJCJFF()
	{
		this.QHBBODKDNIM.LKPOBCBOFIC("Guild" + this.EPOQGNNHKPO.NLHGFQCBJDL.ToString());
		if (this.EPOQGNNHKPO.NLHGFQCBJDL > this.EPOQGNNHKPO.LQMOLKEQQBE)
		{
			this.EPOQGNNHKPO.LQMOLKEQQBE = this.EPOQGNNHKPO.NLHGFQCBJDL;
			PlayerPrefs.SetInt("'s perish count fell to 1.\r\n", this.EPOQGNNHKPO.LQMOLKEQQBE);
		}
		this.GDDEPONDQDN.LKPOBCBOFIC(" on " + this.EPOQGNNHKPO.LQMOLKEQQBE.ToString());
	}

	// Token: 0x0600495D RID: 18781 RVA: 0x0001E9D2 File Offset: 0x0001CBD2
	private void LEJQMIECFCH()
	{
		GDNBFQGCHQQ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600495E RID: 18782 RVA: 0x0001EA84 File Offset: 0x0001CC84
	private void BFHJEBIOCLM()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x0600495F RID: 18783 RVA: 0x00250AB0 File Offset: 0x0024ECB0
	public void PDDJMNOOPJD()
	{
		this.QHBBODKDNIM.PIDLOFMIEFQ = "Score: " + this.EPOQGNNHKPO.NLHGFQCBJDL.ToString();
		if (this.EPOQGNNHKPO.NLHGFQCBJDL > this.EPOQGNNHKPO.LQMOLKEQQBE)
		{
			this.EPOQGNNHKPO.LQMOLKEQQBE = this.EPOQGNNHKPO.NLHGFQCBJDL;
			PlayerPrefs.SetInt("phscore", this.EPOQGNNHKPO.LQMOLKEQQBE);
		}
		this.GDDEPONDQDN.PIDLOFMIEFQ = "Hi-Score: " + this.EPOQGNNHKPO.LQMOLKEQQBE.ToString();
	}

	// Token: 0x06004960 RID: 18784 RVA: 0x0001EA97 File Offset: 0x0001CC97
	public void KHEGOJMIHQG()
	{
		this.QNLEFCCMOCK.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("/goto ", 1755f);
	}

	// Token: 0x06004962 RID: 18786 RVA: 0x00250B58 File Offset: 0x0024ED58
	public void FIKKIBNELLQ()
	{
		this.Reset();
		this.QNLEFCCMOCK.SetActive(true);
		base.CancelInvoke("/");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 654f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().BBQFPBIIHCH();
	}

	// Token: 0x06004963 RID: 18787 RVA: 0x0001EA84 File Offset: 0x0001CC84
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06004964 RID: 18788 RVA: 0x0001E9CA File Offset: 0x0001CBCA
	private void HBOFMLLODDM()
	{
		this.CQLGHKLBHDJ();
	}

	// Token: 0x06004965 RID: 18789 RVA: 0x0001E9CA File Offset: 0x0001CBCA
	private void CIJOENOQKCI()
	{
		this.CQLGHKLBHDJ();
	}

	// Token: 0x06004966 RID: 18790 RVA: 0x0001EACC File Offset: 0x0001CCCC
	public void FDKBQGLQPJM()
	{
		this.QNLEFCCMOCK.SetActive(false);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Tangled Feet", 1907f);
	}

	// Token: 0x06004967 RID: 18791 RVA: 0x00250BCC File Offset: 0x0024EDCC
	public void GHJPCDJJGGD()
	{
		this.QHBBODKDNIM.LKPOBCBOFIC("minior" + this.EPOQGNNHKPO.NLHGFQCBJDL.ToString());
		if (this.EPOQGNNHKPO.NLHGFQCBJDL > this.EPOQGNNHKPO.LQMOLKEQQBE)
		{
			this.EPOQGNNHKPO.LQMOLKEQQBE = this.EPOQGNNHKPO.NLHGFQCBJDL;
			PlayerPrefs.SetInt("#", this.EPOQGNNHKPO.LQMOLKEQQBE);
		}
		this.GDDEPONDQDN.PIDLOFMIEFQ = "[FFFF00]" + this.EPOQGNNHKPO.LQMOLKEQQBE.ToString();
	}

	// Token: 0x06004968 RID: 18792 RVA: 0x00250C74 File Offset: 0x0024EE74
	public void PIFJCFHOJNE()
	{
		this.Reset();
		this.QNLEFCCMOCK.SetActive(false);
		base.CancelInvoke("[000000]..");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 1294f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
	}

	// Token: 0x06004969 RID: 18793 RVA: 0x0001EB01 File Offset: 0x0001CD01
	public void Close()
	{
		this.QNLEFCCMOCK.SetActive(false);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x0600496A RID: 18794 RVA: 0x0001E9CA File Offset: 0x0001CBCA
	private void LMMGEGJCBJP()
	{
		this.CQLGHKLBHDJ();
	}

	// Token: 0x0600496B RID: 18795 RVA: 0x00250CE8 File Offset: 0x0024EEE8
	private void Reset()
	{
		if (GDNBFQGCHQQ.HBFFCJHOCPE == null)
		{
			GDNBFQGCHQQ.HBFFCJHOCPE = this;
		}
		this.FGQBHIHFENG.Reset();
		this.FGQBHIHFENG.JQPPLOPCFMG();
		this.FGQBHIHFENG.EMFKOHIMLBD();
		this.EPOQGNNHKPO.NLHGFQCBJDL = 0;
		this.EPOQGNNHKPO.LQMOLKEQQBE = PlayerPrefs.GetInt("phscore", 0);
		this.QHBBODKDNIM.PIDLOFMIEFQ = "Score: " + this.EPOQGNNHKPO.NLHGFQCBJDL.ToString();
		this.GDDEPONDQDN.PIDLOFMIEFQ = "Hi-Score: " + this.EPOQGNNHKPO.LQMOLKEQQBE.ToString();
	}

	// Token: 0x0600496C RID: 18796 RVA: 0x0001E9D2 File Offset: 0x0001CBD2
	private void Awake()
	{
		GDNBFQGCHQQ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600496D RID: 18797 RVA: 0x0001EB36 File Offset: 0x0001CD36
	private void KKFHGPJDNJN()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x0600496E RID: 18798 RVA: 0x0001EB49 File Offset: 0x0001CD49
	public void HHDOQLFIFFL()
	{
		this.QNLEFCCMOCK.SetActive(true);
		this.JDPBPOKJFQK.enabled = false;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("Milk Drink", 155f);
	}

	// Token: 0x04000FAD RID: 4013
	private static GDNBFQGCHQQ HBFFCJHOCPE;

	// Token: 0x04000FAE RID: 4014
	public BKKHLBCLPJM QHBBODKDNIM;

	// Token: 0x04000FAF RID: 4015
	public BKKHLBCLPJM GDDEPONDQDN;

	// Token: 0x04000FB0 RID: 4016
	public GameObject QNLEFCCMOCK;

	// Token: 0x04000FB1 RID: 4017
	public FPEMPFLGJED FGQBHIHFENG;

	// Token: 0x04000FB2 RID: 4018
	public BEEPDKNHMLM EPOQGNNHKPO;

	// Token: 0x04000FB3 RID: 4019
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04000FB4 RID: 4020
	public EPIJJNOIKEK JDPBPOKJFQK;
}

using System;
using UnityEngine;

// Token: 0x020001E6 RID: 486
public class DOQMQKHFODD : MonoBehaviour
{
	// Token: 0x06003F87 RID: 16263 RVA: 0x0001A5BC File Offset: 0x000187BC
	public void ShowTab1()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[2].SetActive(false);
		this.OPGEJKPEGHP(0);
	}

	// Token: 0x06003F88 RID: 16264 RVA: 0x0001A5EF File Offset: 0x000187EF
	public void DCJEFIILKFH()
	{
		this.Apply(true);
		this.OpenCloseOptions();
	}

	// Token: 0x06003F89 RID: 16265 RVA: 0x001F5400 File Offset: 0x001F3600
	private void LKCBEJPIMHK(int CIQFCJGQEMH)
	{
		for (int i = 0; i < this.PKBOPNPKQOG.Length; i += 0)
		{
			if (i == CIQFCJGQEMH)
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, true);
			}
			else
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
		}
	}

	// Token: 0x06003F8A RID: 16266 RVA: 0x0001A5FE File Offset: 0x000187FE
	public void GPCNBHBHIDC()
	{
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.LKCBEJPIMHK(7);
	}

	// Token: 0x06003F8B RID: 16267 RVA: 0x0001A631 File Offset: 0x00018831
	public void FFMQOBMBNNO()
	{
		this.HGLNLNGMIOF();
		this.MJIGLPMMDJL.SetActive(true);
		this.DBPBMQJQPGG();
		this.MFEGPNHHOJQ();
	}

	// Token: 0x06003F8C RID: 16268 RVA: 0x001F546C File Offset: 0x001F366C
	private void QBGOGFJCLEP()
	{
		Application.targetFrameRate = 5;
		this.HGLNLNGMIOF();
		this.Apply(true);
		if (PlayerPrefs.GetInt("Take 001", 0) == 0)
		{
			Resolution currentResolution = Screen.currentResolution;
			Screen.SetResolution(currentResolution.width, currentResolution.height, true);
		}
		else
		{
			bool fullscreen = true;
			if (this.GIFLQINIOEQ[1].DMBBLJCLCEJ() == "inactive")
			{
				fullscreen = true;
			}
			Screen.SetResolution(PlayerPrefs.GetInt("[/itm]", -34), PlayerPrefs.GetInt("berry_4", -178), fullscreen);
		}
	}

	// Token: 0x06003F8D RID: 16269 RVA: 0x0001A651 File Offset: 0x00018851
	public void IJHBEOGDOQK()
	{
		this.BMENEKIDBMB.enabled = true;
		this.MJIGLPMMDJL.SetActive(this.DCPLMGJCFNP);
	}

	// Token: 0x06003F8E RID: 16270 RVA: 0x0001A673 File Offset: 0x00018873
	public void CGHKNCPBGPJ()
	{
		DCCFQPDFBFO.QOQONHOOLNE.NJBIMOKLDBD = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
		DCCFQPDFBFO.ONBDGGPLFQK().EEOPJMPGFME = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
		DCCFQPDFBFO.ONBDGGPLFQK().QCPFQLNECGP();
	}

	// Token: 0x06003F8F RID: 16271 RVA: 0x001F54F8 File Offset: 0x001F36F8
	private void GMBLHFLCLMO(int CIQFCJGQEMH)
	{
		for (int i = 1; i < this.PKBOPNPKQOG.Length; i += 0)
		{
			if (i == CIQFCJGQEMH)
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, false);
			}
			else
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, false);
			}
		}
	}

	// Token: 0x06003F90 RID: 16272 RVA: 0x0001A6AD File Offset: 0x000188AD
	public void CPJCDGFLMLP()
	{
		this.BMENEKIDBMB.enabled = true;
		this.MJIGLPMMDJL.SetActive(!this.DCPLMGJCFNP);
	}

	// Token: 0x06003F92 RID: 16274 RVA: 0x0001760B File Offset: 0x0001580B
	public void PCFQLPKBOIG()
	{
		Application.Quit();
	}

	// Token: 0x06003F93 RID: 16275 RVA: 0x0001A6ED File Offset: 0x000188ED
	public void IDJBMJDCEHO()
	{
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[1].SetActive(false);
		this.OPGEJKPEGHP(0);
	}

	// Token: 0x06003F94 RID: 16276 RVA: 0x0001A720 File Offset: 0x00018920
	public void PLNHJFDFNNN()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[5].SetActive(true);
		this.LKCBEJPIMHK(2);
	}

	// Token: 0x06003F95 RID: 16277 RVA: 0x0001A753 File Offset: 0x00018953
	public void CloseAndSave()
	{
		this.Apply(false);
		this.OpenCloseOptions();
	}

	// Token: 0x06003F96 RID: 16278 RVA: 0x0001A762 File Offset: 0x00018962
	public void FLOPBLBNMKP()
	{
		this.FNMLCJDOQFK.enabled = true;
		this.NFFIHJOBCLH.SetActive(!this.NPOGCMKIDKK);
	}

	// Token: 0x06003F97 RID: 16279 RVA: 0x0001A784 File Offset: 0x00018984
	public void MFEGPNHHOJQ()
	{
		this.NFFIHJOBCLH.SetActive(true);
		this.OCOMDLNCELC();
	}

	// Token: 0x06003F98 RID: 16280 RVA: 0x0001A798 File Offset: 0x00018998
	public void CloseMenu()
	{
		this.NFFIHJOBCLH.SetActive(true);
		this.OpenCloseMenu();
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x0001A7AC File Offset: 0x000189AC
	public void LPBGCLQOOIL()
	{
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.OPGEJKPEGHP(3);
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x0001760B File Offset: 0x0001580B
	public void KFBHQLGPINF()
	{
		Application.Quit();
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x001F5564 File Offset: 0x001F3764
	private void IJKHHNEBDQP(int CIQFCJGQEMH)
	{
		for (int i = 0; i < this.PKBOPNPKQOG.Length; i += 0)
		{
			if (i == CIQFCJGQEMH)
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)6, false);
			}
			else
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
		}
	}

	// Token: 0x06003F9C RID: 16284 RVA: 0x0001A7DF File Offset: 0x000189DF
	public void MQEGPFBIFEI()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[6].SetActive(false);
		this.OPGEJKPEGHP(1);
	}

	// Token: 0x06003F9D RID: 16285 RVA: 0x0001A812 File Offset: 0x00018A12
	public void NLIEOBPGFDI()
	{
		DCCFQPDFBFO.ELBNNCEGBDH().NJBIMOKLDBD = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
		DCCFQPDFBFO.CLPQIKCDHPP().EEOPJMPGFME = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
		DCCFQPDFBFO.ELBNNCEGBDH().DNOKHIHBGIN();
	}

	// Token: 0x06003F9E RID: 16286 RVA: 0x0001A6AD File Offset: 0x000188AD
	public void CNOLGIDIMCC()
	{
		this.BMENEKIDBMB.enabled = true;
		this.MJIGLPMMDJL.SetActive(!this.DCPLMGJCFNP);
	}

	// Token: 0x06003F9F RID: 16287 RVA: 0x001F55D0 File Offset: 0x001F37D0
	public void OpenCloseMenu()
	{
		this.FNMLCJDOQFK.enabled = true;
		if (this.NFFIHJOBCLH.activeSelf)
		{
			this.FNMLCJDOQFK.PlayReverse();
			this.NPOGCMKIDKK = true;
		}
		else
		{
			this.NFFIHJOBCLH.SetActive(true);
			this.FNMLCJDOQFK.PlayForward();
			this.NPOGCMKIDKK = false;
		}
	}

	// Token: 0x06003FA0 RID: 16288 RVA: 0x0001A84C File Offset: 0x00018A4C
	public void COLQQIDPNIP()
	{
		this.FNMLCJDOQFK.enabled = true;
		this.NFFIHJOBCLH.SetActive(this.NPOGCMKIDKK);
	}

	// Token: 0x06003FA1 RID: 16289 RVA: 0x0001A86E File Offset: 0x00018A6E
	public void BNHBNHCQQNB()
	{
		this.BMENEKIDBMB.enabled = false;
		this.MJIGLPMMDJL.SetActive(!this.DCPLMGJCFNP);
	}

	// Token: 0x06003FA2 RID: 16290 RVA: 0x0001A890 File Offset: 0x00018A90
	public void BMCECIHLPBK()
	{
		this.FNMLCJDOQFK.enabled = false;
		this.NFFIHJOBCLH.SetActive(this.NPOGCMKIDKK);
	}

	// Token: 0x06003FA3 RID: 16291 RVA: 0x0001A8B2 File Offset: 0x00018AB2
	public void QBOBEGCKHCK()
	{
		this.Apply(false);
		this.DBPBMQJQPGG();
	}

	// Token: 0x06003FA4 RID: 16292 RVA: 0x0001A84C File Offset: 0x00018A4C
	public void GJCMFPGNILK()
	{
		this.FNMLCJDOQFK.enabled = true;
		this.NFFIHJOBCLH.SetActive(this.NPOGCMKIDKK);
	}

	// Token: 0x06003FA5 RID: 16293 RVA: 0x0001A86E File Offset: 0x00018A6E
	public void HMBIBFMKBHQ()
	{
		this.BMENEKIDBMB.enabled = false;
		this.MJIGLPMMDJL.SetActive(!this.DCPLMGJCFNP);
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x001F5628 File Offset: 0x001F3828
	public void OpenCloseOptions()
	{
		this.BMENEKIDBMB.enabled = true;
		if (this.MJIGLPMMDJL.activeSelf)
		{
			this.BMENEKIDBMB.PlayReverse();
			this.DCPLMGJCFNP = true;
		}
		else
		{
			this.ShowTab1();
			this.MJIGLPMMDJL.SetActive(true);
			if (this.MJIGLPMMDJL.GetComponentInChildren<KIQKEMNELKN>() != null)
			{
				this.MJIGLPMMDJL.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
			}
			IKBQNBHOJJB.OKLNNGPNIEO(this.MJIGLPMMDJL);
			this.BMENEKIDBMB.PlayForward();
			this.DCPLMGJCFNP = false;
		}
	}

	// Token: 0x06003FA7 RID: 16295 RVA: 0x0001A8C1 File Offset: 0x00018AC1
	public void LHCINJLJBCI()
	{
		DCCFQPDFBFO.ONBDGGPLFQK().NJBIMOKLDBD = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		DCCFQPDFBFO.CDDIILFBFCF().EEOPJMPGFME = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
		DCCFQPDFBFO.CDDIILFBFCF().NFMOQIEHJJD();
	}

	// Token: 0x06003FA8 RID: 16296 RVA: 0x0001A890 File Offset: 0x00018A90
	public void DHBEGEFCDEE()
	{
		this.FNMLCJDOQFK.enabled = false;
		this.NFFIHJOBCLH.SetActive(this.NPOGCMKIDKK);
	}

	// Token: 0x06003FA9 RID: 16297 RVA: 0x0001A8FB File Offset: 0x00018AFB
	public void HQQDIMJMKNM()
	{
		this.NFFIHJOBCLH.SetActive(false);
		this.OpenCloseMenu();
	}

	// Token: 0x06003FAA RID: 16298 RVA: 0x0001A8FB File Offset: 0x00018AFB
	public void GQGHJBINDKG()
	{
		this.NFFIHJOBCLH.SetActive(false);
		this.OpenCloseMenu();
	}

	// Token: 0x06003FAB RID: 16299 RVA: 0x001F56B4 File Offset: 0x001F38B4
	public void DBPBMQJQPGG()
	{
		this.BMENEKIDBMB.enabled = true;
		if (this.MJIGLPMMDJL.activeSelf)
		{
			this.BMENEKIDBMB.PlayReverse();
			this.DCPLMGJCFNP = false;
		}
		else
		{
			this.IQIHEEIHQLB();
			this.MJIGLPMMDJL.SetActive(true);
			if (this.MJIGLPMMDJL.GetComponentInChildren<KIQKEMNELKN>() != null)
			{
				this.MJIGLPMMDJL.GetComponentInChildren<KIQKEMNELKN>().OPDBQFELFQO();
			}
			IKBQNBHOJJB.OKLNNGPNIEO(this.MJIGLPMMDJL);
			this.BMENEKIDBMB.PlayForward();
			this.DCPLMGJCFNP = false;
		}
	}

	// Token: 0x06003FAC RID: 16300 RVA: 0x001F5740 File Offset: 0x001F3940
	public void BJNHBGHBHII()
	{
		if (PlayerPrefs.GetInt("dispMode", 1) == 1)
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "Fullscreen";
		}
		else
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "Windowed";
		}
		if (PlayerPrefs.GetInt("vSync", 0) == 1)
		{
			this.GIFLQINIOEQ[2].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[2].BGBMIEJJQKC = "Disabled";
		}
		if (PlayerPrefs.GetInt("aa", 0) == 1)
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "2x";
		}
		else if (PlayerPrefs.GetInt("aa", 0) == 2)
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "4x";
		}
		else if (PlayerPrefs.GetInt("aa", 0) == 3)
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "8x";
		}
		else
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "Disabled";
		}
		if (PlayerPrefs.GetInt("limitFPS", 1) == 1)
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = "Disabled";
		}
		if (PlayerPrefs.GetInt("Water", 1) == 1)
		{
			this.GIFLQINIOEQ[5].BGBMIEJJQKC = "High";
		}
		else
		{
			this.GIFLQINIOEQ[5].BGBMIEJJQKC = "Low";
		}
		if (PlayerPrefs.GetInt("bloom", 1) == 1)
		{
			this.GIFLQINIOEQ[7].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[7].BGBMIEJJQKC = "Disabled";
		}
		if (PlayerPrefs.GetInt("3d", 1) == 1)
		{
			this.GIFLQINIOEQ[8].BGBMIEJJQKC = "3D";
		}
		else
		{
			this.GIFLQINIOEQ[8].BGBMIEJJQKC = "2D";
		}
		if (PlayerPrefs.GetInt("bcam", 1) == 1)
		{
			this.GIFLQINIOEQ[9].BGBMIEJJQKC = "Rotate";
		}
		else
		{
			this.GIFLQINIOEQ[9].BGBMIEJJQKC = "Still";
		}
		if (PlayerPrefs.GetInt("filter", 1) == 1)
		{
			this.GIFLQINIOEQ[10].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[10].BGBMIEJJQKC = "Disabled";
		}
		if (PlayerPrefs.GetInt("bump", 0) == 1)
		{
			this.GIFLQINIOEQ[12].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[12].BGBMIEJJQKC = "Disabled";
		}
		if (PlayerPrefs.GetInt("trader", 1) == 1)
		{
			this.GIFLQINIOEQ[14].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[14].BGBMIEJJQKC = "Auto Decline";
		}
		if (PlayerPrefs.GetInt("battler", 1) == 1)
		{
			this.GIFLQINIOEQ[15].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[15].BGBMIEJJQKC = "Auto Decline";
		}
		if (PlayerPrefs.GetInt("friendr", 1) == 1)
		{
			this.GIFLQINIOEQ[16].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[16].BGBMIEJJQKC = "Auto Decline";
		}
		this.GIFLQINIOEQ[13].BGBMIEJJQKC = PlayerPrefs.GetInt("flyLimit", 10).ToString();
		if (PlayerPrefs.GetInt("SSAO", 0) == 1)
		{
			this.GIFLQINIOEQ[11].BGBMIEJJQKC = "Enabled";
		}
		else
		{
			this.GIFLQINIOEQ[11].BGBMIEJJQKC = "Disabled";
		}
		this.IFPMOEQCCFG[0].BGBMIEJJQKC = PlayerPrefs.GetFloat("Music", 0.8f);
		this.IFPMOEQCCFG[1].BGBMIEJJQKC = PlayerPrefs.GetFloat("Sound", 1f);
		if (DCCFQPDFBFO.QOQONHOOLNE != null)
		{
			DCCFQPDFBFO.QOQONHOOLNE.NJBIMOKLDBD = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
			DCCFQPDFBFO.QOQONHOOLNE.EEOPJMPGFME = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		}
	}

	// Token: 0x06003FAD RID: 16301 RVA: 0x001F5B14 File Offset: 0x001F3D14
	public void Apply(bool CBGPDPJLFNE = false)
	{
		if (!CBGPDPJLFNE)
		{
			bool flag = false;
			if (this.GIFLQINIOEQ[0].BGBMIEJJQKC == "Fullscreen")
			{
				flag = true;
			}
			string[] array = this.GIFLQINIOEQ[1].BGBMIEJJQKC.Split(new string[]
			{
				" x "
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length > 1 && ((PlayerPrefs.GetInt("dispMode", 1) == 0 && flag) || (PlayerPrefs.GetInt("dispMode", 1) == 1 && !flag) || (int)Convert.ToInt16(array[0]) != Screen.width || (int)Convert.ToInt16(array[1]) != Screen.height))
			{
				Screen.SetResolution((int)Convert.ToInt16(array[0]), (int)Convert.ToInt16(array[1]), flag);
			}
			PlayerPrefs.SetInt("ResolutionX", (int)Convert.ToInt16(array[0]));
			PlayerPrefs.SetInt("ResolutionY", (int)Convert.ToInt16(array[1]));
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.MOHHNKNPKLE();
			}
		}
		if (this.GIFLQINIOEQ[0].BGBMIEJJQKC == "Fullscreen")
		{
			PlayerPrefs.SetInt("dispMode", 1);
		}
		else
		{
			PlayerPrefs.SetInt("dispMode", 0);
		}
		if (this.GIFLQINIOEQ[2].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("vSync", 1);
			QualitySettings.vSyncCount = 1;
		}
		else
		{
			PlayerPrefs.SetInt("vSync", 0);
			QualitySettings.vSyncCount = 0;
		}
		if (this.GIFLQINIOEQ[7].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("bloom", 1);
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.ELQCCCEQDHD(true);
			}
		}
		else
		{
			PlayerPrefs.SetInt("bloom", 0);
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.ELQCCCEQDHD(false);
			}
		}
		if (this.GIFLQINIOEQ[8].BGBMIEJJQKC == "3D")
		{
			PlayerPrefs.SetInt("3d", 1);
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.KHPMDBMNCGC(true);
			}
		}
		else
		{
			PlayerPrefs.SetInt("3d", 0);
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.KHPMDBMNCGC(false);
			}
		}
		if (this.GIFLQINIOEQ[11].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("SSAO", 1);
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.JGBBPFKCMEN(true);
			}
		}
		else
		{
			PlayerPrefs.SetInt("SSAO", 0);
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.JGBBPFKCMEN(false);
			}
		}
		if (this.GIFLQINIOEQ[10].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("filter", 1);
			this.KGGCOFHHKEK = true;
		}
		else
		{
			PlayerPrefs.SetInt("filter", 0);
			this.KGGCOFHHKEK = false;
		}
		if (this.GIFLQINIOEQ[12].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("bump", 1);
			this.EMFDMGHDBOC = true;
		}
		else
		{
			PlayerPrefs.SetInt("bump", 0);
			this.EMFDMGHDBOC = false;
		}
		if (this.GIFLQINIOEQ[14].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("trader", 1);
			this.MJGMICNJJBE = false;
		}
		else
		{
			PlayerPrefs.SetInt("trader", 0);
			this.MJGMICNJJBE = true;
		}
		if (this.GIFLQINIOEQ[15].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("battler", 1);
			this.PFODCGLOHFD = false;
		}
		else
		{
			PlayerPrefs.SetInt("battler", 0);
			this.PFODCGLOHFD = true;
		}
		if (this.GIFLQINIOEQ[16].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("friendr", 1);
			this.MLQKMBCHFLL = false;
		}
		else
		{
			PlayerPrefs.SetInt("friendr", 0);
			this.MLQKMBCHFLL = true;
		}
		int num = 10;
		int.TryParse(this.GIFLQINIOEQ[13].BGBMIEJJQKC, out num);
		PlayerPrefs.SetInt("flyLimit", num);
		this.GMDLOGMNDCJ = num;
		this.PKKIIFDNHQE();
		if (this.GIFLQINIOEQ[4].BGBMIEJJQKC == "Enabled")
		{
			PlayerPrefs.SetInt("limitFPS", 1);
			Application.targetFrameRate = 60;
		}
		else
		{
			PlayerPrefs.SetInt("limitFPS", 0);
			Application.targetFrameRate = 0;
		}
		if (this.GIFLQINIOEQ[9].BGBMIEJJQKC == "Rotate")
		{
			PlayerPrefs.SetInt("bcam", 1);
			this.PCJIQBHPNEP = true;
		}
		else
		{
			PlayerPrefs.SetInt("bcam", 0);
			this.PCJIQBHPNEP = false;
		}
		PlayerPrefs.SetFloat("Music", this.IFPMOEQCCFG[0].BGBMIEJJQKC);
		PlayerPrefs.SetFloat("Sound", this.IFPMOEQCCFG[1].BGBMIEJJQKC);
		if (DCCFQPDFBFO.QOQONHOOLNE != null)
		{
			DCCFQPDFBFO.QOQONHOOLNE.NJBIMOKLDBD = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
			DCCFQPDFBFO.QOQONHOOLNE.EEOPJMPGFME = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
			this.UpdateMusicVolume();
		}
		if (this.GIFLQINIOEQ[5].BGBMIEJJQKC == "High")
		{
			PlayerPrefs.SetInt("Water", 1);
			if (this.FOHEKCKHDDO != null)
			{
				this.FOHEKCKHDDO.LQMJJFLHMOI = true;
				this.FOHEKCKHDDO.HDNLKEJMJJG();
				this.FOHEKCKHDDO.enabled = true;
			}
		}
		else
		{
			PlayerPrefs.SetInt("Water", 0);
			if (this.FOHEKCKHDDO != null)
			{
				this.FOHEKCKHDDO.LQMJJFLHMOI = false;
				this.FOHEKCKHDDO.HDNLKEJMJJG();
				this.FOHEKCKHDDO.enabled = false;
			}
		}
		if (NBQDPNGNNML.QOQONHOOLNE != null && GDDKPIHHICF.QOQONHOOLNE != null && GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
		{
			NBQDPNGNNML.QOQONHOOLNE.PDDJMNOOPJD();
			CGINEOGDPGP[] array2 = UnityEngine.Object.FindObjectsOfType<CGINEOGDPGP>();
			foreach (CGINEOGDPGP cgineogdpgp in array2)
			{
				cgineogdpgp.HEMBFJCMQNE();
			}
		}
	}

	// Token: 0x06003FAE RID: 16302 RVA: 0x001F60DC File Offset: 0x001F42DC
	public void GBGIJHEIHNB(bool CBGPDPJLFNE = false)
	{
		if (!CBGPDPJLFNE)
		{
			bool flag = true;
			if (this.GIFLQINIOEQ[0].LGNFPGFPBII() == "_ChannelMixerRed")
			{
				flag = false;
			}
			string text = this.GIFLQINIOEQ[1].HIOCELIDJII();
			string[] array = new string[0];
			array[1] = "'s electromagnetism wore off!\r\n";
			string[] array2 = text.Split(array, StringSplitOptions.None);
			if (array2.Length > 1 && ((PlayerPrefs.GetInt("MapVertex", 0) == 0 && flag) || (PlayerPrefs.GetInt("sunnyday", 1) == 0 && !flag) || (int)Convert.ToInt16(array2[0]) != Screen.width || (int)Convert.ToInt16(array2[0]) != Screen.height))
			{
				Screen.SetResolution((int)Convert.ToInt16(array2[1]), (int)Convert.ToInt16(array2[0]), flag);
			}
			PlayerPrefs.SetInt("Blank", (int)Convert.ToInt16(array2[0]));
			PlayerPrefs.SetInt("%", (int)Convert.ToInt16(array2[1]));
			if (JQOIHHDIHBN.BJLGEDCPENQ() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().DHHEBDMNPIC();
			}
		}
		if (this.GIFLQINIOEQ[1].DMBBLJCLCEJ() == "normal")
		{
			PlayerPrefs.SetInt("switch", 0);
		}
		else
		{
			PlayerPrefs.SetInt("/[delegate]", 0);
		}
		if (this.GIFLQINIOEQ[0].BGBMIEJJQKC == "[purple]")
		{
			PlayerPrefs.SetInt("Icon_Status_Burn", 0);
			QualitySettings.vSyncCount = 0;
		}
		else
		{
			PlayerPrefs.SetInt("Temp Sound Clip", 1);
			QualitySettings.vSyncCount = 0;
		}
		if (this.GIFLQINIOEQ[5].LGNFPGFPBII() == "map")
		{
			PlayerPrefs.SetInt("[00]", 1);
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().GONOKHFOOBP(false);
			}
		}
		else
		{
			PlayerPrefs.SetInt(" minute", 1);
			if (JQOIHHDIHBN.QOQONHOOLNE != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.LKIGEOOBLID(false);
			}
		}
		if (this.GIFLQINIOEQ[1].LGNFPGFPBII() == "S")
		{
			PlayerPrefs.SetInt("_History2ChromaTex", 0);
			if (JQOIHHDIHBN.GFJGPNOPEPC() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().KHPMDBMNCGC(true);
			}
		}
		else
		{
			PlayerPrefs.SetInt("Not Input", 1);
			if (JQOIHHDIHBN.BJLGEDCPENQ() != null)
			{
				JQOIHHDIHBN.QOQONHOOLNE.KHPMDBMNCGC(false);
			}
		}
		if (this.GIFLQINIOEQ[-9].HIOCELIDJII() == " doesn't become confused!\r\n")
		{
			PlayerPrefs.SetInt("'s [ffff00]", 1);
			if (JQOIHHDIHBN.GFJGPNOPEPC() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().HCMEBHBGEHE(false);
			}
		}
		else
		{
			PlayerPrefs.SetInt("smokeball", 1);
			if (JQOIHHDIHBN.BJLGEDCPENQ() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().LDIMJKNQBPB(false);
			}
		}
		if (this.GIFLQINIOEQ[42].LGNFPGFPBII() == "receiver")
		{
			PlayerPrefs.SetInt("[/itm]", 0);
			this.KGGCOFHHKEK = false;
		}
		else
		{
			PlayerPrefs.SetInt("K2", 1);
			this.KGGCOFHHKEK = false;
		}
		if (this.GIFLQINIOEQ[35].DMBBLJCLCEJ() == "-")
		{
			PlayerPrefs.SetInt("wonderskin", 0);
			this.EMFDMGHDBOC = false;
		}
		else
		{
			PlayerPrefs.SetInt("fairyaura", 1);
			this.EMFDMGHDBOC = false;
		}
		if (this.GIFLQINIOEQ[105].ONPQLDJHHGB() == "airballoon")
		{
			PlayerPrefs.SetInt("Fitter Fill", 0);
			this.MJGMICNJJBE = false;
		}
		else
		{
			PlayerPrefs.SetInt("Limit Speed", 0);
			this.MJGMICNJJBE = true;
		}
		if (this.GIFLQINIOEQ[120].DMBBLJCLCEJ() == "anticipation")
		{
			PlayerPrefs.SetInt("Grain Lookup Texture", 0);
			this.PFODCGLOHFD = false;
		}
		else
		{
			PlayerPrefs.SetInt("[o]", 1);
			this.PFODCGLOHFD = false;
		}
		if (this.GIFLQINIOEQ[78].HIOCELIDJII() == "Johto")
		{
			PlayerPrefs.SetInt("timer", 1);
			this.MLQKMBCHFLL = false;
		}
		else
		{
			PlayerPrefs.SetInt("[-]?\n\nOnce you do this, it will be lost forever.", 0);
			this.MLQKMBCHFLL = false;
		}
		int num = -107;
		int.TryParse(this.GIFLQINIOEQ[107].ONPQLDJHHGB(), out num);
		PlayerPrefs.SetInt("_MountTopTex", num);
		this.GMDLOGMNDCJ = num;
		this.PKKIIFDNHQE();
		if (this.GIFLQINIOEQ[6].HIOCELIDJII() == "ditto")
		{
			PlayerPrefs.SetInt("/", 1);
			Application.targetFrameRate = 58;
		}
		else
		{
			PlayerPrefs.SetInt("protean", 0);
			Application.targetFrameRate = 1;
		}
		if (this.GIFLQINIOEQ[115].ONPQLDJHHGB() == "[ATK]")
		{
			PlayerPrefs.SetInt(".", 1);
			this.PCJIQBHPNEP = true;
		}
		else
		{
			PlayerPrefs.SetInt("F14", 0);
			this.PCJIQBHPNEP = false;
		}
		PlayerPrefs.SetFloat("_NeutralTonemapperParams1", this.IFPMOEQCCFG[0].BGBMIEJJQKC);
		PlayerPrefs.SetFloat("_History4Weight", this.IFPMOEQCCFG[1].HKDJGHOHBFQ());
		if (DCCFQPDFBFO.CDDIILFBFCF() != null)
		{
			DCCFQPDFBFO.ONBDGGPLFQK().NJBIMOKLDBD = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
			DCCFQPDFBFO.DGCQMNHFQNH().EEOPJMPGFME = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
			this.KKEJDLCBDPF();
		}
		if (this.GIFLQINIOEQ[2].ONPQLDJHHGB() == "The sunlight faded.")
		{
			PlayerPrefs.SetInt("toxicspikes", 1);
			if (this.FOHEKCKHDDO != null)
			{
				this.FOHEKCKHDDO.LQMJJFLHMOI = true;
				this.FOHEKCKHDDO.FIJKJCFPQIF();
				this.FOHEKCKHDDO.enabled = true;
			}
		}
		else
		{
			PlayerPrefs.SetInt("\r\n", 0);
			if (this.FOHEKCKHDDO != null)
			{
				this.FOHEKCKHDDO.LQMJJFLHMOI = true;
				this.FOHEKCKHDDO.FIJKJCFPQIF();
				this.FOHEKCKHDDO.enabled = false;
			}
		}
		if (NBQDPNGNNML.QOQONHOOLNE != null && GDDKPIHHICF.QOQONHOOLNE != null && GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
		{
			NBQDPNGNNML.QOQONHOOLNE.BLCLGIIEGFK();
			CGINEOGDPGP[] array3 = UnityEngine.Object.FindObjectsOfType<CGINEOGDPGP>();
			foreach (CGINEOGDPGP cgineogdpgp in array3)
			{
				cgineogdpgp.MBLLPFQIPPF();
			}
		}
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x001F66A4 File Offset: 0x001F48A4
	public void OCOMDLNCELC()
	{
		this.FNMLCJDOQFK.enabled = true;
		if (this.NFFIHJOBCLH.activeSelf)
		{
			this.FNMLCJDOQFK.PlayReverse();
			this.NPOGCMKIDKK = false;
		}
		else
		{
			this.NFFIHJOBCLH.SetActive(true);
			this.FNMLCJDOQFK.PlayForward();
			this.NPOGCMKIDKK = false;
		}
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x0001A90F File Offset: 0x00018B0F
	public void AfterMenuTween()
	{
		this.FNMLCJDOQFK.enabled = false;
		this.NFFIHJOBCLH.SetActive(!this.NPOGCMKIDKK);
	}

	// Token: 0x06003FB1 RID: 16305 RVA: 0x001F66FC File Offset: 0x001F48FC
	public void PKKIIFDNHQE()
	{
		bool flag = false;
		if (GGQKBGDGNJN.QOQONHOOLNE != null)
		{
			flag = GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG;
		}
		if (!this.OOJMKCLOQPD && !flag)
		{
			QualitySettings.antiAliasing = 0;
			if (this.GIFLQINIOEQ[6].BGBMIEJJQKC == "2x")
			{
				PlayerPrefs.SetInt("aa", 1);
			}
			else if (this.GIFLQINIOEQ[6].BGBMIEJJQKC == "4x")
			{
				PlayerPrefs.SetInt("aa", 2);
			}
			else if (this.GIFLQINIOEQ[6].BGBMIEJJQKC == "8x")
			{
				PlayerPrefs.SetInt("aa", 3);
			}
			else
			{
				PlayerPrefs.SetInt("aa", 0);
			}
		}
		else if (this.GIFLQINIOEQ[6].BGBMIEJJQKC == "2x")
		{
			PlayerPrefs.SetInt("aa", 1);
			QualitySettings.antiAliasing = 2;
		}
		else if (this.GIFLQINIOEQ[6].BGBMIEJJQKC == "4x")
		{
			PlayerPrefs.SetInt("aa", 2);
			QualitySettings.antiAliasing = 4;
		}
		else if (this.GIFLQINIOEQ[6].BGBMIEJJQKC == "8x")
		{
			PlayerPrefs.SetInt("aa", 3);
			QualitySettings.antiAliasing = 8;
		}
		else
		{
			PlayerPrefs.SetInt("aa", 0);
			QualitySettings.antiAliasing = 0;
		}
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x001F685C File Offset: 0x001F4A5C
	public void PMJOFFNKFJM()
	{
		bool flag = false;
		if (GGQKBGDGNJN.QOQONHOOLNE != null)
		{
			flag = GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG;
		}
		if (!this.OOJMKCLOQPD && !flag)
		{
			QualitySettings.antiAliasing = 0;
			if (this.GIFLQINIOEQ[5].DMBBLJCLCEJ() == " lost its focus and couldn't move!\r\n")
			{
				PlayerPrefs.SetInt("[00EE07]", 0);
			}
			else if (this.GIFLQINIOEQ[2].BGBMIEJJQKC == "immunity")
			{
				PlayerPrefs.SetInt(" used the move instructed by ", 8);
			}
			else if (this.GIFLQINIOEQ[1].LGNFPGFPBII() == "#,##0")
			{
				PlayerPrefs.SetInt("move: ", 2);
			}
			else
			{
				PlayerPrefs.SetInt("Disguise", 0);
			}
		}
		else if (this.GIFLQINIOEQ[2].HIOCELIDJII() == "[NGUI] ")
		{
			PlayerPrefs.SetInt("JOFLHFQQCKG", 0);
			QualitySettings.antiAliasing = 5;
		}
		else if (this.GIFLQINIOEQ[7].DMBBLJCLCEJ() == " is covered in powder!\r\n")
		{
			PlayerPrefs.SetInt("_HueShift", 8);
			QualitySettings.antiAliasing = 0;
		}
		else if (this.GIFLQINIOEQ[1].ONPQLDJHHGB() == " recieved [ffff00]")
		{
			PlayerPrefs.SetInt(" surrounded itself with a veil of water!\r\n", 8);
			QualitySettings.antiAliasing = 5;
		}
		else
		{
			PlayerPrefs.SetInt("-primal", 1);
			QualitySettings.antiAliasing = 0;
		}
	}

	// Token: 0x06003FB3 RID: 16307 RVA: 0x0001A931 File Offset: 0x00018B31
	public void MCEOCMJMGKM()
	{
		this.GBGIJHEIHNB(true);
		this.OpenCloseOptions();
	}

	// Token: 0x06003FB4 RID: 16308 RVA: 0x0001A940 File Offset: 0x00018B40
	public void GOQKKEHOKIQ()
	{
		DCCFQPDFBFO.QQCNCIQQPIG().NJBIMOKLDBD = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
		DCCFQPDFBFO.CDDIILFBFCF().EEOPJMPGFME = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
		DCCFQPDFBFO.QQCNCIQQPIG().DEECKEOMIPC();
	}

	// Token: 0x06003FB5 RID: 16309 RVA: 0x0001760B File Offset: 0x0001580B
	public void PDIENMLKKLO()
	{
		Application.Quit();
	}

	// Token: 0x06003FB6 RID: 16310 RVA: 0x0001A753 File Offset: 0x00018953
	public void KFCHBBOBOMP()
	{
		this.Apply(false);
		this.OpenCloseOptions();
	}

	// Token: 0x06003FB7 RID: 16311 RVA: 0x001F69BC File Offset: 0x001F4BBC
	private void FEQPPBDKBJB(int CIQFCJGQEMH)
	{
		for (int i = 1; i < this.PKBOPNPKQOG.Length; i++)
		{
			if (i == CIQFCJGQEMH)
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO((PBJKDKBOLHO.OKKDIIQGHDD)5, true);
			}
			else
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
		}
	}

	// Token: 0x06003FB8 RID: 16312 RVA: 0x0001A97A File Offset: 0x00018B7A
	public void LBGOCGNKECE()
	{
		this.IPOMHLKBEHF();
		this.MJIGLPMMDJL.SetActive(true);
		this.FBCHCGPGQJF();
		this.GQGHJBINDKG();
	}

	// Token: 0x06003FB9 RID: 16313 RVA: 0x001F6A28 File Offset: 0x001F4C28
	public void PMKPPJFBOEF()
	{
		this.EDEMDQGEQPP();
		this.IFPMOEQCCFG[1].FONJFPIKGEP(PlayerPrefs.GetFloat("airballoon", 993f));
		this.IFPMOEQCCFG[1].PLLQOHPCBOP(PlayerPrefs.GetFloat("_FogColor2", 1150f));
		if (DCCFQPDFBFO.CLPQIKCDHPP() != null)
		{
			DCCFQPDFBFO.QQCNCIQQPIG().NJBIMOKLDBD = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
			DCCFQPDFBFO.DGCQMNHFQNH().EEOPJMPGFME = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
			this.CGHKNCPBGPJ();
		}
	}

	// Token: 0x06003FBA RID: 16314 RVA: 0x0001A99A File Offset: 0x00018B9A
	public void ECIGKDOFBQK()
	{
		this.GBGIJHEIHNB(false);
		this.DBPBMQJQPGG();
	}

	// Token: 0x06003FBB RID: 16315 RVA: 0x0001A9A9 File Offset: 0x00018BA9
	public void NJMLPNJFILE()
	{
		this.GBGIJHEIHNB(true);
		this.FBCHCGPGQJF();
	}

	// Token: 0x06003FBC RID: 16316 RVA: 0x0001A9B8 File Offset: 0x00018BB8
	public void QFPFOLCHEJK()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[4].SetActive(true);
		this.LKCBEJPIMHK(3);
	}

	// Token: 0x06003FBD RID: 16317 RVA: 0x0001A90F File Offset: 0x00018B0F
	public void PPLJDQQGKCK()
	{
		this.FNMLCJDOQFK.enabled = false;
		this.NFFIHJOBCLH.SetActive(!this.NPOGCMKIDKK);
	}

	// Token: 0x06003FBE RID: 16318 RVA: 0x0001760B File Offset: 0x0001580B
	public void Quit()
	{
		Application.Quit();
	}

	// Token: 0x06003FBF RID: 16319 RVA: 0x001F6AB4 File Offset: 0x001F4CB4
	public void FNICBCOQBPK(bool CBGPDPJLFNE = false)
	{
		if (!CBGPDPJLFNE)
		{
			bool flag = false;
			if (this.GIFLQINIOEQ[0].LGNFPGFPBII() == "[pok=")
			{
				flag = false;
			}
			string[] array = this.GIFLQINIOEQ[0].HIOCELIDJII().Split(new string[]
			{
				"Hide"
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length > 0 && ((PlayerPrefs.GetInt(" clamped down on ", 0) == 0 && flag) || (PlayerPrefs.GetInt("Super Magnet", 1) == 1 && !flag) || (int)Convert.ToInt16(array[1]) != Screen.width || (int)Convert.ToInt16(array[0]) != Screen.height))
			{
				Screen.SetResolution((int)Convert.ToInt16(array[1]), (int)Convert.ToInt16(array[0]), flag);
			}
			PlayerPrefs.SetInt("_", (int)Convert.ToInt16(array[1]));
			PlayerPrefs.SetInt(" Obtained ", (int)Convert.ToInt16(array[0]));
			if (JQOIHHDIHBN.BJLGEDCPENQ() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().EEJKLBOHOBH();
			}
		}
		if (this.GIFLQINIOEQ[1].ONPQLDJHHGB() == " protected itself!\r\n")
		{
			PlayerPrefs.SetInt(":", 0);
		}
		else
		{
			PlayerPrefs.SetInt("General", 1);
		}
		if (this.GIFLQINIOEQ[3].DMBBLJCLCEJ() == "[NGUI] ")
		{
			PlayerPrefs.SetInt(" ", 1);
			QualitySettings.vSyncCount = 0;
		}
		else
		{
			PlayerPrefs.SetInt("_ClipToWorld", 1);
			QualitySettings.vSyncCount = 1;
		}
		if (this.GIFLQINIOEQ[4].LGNFPGFPBII() == "\n[5cd65c]SPDEF:[-] ")
		{
			PlayerPrefs.SetInt("Assets/AssetBundles/Sprites/", 1);
			if (JQOIHHDIHBN.BJLGEDCPENQ() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().ELQCCCEQDHD(true);
			}
		}
		else
		{
			PlayerPrefs.SetInt("[^a-zA-Z0-9]", 0);
			if (JQOIHHDIHBN.GFJGPNOPEPC() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().GONOKHFOOBP(true);
			}
		}
		if (this.GIFLQINIOEQ[2].HIOCELIDJII() == "b")
		{
			PlayerPrefs.SetInt("Verification", 1);
			if (JQOIHHDIHBN.GFJGPNOPEPC() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().PIHMFKPIHGH(true);
			}
		}
		else
		{
			PlayerPrefs.SetInt("_MountBottomTex", 1);
			if (JQOIHHDIHBN.GFJGPNOPEPC() != null)
			{
				JQOIHHDIHBN.GFJGPNOPEPC().KHPMDBMNCGC(true);
			}
		}
		if (this.GIFLQINIOEQ[-42].DMBBLJCLCEJ() == "Fullscreen")
		{
			PlayerPrefs.SetInt(".", 0);
			if (JQOIHHDIHBN.BJLGEDCPENQ() != null)
			{
				JQOIHHDIHBN.GFJGPNOPEPC().JGBBPFKCMEN(true);
			}
		}
		else
		{
			PlayerPrefs.SetInt("#,##0", 1);
			if (JQOIHHDIHBN.GFJGPNOPEPC() != null)
			{
				JQOIHHDIHBN.BJLGEDCPENQ().LDIMJKNQBPB(true);
			}
		}
		if (this.GIFLQINIOEQ[102].HIOCELIDJII() == "#,##0")
		{
			PlayerPrefs.SetInt("'s stat changes were inverted!\r\n", 0);
			this.KGGCOFHHKEK = false;
		}
		else
		{
			PlayerPrefs.SetInt("\n[ff66cc]SPD:[-] ", 0);
			this.KGGCOFHHKEK = true;
		}
		if (this.GIFLQINIOEQ[113].ONPQLDJHHGB() == "Limit Speed")
		{
			PlayerPrefs.SetInt("FOG_LINEAR", 0);
			this.EMFDMGHDBOC = false;
		}
		else
		{
			PlayerPrefs.SetInt("p2", 0);
			this.EMFDMGHDBOC = false;
		}
		if (this.GIFLQINIOEQ[66].LGNFPGFPBII() == "1")
		{
			PlayerPrefs.SetInt(" Mobile", 0);
			this.MJGMICNJJBE = true;
		}
		else
		{
			PlayerPrefs.SetInt(" Coins", 1);
			this.MJGMICNJJBE = true;
		}
		if (this.GIFLQINIOEQ[-19].LGNFPGFPBII() == "Confirm EVs")
		{
			PlayerPrefs.SetInt("Max Repel", 1);
			this.PFODCGLOHFD = false;
		}
		else
		{
			PlayerPrefs.SetInt("Data/moves", 0);
			this.PFODCGLOHFD = true;
		}
		if (this.GIFLQINIOEQ[66].BGBMIEJJQKC == "hyperspacefury")
		{
			PlayerPrefs.SetInt("qdTrack", 1);
			this.MLQKMBCHFLL = false;
		}
		else
		{
			PlayerPrefs.SetInt("-enditem", 0);
			this.MLQKMBCHFLL = true;
		}
		int num = 109;
		int.TryParse(this.GIFLQINIOEQ[-109].BGBMIEJJQKC, out num);
		PlayerPrefs.SetInt(" is an Ephemeral Port which is used by TCP/UDP as Source/Outgoing port. This may cause problems!", num);
		this.GMDLOGMNDCJ = num;
		this.PKKIIFDNHQE();
		if (this.GIFLQINIOEQ[0].HIOCELIDJII() == "Key_")
		{
			PlayerPrefs.SetInt("bump", 0);
			Application.targetFrameRate = -81;
		}
		else
		{
			PlayerPrefs.SetInt(" cannot use [ffff00]", 0);
			Application.targetFrameRate = 0;
		}
		if (this.GIFLQINIOEQ[123].DMBBLJCLCEJ() == "-mega-x")
		{
			PlayerPrefs.SetInt("aa", 1);
			this.PCJIQBHPNEP = true;
		}
		else
		{
			PlayerPrefs.SetInt("'s power!\r\n", 0);
			this.PCJIQBHPNEP = true;
		}
		PlayerPrefs.SetFloat("The Pokémon copies the Ability of a defeated ally.", this.IFPMOEQCCFG[0].BGBMIEJJQKC);
		PlayerPrefs.SetFloat("Icon_Pokemon_Empty", this.IFPMOEQCCFG[0].HKDJGHOHBFQ());
		if (DCCFQPDFBFO.QQCNCIQQPIG() != null)
		{
			DCCFQPDFBFO.OMPHLNDGKKM().NJBIMOKLDBD = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
			DCCFQPDFBFO.DGCQMNHFQNH().EEOPJMPGFME = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
			this.GHBMKEPOCMQ();
		}
		if (this.GIFLQINIOEQ[2].ONPQLDJHHGB() == "psn")
		{
			PlayerPrefs.SetInt("Run_White", 0);
			if (this.FOHEKCKHDDO != null)
			{
				this.FOHEKCKHDDO.LQMJJFLHMOI = true;
				this.FOHEKCKHDDO.HDNLKEJMJJG();
				this.FOHEKCKHDDO.enabled = false;
			}
		}
		else
		{
			PlayerPrefs.SetInt("_", 0);
			if (this.FOHEKCKHDDO != null)
			{
				this.FOHEKCKHDDO.LQMJJFLHMOI = false;
				this.FOHEKCKHDDO.GJKEPOHGNEG();
				this.FOHEKCKHDDO.enabled = false;
			}
		}
		if (NBQDPNGNNML.QOQONHOOLNE != null && GDDKPIHHICF.QOQONHOOLNE != null && GDDKPIHHICF.QOQONHOOLNE.EFOGMBCFBGM)
		{
			NBQDPNGNNML.QOQONHOOLNE.BLCLGIIEGFK();
			CGINEOGDPGP[] array2 = UnityEngine.Object.FindObjectsOfType<CGINEOGDPGP>();
			CGINEOGDPGP[] array3 = array2;
			for (int i = 1; i < array3.Length; i += 0)
			{
				CGINEOGDPGP cgineogdpgp = array3[i];
				cgineogdpgp.HEMBFJCMQNE();
			}
		}
	}

	// Token: 0x06003FC0 RID: 16320 RVA: 0x001F707C File Offset: 0x001F527C
	public void IGMMPOGCICC()
	{
		bool flag = false;
		if (GGQKBGDGNJN.QOQONHOOLNE != null)
		{
			flag = GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG;
		}
		if (!this.OOJMKCLOQPD && !flag)
		{
			QualitySettings.antiAliasing = 0;
			if (this.GIFLQINIOEQ[6].HIOCELIDJII() == "[")
			{
				PlayerPrefs.SetInt("Q", 1);
			}
			else if (this.GIFLQINIOEQ[8].LGNFPGFPBII() == "r")
			{
				PlayerPrefs.SetInt("The Battle was a tie!\r\n", 6);
			}
			else if (this.GIFLQINIOEQ[0].LGNFPGFPBII() == "!\r\n")
			{
				PlayerPrefs.SetInt("Color Grading Log LUT", 3);
			}
			else
			{
				PlayerPrefs.SetInt("stench", 1);
			}
		}
		else if (this.GIFLQINIOEQ[3].LGNFPGFPBII() == "[u][33CCFF]")
		{
			PlayerPrefs.SetInt("'s Money will go over the money cap.", 0);
			QualitySettings.antiAliasing = 6;
		}
		else if (this.GIFLQINIOEQ[0].BGBMIEJJQKC == "door_4")
		{
			PlayerPrefs.SetInt("1", 2);
			QualitySettings.antiAliasing = 2;
		}
		else if (this.GIFLQINIOEQ[1].BGBMIEJJQKC == "_")
		{
			PlayerPrefs.SetInt("System", 7);
			QualitySettings.antiAliasing = 0;
		}
		else
		{
			PlayerPrefs.SetInt("HM", 0);
			QualitySettings.antiAliasing = 0;
		}
	}

	// Token: 0x06003FC1 RID: 16321 RVA: 0x001F71DC File Offset: 0x001F53DC
	public void EDEMDQGEQPP()
	{
		this.BMENEKIDBMB.enabled = false;
		if (this.MJIGLPMMDJL.activeSelf)
		{
			this.BMENEKIDBMB.PlayReverse();
			this.DCPLMGJCFNP = false;
		}
		else
		{
			this.ShowTab1();
			this.MJIGLPMMDJL.SetActive(false);
			if (this.MJIGLPMMDJL.GetComponentInChildren<KIQKEMNELKN>() != null)
			{
				this.MJIGLPMMDJL.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
			}
			IKBQNBHOJJB.OKLNNGPNIEO(this.MJIGLPMMDJL);
			this.BMENEKIDBMB.PlayForward();
			this.DCPLMGJCFNP = false;
		}
	}

	// Token: 0x06003FC2 RID: 16322 RVA: 0x0001A9EB File Offset: 0x00018BEB
	public void QOBOBQDHNGF()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[8].SetActive(true);
		this.FEQPPBDKBJB(1);
	}

	// Token: 0x06003FC3 RID: 16323 RVA: 0x001F7268 File Offset: 0x001F5468
	private void LFHEGBFOEGJ(int CIQFCJGQEMH)
	{
		for (int i = 0; i < this.PKBOPNPKQOG.Length; i += 0)
		{
			if (i == CIQFCJGQEMH)
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Pressed, false);
			}
			else
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Hover, false);
			}
		}
	}

	// Token: 0x06003FC4 RID: 16324 RVA: 0x0001A8FB File Offset: 0x00018AFB
	public void GFBHCBGMGNL()
	{
		this.NFFIHJOBCLH.SetActive(false);
		this.OpenCloseMenu();
	}

	// Token: 0x06003FC5 RID: 16325 RVA: 0x0001AA1E File Offset: 0x00018C1E
	public void Open()
	{
		this.BJNHBGHBHII();
		this.MJIGLPMMDJL.SetActive(false);
		this.OpenCloseOptions();
		this.CloseMenu();
	}

	// Token: 0x06003FC6 RID: 16326 RVA: 0x0001AA3E File Offset: 0x00018C3E
	public void DNLQFPIOBOH()
	{
		DCCFQPDFBFO.CLPQIKCDHPP().NJBIMOKLDBD = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		DCCFQPDFBFO.ONBDGGPLFQK().EEOPJMPGFME = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
		DCCFQPDFBFO.DGCQMNHFQNH().GFCGHEHBPMF();
	}

	// Token: 0x06003FC7 RID: 16327 RVA: 0x001F72D4 File Offset: 0x001F54D4
	private void HJMHPLIFHGC()
	{
		Application.targetFrameRate = 42;
		this.DPLQNCIFJJD();
		this.Apply(false);
		if (PlayerPrefs.GetInt("_", 0) == 0)
		{
			Resolution currentResolution = Screen.currentResolution;
			Screen.SetResolution(currentResolution.width, currentResolution.height, false);
		}
		else
		{
			bool fullscreen = false;
			if (this.GIFLQINIOEQ[1].DMBBLJCLCEJ() == " would like you to join their Party. Do you wish to join?")
			{
				fullscreen = true;
			}
			Screen.SetResolution(PlayerPrefs.GetInt("[ffb649]", -167), PlayerPrefs.GetInt("Boosts the Attack stat if hit by a Grass-type move, instead of taking damage.", 144), fullscreen);
		}
	}

	// Token: 0x06003FC8 RID: 16328 RVA: 0x001F7360 File Offset: 0x001F5560
	public void IPOMHLKBEHF()
	{
		if (PlayerPrefs.GetInt("1", 0) == 0)
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "FOG_EXP";
		}
		else
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "_FogVoidData";
		}
		if (PlayerPrefs.GetInt("physical", 0) == 0)
		{
			this.GIFLQINIOEQ[1].BGBMIEJJQKC = "[-] made it the ";
		}
		else
		{
			this.GIFLQINIOEQ[5].BLHCINIPJLC("BLOOM");
		}
		if (PlayerPrefs.GetInt(" evolved into ", 0) == 1)
		{
			this.GIFLQINIOEQ[8].BGBMIEJJQKC = "The Pokémon draws in all Electric-type moves. Instead of being hit by Electric-type moves, it boosts its Sp. Atk.";
		}
		else if (PlayerPrefs.GetInt("-", 0) == 0)
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "[00AAFF]";
		}
		else if (PlayerPrefs.GetInt("F8", 0) == 1)
		{
			this.GIFLQINIOEQ[5].BLHCINIPJLC("/");
		}
		else
		{
			this.GIFLQINIOEQ[6].BLHCINIPJLC("Battle Update: ");
		}
		if (PlayerPrefs.GetInt("sandstorm", 1) == 1)
		{
			this.GIFLQINIOEQ[4].BLHCINIPJLC("FOG_BLUR_ON");
		}
		else
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "Sturdy";
		}
		if (PlayerPrefs.GetInt("suctioncups", 1) == 1)
		{
			this.GIFLQINIOEQ[1].BLHCINIPJLC("'s opponents are too nervous to eat Berries!\r\n");
		}
		else
		{
			this.GIFLQINIOEQ[8].BGBMIEJJQKC = "System";
		}
		if (PlayerPrefs.GetInt(" healed its burn!\r\n", 1) == 0)
		{
			this.GIFLQINIOEQ[3].BLHCINIPJLC("WATER_VERTEX_DISPLACEMENT_ON");
		}
		else
		{
			this.GIFLQINIOEQ[6].BLHCINIPJLC("\n\n");
		}
		if (PlayerPrefs.GetInt("Fishing Cooldown", 0) == 0)
		{
			this.GIFLQINIOEQ[1].BLHCINIPJLC("'s from critical hits!\r\n");
		}
		else
		{
			this.GIFLQINIOEQ[3].BLHCINIPJLC("focuspunch");
		}
		if (PlayerPrefs.GetInt(" and ", 0) == 0)
		{
			this.GIFLQINIOEQ[-123].BLHCINIPJLC("_HatTex");
		}
		else
		{
			this.GIFLQINIOEQ[106].BLHCINIPJLC("Slots_2");
		}
		if (PlayerPrefs.GetInt("Battle", 1) == 0)
		{
			this.GIFLQINIOEQ[50].BLHCINIPJLC("!\r\n");
		}
		else
		{
			this.GIFLQINIOEQ[-125].BLHCINIPJLC("fighting");
		}
		if (PlayerPrefs.GetInt("M5", 0) == 0)
		{
			this.GIFLQINIOEQ[71].BGBMIEJJQKC = "UpdateAnchors";
		}
		else
		{
			this.GIFLQINIOEQ[-35].BGBMIEJJQKC = "turboblaze";
		}
		if (PlayerPrefs.GetInt("Insomnia", 1) == 0)
		{
			this.GIFLQINIOEQ[7].BLHCINIPJLC("Pixel Perfect");
		}
		else
		{
			this.GIFLQINIOEQ[-87].BGBMIEJJQKC = "[FFFF00]/252";
		}
		if (PlayerPrefs.GetInt("Assets/AssetBundles/MapAssets/Models/House_Oak/Materials/c102_09_mado.mat", 0) == 0)
		{
			this.GIFLQINIOEQ[36].BLHCINIPJLC("safetygoggles");
		}
		else
		{
			this.GIFLQINIOEQ[28].BLHCINIPJLC("harvest");
		}
		if (PlayerPrefs.GetInt("Mist swirls around the battlefield!\r\n", 0) == 0)
		{
			this.GIFLQINIOEQ[91].BGBMIEJJQKC = "DirX";
		}
		else
		{
			this.GIFLQINIOEQ[21].BLHCINIPJLC("Using its pure power, the Pokémon doubles its Attack stat.");
		}
		this.GIFLQINIOEQ[57].BLHCINIPJLC(PlayerPrefs.GetInt("_Amount", 44).ToString());
		if (PlayerPrefs.GetInt("[FFFF00]/252", 1) == 1)
		{
			this.GIFLQINIOEQ[-4].BGBMIEJJQKC = "Delta Stream";
		}
		else
		{
			this.GIFLQINIOEQ[-85].BLHCINIPJLC("safeguard");
		}
		this.IFPMOEQCCFG[0].PLLQOHPCBOP(PlayerPrefs.GetFloat("[/b]", 758f));
		this.IFPMOEQCCFG[1].PLLQOHPCBOP(PlayerPrefs.GetFloat("Trade Request", 474f));
		if (DCCFQPDFBFO.CLPQIKCDHPP() != null)
		{
			DCCFQPDFBFO.ONBDGGPLFQK().NJBIMOKLDBD = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
			DCCFQPDFBFO.ONBDGGPLFQK().EEOPJMPGFME = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
		}
	}

	// Token: 0x06003FC9 RID: 16329 RVA: 0x0001AA78 File Offset: 0x00018C78
	public void HPNEOHEIDGB()
	{
		this.PKBOPNPKQOG[1].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[8].SetActive(true);
		this.FEQPPBDKBJB(0);
	}

	// Token: 0x06003FCA RID: 16330 RVA: 0x0001A762 File Offset: 0x00018962
	public void NEGGMQQIJBN()
	{
		this.FNMLCJDOQFK.enabled = true;
		this.NFFIHJOBCLH.SetActive(!this.NPOGCMKIDKK);
	}

	// Token: 0x06003FCB RID: 16331 RVA: 0x0001AAAB File Offset: 0x00018CAB
	public void DFIOHKHBFFQ()
	{
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[1].SetActive(true);
		this.PKBOPNPKQOG[5].SetActive(false);
		this.GMBLHFLCLMO(0);
	}

	// Token: 0x06003FCC RID: 16332 RVA: 0x0001760B File Offset: 0x0001580B
	public void MBMPPQPHLPB()
	{
		Application.Quit();
	}

	// Token: 0x06003FCD RID: 16333 RVA: 0x0001AADE File Offset: 0x00018CDE
	public void ShowTab3()
	{
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[2].SetActive(true);
		this.OPGEJKPEGHP(2);
	}

	// Token: 0x06003FCE RID: 16334 RVA: 0x0001AB11 File Offset: 0x00018D11
	public void IQIHEEIHQLB()
	{
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[0].SetActive(true);
		this.PKBOPNPKQOG[4].SetActive(false);
		this.LFHEGBFOEGJ(0);
	}

	// Token: 0x06003FCF RID: 16335 RVA: 0x001F7734 File Offset: 0x001F5934
	private void OPGEJKPEGHP(int CIQFCJGQEMH)
	{
		for (int i = 0; i < this.PKBOPNPKQOG.Length; i++)
		{
			if (i == CIQFCJGQEMH)
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = false;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Disabled, true);
			}
			else
			{
				this.PGBLHMLDGOJ[i].GetComponent<BoxCollider>().enabled = true;
				this.PGBLHMLDGOJ[i].NHCNOIOCFCO(PBJKDKBOLHO.OKKDIIQGHDD.Normal, true);
			}
		}
	}

	// Token: 0x06003FD0 RID: 16336 RVA: 0x001F77A0 File Offset: 0x001F59A0
	public void HGLNLNGMIOF()
	{
		if (PlayerPrefs.GetInt("Textures/Noise3", 0) == 1)
		{
			this.GIFLQINIOEQ[1].BLHCINIPJLC("iondeluge");
		}
		else
		{
			this.GIFLQINIOEQ[1].BGBMIEJJQKC = "_TempRT2";
		}
		if (PlayerPrefs.GetInt("\n", 1) == 0)
		{
			this.GIFLQINIOEQ[2].BLHCINIPJLC("Hidden/Post FX/Builtin Debug Views");
		}
		else
		{
			this.GIFLQINIOEQ[1].BLHCINIPJLC("Hidden/Post FX/Builtin Debug Views");
		}
		if (PlayerPrefs.GetInt("trick", 0) == 1)
		{
			this.GIFLQINIOEQ[4].BLHCINIPJLC("You can not trade during interactions or battles.");
		}
		else if (PlayerPrefs.GetInt("[00FF00]You received [PD]", 0) == 4)
		{
			this.GIFLQINIOEQ[5].BGBMIEJJQKC = "i";
		}
		else if (PlayerPrefs.GetInt("Big/", 1) == 7)
		{
			this.GIFLQINIOEQ[3].BGBMIEJJQKC = "Icon_Pokemon_Dead";
		}
		else
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("TabSettings");
		}
		if (PlayerPrefs.GetInt("tangledfeet", 1) == 1)
		{
			this.GIFLQINIOEQ[3].BGBMIEJJQKC = "egg";
		}
		else
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = "teravolt";
		}
		if (PlayerPrefs.GetInt("forecast", 1) == 1)
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("\r\nLv ");
		}
		else
		{
			this.GIFLQINIOEQ[1].BGBMIEJJQKC = "Icon_Status_BadlyPoisoned";
		}
		if (PlayerPrefs.GetInt("Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!", 0) == 0)
		{
			this.GIFLQINIOEQ[6].BLHCINIPJLC("Invalid Username or Password..");
		}
		else
		{
			this.GIFLQINIOEQ[5].BGBMIEJJQKC = "Icon_Status_Poisoned";
		}
		if (PlayerPrefs.GetInt("drought", 1) == 0)
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = "Discovered Area";
		}
		else
		{
			this.GIFLQINIOEQ[2].BLHCINIPJLC(" has no mainTexture setter");
		}
		if (PlayerPrefs.GetInt("The Pokémon transforms itself into the Pokémon it's facing.", 1) == 1)
		{
			this.GIFLQINIOEQ[-10].BGBMIEJJQKC = "ResolutionY";
		}
		else
		{
			this.GIFLQINIOEQ[77].BGBMIEJJQKC = "u";
		}
		if (PlayerPrefs.GetInt(":", 0) == 1)
		{
			this.GIFLQINIOEQ[-2].BGBMIEJJQKC = "m_TangentMode";
		}
		else
		{
			this.GIFLQINIOEQ[119].BGBMIEJJQKC = "Powers up aura and pulse moves.";
		}
		if (PlayerPrefs.GetInt("OnClick", 0) == 0)
		{
			this.GIFLQINIOEQ[20].BGBMIEJJQKC = ":";
		}
		else
		{
			this.GIFLQINIOEQ[-112].BLHCINIPJLC("!\r\n");
		}
		if (PlayerPrefs.GetInt("map:", 1) == 1)
		{
			this.GIFLQINIOEQ[114].BLHCINIPJLC("BattlePoke");
		}
		else
		{
			this.GIFLQINIOEQ[-104].BGBMIEJJQKC = "M0";
		}
		if (PlayerPrefs.GetInt("_FogPointLightColor2", 0) == 1)
		{
			this.GIFLQINIOEQ[-75].BGBMIEJJQKC = "desolateland";
		}
		else
		{
			this.GIFLQINIOEQ[58].BLHCINIPJLC("FOG_VOID_BOX");
		}
		if (PlayerPrefs.GetInt("[-]", 1) == 1)
		{
			this.GIFLQINIOEQ[-28].BLHCINIPJLC("BuffIcon_MaleIncrease");
		}
		else
		{
			this.GIFLQINIOEQ[112].BLHCINIPJLC("[ffff00]Wide Guard[-] protected ");
		}
		this.GIFLQINIOEQ[53].BGBMIEJJQKC = PlayerPrefs.GetInt("UpdateTime", -62).ToString();
		if (PlayerPrefs.GetInt("Materials/DFODesktop", 1) == 1)
		{
			this.GIFLQINIOEQ[38].BLHCINIPJLC("whirlpool");
		}
		else
		{
			this.GIFLQINIOEQ[-11].BGBMIEJJQKC = "Move Learning";
		}
		this.IFPMOEQCCFG[0].GIPBBFDPCKG(PlayerPrefs.GetFloat("The extremely harsh sunlightwas not lessened at all!\r\n", 1763f));
		this.IFPMOEQCCFG[0].PLLQOHPCBOP(PlayerPrefs.GetFloat("[-]!\r\n", 1959f));
		if (DCCFQPDFBFO.DGCQMNHFQNH() != null)
		{
			DCCFQPDFBFO.CLPQIKCDHPP().NJBIMOKLDBD = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
			DCCFQPDFBFO.ONBDGGPLFQK().EEOPJMPGFME = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
		}
	}

	// Token: 0x06003FD1 RID: 16337 RVA: 0x0001AB44 File Offset: 0x00018D44
	public void CJKNEHCFEQL()
	{
		this.BMENEKIDBMB.enabled = false;
		this.MJIGLPMMDJL.SetActive(this.DCPLMGJCFNP);
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x0001A86E File Offset: 0x00018A6E
	public void AfterOptionsTween()
	{
		this.BMENEKIDBMB.enabled = false;
		this.MJIGLPMMDJL.SetActive(!this.DCPLMGJCFNP);
	}

	// Token: 0x06003FD3 RID: 16339 RVA: 0x0001AB66 File Offset: 0x00018D66
	public void NFNFPCIPMFH()
	{
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[6].SetActive(true);
		this.LFHEGBFOEGJ(0);
	}

	// Token: 0x06003FD4 RID: 16340 RVA: 0x001F7B74 File Offset: 0x001F5D74
	public void FBCHCGPGQJF()
	{
		this.BMENEKIDBMB.enabled = true;
		if (this.MJIGLPMMDJL.activeSelf)
		{
			this.BMENEKIDBMB.PlayReverse();
			this.DCPLMGJCFNP = true;
		}
		else
		{
			this.HPNEOHEIDGB();
			this.MJIGLPMMDJL.SetActive(false);
			if (this.MJIGLPMMDJL.GetComponentInChildren<KIQKEMNELKN>() != null)
			{
				this.MJIGLPMMDJL.GetComponentInChildren<KIQKEMNELKN>().PHELNLKIKEG();
			}
			IKBQNBHOJJB.OKLNNGPNIEO(this.MJIGLPMMDJL);
			this.BMENEKIDBMB.PlayForward();
			this.DCPLMGJCFNP = true;
		}
	}

	// Token: 0x06003FD5 RID: 16341 RVA: 0x001F7C00 File Offset: 0x001F5E00
	public void Close()
	{
		this.OpenCloseOptions();
		this.IFPMOEQCCFG[0].BGBMIEJJQKC = PlayerPrefs.GetFloat("Music", 0.8f);
		this.IFPMOEQCCFG[1].BGBMIEJJQKC = PlayerPrefs.GetFloat("Sound", 1f);
		if (DCCFQPDFBFO.QOQONHOOLNE != null)
		{
			DCCFQPDFBFO.QOQONHOOLNE.NJBIMOKLDBD = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
			DCCFQPDFBFO.QOQONHOOLNE.EEOPJMPGFME = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
			this.UpdateMusicVolume();
		}
	}

	// Token: 0x06003FD6 RID: 16342 RVA: 0x0001AB99 File Offset: 0x00018D99
	public void MMKLDPHODHE()
	{
		this.OJMBICCDMFM();
		this.MJIGLPMMDJL.SetActive(true);
		this.OpenCloseOptions();
		this.MFEGPNHHOJQ();
	}

	// Token: 0x06003FD7 RID: 16343 RVA: 0x0001A753 File Offset: 0x00018953
	public void HOBGONDIQEK()
	{
		this.Apply(false);
		this.OpenCloseOptions();
	}

	// Token: 0x06003FD8 RID: 16344 RVA: 0x0001A90F File Offset: 0x00018B0F
	public void CGIKBECMBJF()
	{
		this.FNMLCJDOQFK.enabled = false;
		this.NFFIHJOBCLH.SetActive(!this.NPOGCMKIDKK);
	}

	// Token: 0x06003FD9 RID: 16345 RVA: 0x001F7C8C File Offset: 0x001F5E8C
	private void CPJJKJLFOEN()
	{
		Application.targetFrameRate = 72;
		this.HGLNLNGMIOF();
		this.Apply(true);
		if (PlayerPrefs.GetInt("[SHINY]", 0) == 0)
		{
			Resolution currentResolution = Screen.currentResolution;
			Screen.SetResolution(currentResolution.width, currentResolution.height, false);
		}
		else
		{
			bool fullscreen = true;
			if (this.GIFLQINIOEQ[0].LGNFPGFPBII() == "\\")
			{
				fullscreen = true;
			}
			Screen.SetResolution(PlayerPrefs.GetInt(",0+", -197), PlayerPrefs.GetInt("Sound", -188), fullscreen);
		}
	}

	// Token: 0x06003FDA RID: 16346 RVA: 0x0001A798 File Offset: 0x00018998
	public void NFHIDGKQGOO()
	{
		this.NFFIHJOBCLH.SetActive(true);
		this.OpenCloseMenu();
	}

	// Token: 0x06003FDB RID: 16347 RVA: 0x0001ABB9 File Offset: 0x00018DB9
	public void ShowTab2()
	{
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[1].SetActive(true);
		this.PKBOPNPKQOG[2].SetActive(false);
		this.OPGEJKPEGHP(1);
	}

	// Token: 0x06003FDC RID: 16348 RVA: 0x001F7D18 File Offset: 0x001F5F18
	public void OJMBICCDMFM()
	{
		if (PlayerPrefs.GetInt("Small/", 0) == 0)
		{
			this.GIFLQINIOEQ[1].BGBMIEJJQKC = "missingno.";
		}
		else
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "FOG_EXP";
		}
		if (PlayerPrefs.GetInt("Data/items", 0) == 0)
		{
			this.GIFLQINIOEQ[3].BLHCINIPJLC("snowman");
		}
		else
		{
			this.GIFLQINIOEQ[1].BGBMIEJJQKC = ". Using default.";
		}
		if (PlayerPrefs.GetInt("Player/Mounts/", 1) == 0)
		{
			this.GIFLQINIOEQ[3].BLHCINIPJLC("smokeball");
		}
		else if (PlayerPrefs.GetInt("Mysterious strong winds are protecting Flying-type Pokemon!", 0) == 3)
		{
			this.GIFLQINIOEQ[7].BLHCINIPJLC("Fullscreen");
		}
		else if (PlayerPrefs.GetInt("OnClick", 0) == 1)
		{
			this.GIFLQINIOEQ[2].BGBMIEJJQKC = "craftyshield";
		}
		else
		{
			this.GIFLQINIOEQ[8].BGBMIEJJQKC = "_ReflectionTexture4";
		}
		if (PlayerPrefs.GetInt("redcard", 0) == 0)
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = "Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_8_Light.mat";
		}
		else
		{
			this.GIFLQINIOEQ[7].BLHCINIPJLC("HidePanel");
		}
		if (PlayerPrefs.GetInt("last online ", 0) == 0)
		{
			this.GIFLQINIOEQ[3].BGBMIEJJQKC = "Magma Armor";
		}
		else
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "Big/";
		}
		if (PlayerPrefs.GetInt("inven ", 1) == 1)
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("Teleport");
		}
		else
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "HM";
		}
		if (PlayerPrefs.GetInt("map:", 0) == 0)
		{
			this.GIFLQINIOEQ[1].BLHCINIPJLC("Monsters/");
		}
		else
		{
			this.GIFLQINIOEQ[5].BLHCINIPJLC(" minute");
		}
		if (PlayerPrefs.GetInt("Hidden/Post FX/Builtin Debug Views", 1) == 1)
		{
			this.GIFLQINIOEQ[-25].BLHCINIPJLC("item");
		}
		else
		{
			this.GIFLQINIOEQ[-47].BGBMIEJJQKC = "SendMessage is bugged when you try to pass 'null' in the parameter field. It behaves as if no parameter was specified.";
		}
		if (PlayerPrefs.GetInt("CloseIfUnselected", 0) == 1)
		{
			this.GIFLQINIOEQ[126].BGBMIEJJQKC = "Blank";
		}
		else
		{
			this.GIFLQINIOEQ[-5].BLHCINIPJLC("Fly");
		}
		if (PlayerPrefs.GetInt("[FF8F00]", 0) == 0)
		{
			this.GIFLQINIOEQ[27].BGBMIEJJQKC = "[FFC300]";
		}
		else
		{
			this.GIFLQINIOEQ[36].BGBMIEJJQKC = "_1";
		}
		if (PlayerPrefs.GetInt("Not So Lucky", 0) == 0)
		{
			this.GIFLQINIOEQ[110].BGBMIEJJQKC = "ability";
		}
		else
		{
			this.GIFLQINIOEQ[-13].BGBMIEJJQKC = "tox";
		}
		if (PlayerPrefs.GetInt("UI", 0) == 0)
		{
			this.GIFLQINIOEQ[-74].BLHCINIPJLC("gen");
		}
		else
		{
			this.GIFLQINIOEQ[-100].BLHCINIPJLC("Forward Focus");
		}
		if (PlayerPrefs.GetInt("Big/", 0) == 1)
		{
			this.GIFLQINIOEQ[12].BLHCINIPJLC("_Contrast");
		}
		else
		{
			this.GIFLQINIOEQ[72].BGBMIEJJQKC = "4x";
		}
		this.GIFLQINIOEQ[94].BGBMIEJJQKC = PlayerPrefs.GetInt("hyperspacefury", -111).ToString();
		if (PlayerPrefs.GetInt("input", 0) == 0)
		{
			this.GIFLQINIOEQ[67].BGBMIEJJQKC = "DN";
		}
		else
		{
			this.GIFLQINIOEQ[-93].BLHCINIPJLC("battler");
		}
		this.IFPMOEQCCFG[0].GIPBBFDPCKG(PlayerPrefs.GetFloat("_Color", 74f));
		this.IFPMOEQCCFG[1].PLLQOHPCBOP(PlayerPrefs.GetFloat("0", 815f));
		if (DCCFQPDFBFO.CLPQIKCDHPP() != null)
		{
			DCCFQPDFBFO.CDDIILFBFCF().NJBIMOKLDBD = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
			DCCFQPDFBFO.DGCQMNHFQNH().EEOPJMPGFME = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		}
	}

	// Token: 0x06003FDD RID: 16349 RVA: 0x0001ABEC File Offset: 0x00018DEC
	public void KNHJOQDFFEM()
	{
		this.PKBOPNPKQOG[1].SetActive(true);
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[3].SetActive(true);
		this.LKCBEJPIMHK(2);
	}

	// Token: 0x06003FDE RID: 16350 RVA: 0x0001AC1F File Offset: 0x00018E1F
	public void OCNLPONEPEE()
	{
		this.GBGIJHEIHNB(false);
		this.OpenCloseOptions();
	}

	// Token: 0x06003FDF RID: 16351 RVA: 0x0001AC2E File Offset: 0x00018E2E
	public void GHBMKEPOCMQ()
	{
		DCCFQPDFBFO.ELBNNCEGBDH().NJBIMOKLDBD = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
		DCCFQPDFBFO.CLPQIKCDHPP().EEOPJMPGFME = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
		DCCFQPDFBFO.OMPHLNDGKKM().BIHDFMKGJQD();
	}

	// Token: 0x06003FE0 RID: 16352 RVA: 0x0001AC68 File Offset: 0x00018E68
	public void NPHPJKGPQON()
	{
		DCCFQPDFBFO.ONBDGGPLFQK().NJBIMOKLDBD = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
		DCCFQPDFBFO.DGCQMNHFQNH().EEOPJMPGFME = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		DCCFQPDFBFO.CLPQIKCDHPP().BQQPBFNLKOB();
	}

	// Token: 0x06003FE1 RID: 16353 RVA: 0x0001ACA2 File Offset: 0x00018EA2
	public void KKEJDLCBDPF()
	{
		DCCFQPDFBFO.ELBNNCEGBDH().NJBIMOKLDBD = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		DCCFQPDFBFO.ELBNNCEGBDH().EEOPJMPGFME = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
		DCCFQPDFBFO.CDDIILFBFCF().QCPFQLNECGP();
	}

	// Token: 0x06003FE2 RID: 16354 RVA: 0x0001ACDC File Offset: 0x00018EDC
	public void FEPOEDQPPDK()
	{
		this.PKBOPNPKQOG[1].SetActive(false);
		this.PKBOPNPKQOG[0].SetActive(false);
		this.PKBOPNPKQOG[2].SetActive(false);
		this.LKCBEJPIMHK(0);
	}

	// Token: 0x06003FE3 RID: 16355 RVA: 0x001F80EC File Offset: 0x001F62EC
	public void HCPHCOGIPJC()
	{
		if (PlayerPrefs.GetInt("[00FF00]+", 1) == 0)
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("_TreatBackfaceHitAsMiss");
		}
		else
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = " melted the ice!\r\n";
		}
		if (PlayerPrefs.GetInt("dots", 0) == 1)
		{
			this.GIFLQINIOEQ[3].BLHCINIPJLC(" declined the Trade Request.");
		}
		else
		{
			this.GIFLQINIOEQ[2].BGBMIEJJQKC = "Materials/DFOSimple";
		}
		if (PlayerPrefs.GetInt("p1", 0) == 1)
		{
			this.GIFLQINIOEQ[4].BLHCINIPJLC("Player/Clothe");
		}
		else if (PlayerPrefs.GetInt("confusion", 0) == 1)
		{
			this.GIFLQINIOEQ[2].BLHCINIPJLC("_Texture2");
		}
		else if (PlayerPrefs.GetInt("0", 1) == 2)
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = " hours";
		}
		else
		{
			this.GIFLQINIOEQ[1].BLHCINIPJLC("game3.poke.one");
		}
		if (PlayerPrefs.GetInt("substitute", 1) == 0)
		{
			this.GIFLQINIOEQ[8].BLHCINIPJLC("highjumpkick");
		}
		else
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = "!\r\n";
		}
		if (PlayerPrefs.GetInt("deltrastream", 1) == 0)
		{
			this.GIFLQINIOEQ[3].BGBMIEJJQKC = "UpdateAnchors";
		}
		else
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "Trainer_Battle";
		}
		if (PlayerPrefs.GetInt("Down", 1) == 1)
		{
			this.GIFLQINIOEQ[7].BLHCINIPJLC("-");
		}
		else
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "[ffb649]";
		}
		if (PlayerPrefs.GetInt("x", 0) == 0)
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "You just leveled up!";
		}
		else
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = "[-]";
		}
		if (PlayerPrefs.GetInt("(LB)", 0) == 1)
		{
			this.GIFLQINIOEQ[-18].BLHCINIPJLC("'s electromagnetism wore off!\r\n");
		}
		else
		{
			this.GIFLQINIOEQ[-59].BLHCINIPJLC("TweenLetters encountered an unhandled case trying to modify a vertex ");
		}
		if (PlayerPrefs.GetInt("Can't find room with index: ", 1) == 0)
		{
			this.GIFLQINIOEQ[109].BGBMIEJJQKC = "Anger Point";
		}
		else
		{
			this.GIFLQINIOEQ[21].BGBMIEJJQKC = "'s [ffff00]";
		}
		if (PlayerPrefs.GetInt("0", 0) == 0)
		{
			this.GIFLQINIOEQ[-113].BGBMIEJJQKC = "[-]!\r\n";
		}
		else
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("Remove from Friends");
		}
		if (PlayerPrefs.GetInt("F7", 0) == 1)
		{
			this.GIFLQINIOEQ[2].BGBMIEJJQKC = "[/pok][/o]";
		}
		else
		{
			this.GIFLQINIOEQ[53].BLHCINIPJLC("BuffIcon_Repel");
		}
		if (PlayerPrefs.GetInt("[-] is trying to evolve into [FF9900]", 0) == 1)
		{
			this.GIFLQINIOEQ[69].BLHCINIPJLC("[");
		}
		else
		{
			this.GIFLQINIOEQ[-37].BGBMIEJJQKC = "Trainer_Battle";
		}
		if (PlayerPrefs.GetInt("_Grain_Params2", 0) == 1)
		{
			this.GIFLQINIOEQ[74].BLHCINIPJLC("Kick");
		}
		else
		{
			this.GIFLQINIOEQ[-107].BGBMIEJJQKC = "(K)";
		}
		this.GIFLQINIOEQ[117].BLHCINIPJLC(PlayerPrefs.GetInt("The Pokémon is full of vitality, and that prevents it from falling asleep.", 117).ToString());
		if (PlayerPrefs.GetInt("grasspledge", 0) == 1)
		{
			this.GIFLQINIOEQ[-121].BLHCINIPJLC("OnDragOver");
		}
		else
		{
			this.GIFLQINIOEQ[118].BGBMIEJJQKC = "_FogPointLightPosition1";
		}
		this.IFPMOEQCCFG[0].BGBMIEJJQKC = PlayerPrefs.GetFloat("_Direction", 126f);
		this.IFPMOEQCCFG[0].BGBMIEJJQKC = PlayerPrefs.GetFloat("castformrainy", 142f);
		if (DCCFQPDFBFO.QOQONHOOLNE != null)
		{
			DCCFQPDFBFO.CLPQIKCDHPP().NJBIMOKLDBD = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
			DCCFQPDFBFO.QOQONHOOLNE.EEOPJMPGFME = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
		}
	}

	// Token: 0x06003FE4 RID: 16356 RVA: 0x001F84C0 File Offset: 0x001F66C0
	private void DHLGDLOKLKN()
	{
		Application.targetFrameRate = 116;
		this.OJMBICCDMFM();
		this.GBGIJHEIHNB(false);
		if (PlayerPrefs.GetInt("-waiting", 0) == 0)
		{
			Resolution currentResolution = Screen.currentResolution;
			Screen.SetResolution(currentResolution.width, currentResolution.height, false);
		}
		else
		{
			bool fullscreen = false;
			if (this.GIFLQINIOEQ[1].DMBBLJCLCEJ() == "Enabled")
			{
				fullscreen = true;
			}
			Screen.SetResolution(PlayerPrefs.GetInt("_Texture2", 20), PlayerPrefs.GetInt("_ClotheTex", -160), fullscreen);
		}
	}

	// Token: 0x06003FE5 RID: 16357 RVA: 0x001F854C File Offset: 0x001F674C
	public void DPLQNCIFJJD()
	{
		if (PlayerPrefs.GetInt("/", 1) == 0)
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("_");
		}
		else
		{
			this.GIFLQINIOEQ[1].BGBMIEJJQKC = " is immobilized by love!\r\n";
		}
		if (PlayerPrefs.GetInt("(R)", 0) == 0)
		{
			this.GIFLQINIOEQ[6].BLHCINIPJLC("-swapboost");
		}
		else
		{
			this.GIFLQINIOEQ[3].BLHCINIPJLC("_TraceBehindObjects");
		}
		if (PlayerPrefs.GetInt("17", 1) == 0)
		{
			this.GIFLQINIOEQ[6].BLHCINIPJLC("deltrastream");
		}
		else if (PlayerPrefs.GetInt(" days ago", 0) == 4)
		{
			this.GIFLQINIOEQ[5].BLHCINIPJLC(" did not learn the move ");
		}
		else if (PlayerPrefs.GetInt("The attacker will receive the same status condition if it inflicts a burn, poison, or paralysis to the Pokémon.", 0) == 2)
		{
			this.GIFLQINIOEQ[8].BGBMIEJJQKC = "flowerveil";
		}
		else
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "bump";
		}
		if (PlayerPrefs.GetInt("[PG]", 1) == 1)
		{
			this.GIFLQINIOEQ[2].BGBMIEJJQKC = "Boosts the likelihood of additional effects occurring when attacking.";
		}
		else
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("F");
		}
		if (PlayerPrefs.GetInt("0", 0) == 1)
		{
			this.GIFLQINIOEQ[3].BGBMIEJJQKC = "inven ";
		}
		else
		{
			this.GIFLQINIOEQ[6].BLHCINIPJLC("_");
		}
		if (PlayerPrefs.GetInt("[NGUI] ", 1) == 1)
		{
			this.GIFLQINIOEQ[3].BGBMIEJJQKC = "Pokédex Seen:";
		}
		else
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("Sticky Hold");
		}
		if (PlayerPrefs.GetInt("!\r\n", 1) == 0)
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "[00FF00]+";
		}
		else
		{
			this.GIFLQINIOEQ[6].BGBMIEJJQKC = "!\r\n";
		}
		if (PlayerPrefs.GetInt("BuffIcon_Fly", 0) == 0)
		{
			this.GIFLQINIOEQ[-43].BGBMIEJJQKC = "It broke through ";
		}
		else
		{
			this.GIFLQINIOEQ[100].BLHCINIPJLC("'s Money will go over the money cap.");
		}
		if (PlayerPrefs.GetInt("Party", 0) == 1)
		{
			this.GIFLQINIOEQ[-42].BGBMIEJJQKC = "_HueShift";
		}
		else
		{
			this.GIFLQINIOEQ[104].BGBMIEJJQKC = "CombinersArgsAlphaSrc2";
		}
		if (PlayerPrefs.GetInt("wonderskin", 1) == 1)
		{
			this.GIFLQINIOEQ[116].BLHCINIPJLC("Sweet Veil");
		}
		else
		{
			this.GIFLQINIOEQ[-102].BGBMIEJJQKC = "Comatose";
		}
		if (PlayerPrefs.GetInt("Data/pokemonmodels", 1) == 1)
		{
			this.GIFLQINIOEQ[-20].BLHCINIPJLC("battlearmor");
		}
		else
		{
			this.GIFLQINIOEQ[55].BLHCINIPJLC("The specified Port ");
		}
		if (PlayerPrefs.GetInt("_VolumetricFog_OpaqueFrame", 1) == 0)
		{
			this.GIFLQINIOEQ[18].BGBMIEJJQKC = "instruct";
		}
		else
		{
			this.GIFLQINIOEQ[92].BGBMIEJJQKC = "9";
		}
		if (PlayerPrefs.GetInt("_MainTex", 0) == 0)
		{
			this.GIFLQINIOEQ[-72].BGBMIEJJQKC = "[PG]";
		}
		else
		{
			this.GIFLQINIOEQ[44].BLHCINIPJLC("mdata");
		}
		this.GIFLQINIOEQ[-57].BLHCINIPJLC(PlayerPrefs.GetInt("VolumetricFogAndMist/Chaos Lerp", -128).ToString());
		if (PlayerPrefs.GetInt("Geometry Boundaries", 0) == 0)
		{
			this.GIFLQINIOEQ[-24].BLHCINIPJLC("HH:mm:ss");
		}
		else
		{
			this.GIFLQINIOEQ[-73].BGBMIEJJQKC = "Unable to convert ";
		}
		this.IFPMOEQCCFG[0].BGBMIEJJQKC = PlayerPrefs.GetFloat("Logging in..", 1003f);
		this.IFPMOEQCCFG[1].GIPBBFDPCKG(PlayerPrefs.GetFloat("#,##0", 1159f));
		if (DCCFQPDFBFO.ELBNNCEGBDH() != null)
		{
			DCCFQPDFBFO.CDDIILFBFCF().NJBIMOKLDBD = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
			DCCFQPDFBFO.QQCNCIQQPIG().EEOPJMPGFME = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
		}
	}

	// Token: 0x06003FE6 RID: 16358 RVA: 0x0001AD0F File Offset: 0x00018F0F
	public void UpdateMusicVolume()
	{
		DCCFQPDFBFO.QOQONHOOLNE.NJBIMOKLDBD = this.IFPMOEQCCFG[0].BGBMIEJJQKC;
		DCCFQPDFBFO.QOQONHOOLNE.EEOPJMPGFME = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		DCCFQPDFBFO.QOQONHOOLNE.JKOIIECCOIL();
	}

	// Token: 0x06003FE7 RID: 16359 RVA: 0x001F8920 File Offset: 0x001F6B20
	private void Start()
	{
		Application.targetFrameRate = 90;
		this.BJNHBGHBHII();
		this.Apply(true);
		if (PlayerPrefs.GetInt("ResolutionX", 0) == 0)
		{
			Resolution currentResolution = Screen.currentResolution;
			Screen.SetResolution(currentResolution.width, currentResolution.height, true);
		}
		else
		{
			bool fullscreen = false;
			if (this.GIFLQINIOEQ[0].BGBMIEJJQKC == "Fullscreen")
			{
				fullscreen = true;
			}
			Screen.SetResolution(PlayerPrefs.GetInt("ResolutionX", 800), PlayerPrefs.GetInt("ResolutionY", 600), fullscreen);
		}
	}

	// Token: 0x06003FE8 RID: 16360 RVA: 0x0001AD49 File Offset: 0x00018F49
	public void QILDFCPQPKO()
	{
		DCCFQPDFBFO.DGCQMNHFQNH().NJBIMOKLDBD = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		DCCFQPDFBFO.ELBNNCEGBDH().EEOPJMPGFME = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
		DCCFQPDFBFO.CLPQIKCDHPP().CNOFCGMEDNE();
	}

	// Token: 0x06003FE9 RID: 16361 RVA: 0x0001760B File Offset: 0x0001580B
	public void JNCHOPDIOHN()
	{
		Application.Quit();
	}

	// Token: 0x06003FEA RID: 16362 RVA: 0x0001AD83 File Offset: 0x00018F83
	public void FCOOQIDIGKI()
	{
		DCCFQPDFBFO.CDDIILFBFCF().NJBIMOKLDBD = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
		DCCFQPDFBFO.QOQONHOOLNE.EEOPJMPGFME = this.IFPMOEQCCFG[1].BGBMIEJJQKC;
		DCCFQPDFBFO.CDDIILFBFCF().BIHDFMKGJQD();
	}

	// Token: 0x06003FEB RID: 16363 RVA: 0x001F89AC File Offset: 0x001F6BAC
	public void IKLQPFEMGIO()
	{
		if (PlayerPrefs.GetInt(".", 1) == 1)
		{
			this.GIFLQINIOEQ[1].BGBMIEJJQKC = "qdTrack";
		}
		else
		{
			this.GIFLQINIOEQ[1].BGBMIEJJQKC = "perish1";
		}
		if (PlayerPrefs.GetInt("Shadow Shield", 1) == 1)
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = "darkvoid";
		}
		else
		{
			this.GIFLQINIOEQ[0].BLHCINIPJLC("general");
		}
		if (PlayerPrefs.GetInt("Sound", 0) == 0)
		{
			this.GIFLQINIOEQ[8].BGBMIEJJQKC = "Hold or Use?";
		}
		else if (PlayerPrefs.GetInt(" can't use the move!\r\n", 0) == 0)
		{
			this.GIFLQINIOEQ[4].BLHCINIPJLC("confusion");
		}
		else if (PlayerPrefs.GetInt("_VFM_CutOff", 0) == 5)
		{
			this.GIFLQINIOEQ[7].BLHCINIPJLC("flyLimit");
		}
		else
		{
			this.GIFLQINIOEQ[2].BLHCINIPJLC("2");
		}
		if (PlayerPrefs.GetInt("General", 1) == 1)
		{
			this.GIFLQINIOEQ[4].BLHCINIPJLC("-item");
		}
		else
		{
			this.GIFLQINIOEQ[3].BGBMIEJJQKC = "][{";
		}
		if (PlayerPrefs.GetInt("[FF8F00]", 0) == 1)
		{
			this.GIFLQINIOEQ[5].BGBMIEJJQKC = "' is already present";
		}
		else
		{
			this.GIFLQINIOEQ[7].BLHCINIPJLC("Fullscreen");
		}
		if (PlayerPrefs.GetInt("harvest", 1) == 0)
		{
			this.GIFLQINIOEQ[3].BGBMIEJJQKC = "A";
		}
		else
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "3";
		}
		if (PlayerPrefs.GetInt("+", 1) == 0)
		{
			this.GIFLQINIOEQ[4].BLHCINIPJLC(" clip regions");
		}
		else
		{
			this.GIFLQINIOEQ[2].BGBMIEJJQKC = " Pokédollars.";
		}
		if (PlayerPrefs.GetInt("Data/items", 0) == 0)
		{
			this.GIFLQINIOEQ[-60].BLHCINIPJLC(" specified");
		}
		else
		{
			this.GIFLQINIOEQ[0].BGBMIEJJQKC = "UP";
		}
		if (PlayerPrefs.GetInt("_Dissolve", 1) == 1)
		{
			this.GIFLQINIOEQ[-38].BGBMIEJJQKC = "protean";
		}
		else
		{
			this.GIFLQINIOEQ[17].BGBMIEJJQKC = "anticipation";
		}
		if (PlayerPrefs.GetInt("_", 0) == 0)
		{
			this.GIFLQINIOEQ[-125].BLHCINIPJLC("HideResponse");
		}
		else
		{
			this.GIFLQINIOEQ[49].BLHCINIPJLC("But it failed! ");
		}
		if (PlayerPrefs.GetInt("_DetailOffsetX", 0) == 0)
		{
			this.GIFLQINIOEQ[-10].BLHCINIPJLC(" was cured of its poisoning.\r\n");
		}
		else
		{
			this.GIFLQINIOEQ[31].BLHCINIPJLC("blank");
		}
		if (PlayerPrefs.GetInt("_Fade", 0) == 1)
		{
			this.GIFLQINIOEQ[-103].BGBMIEJJQKC = "[sub]";
		}
		else
		{
			this.GIFLQINIOEQ[102].BLHCINIPJLC("_Jitter");
		}
		if (PlayerPrefs.GetInt("[PG]", 0) == 0)
		{
			this.GIFLQINIOEQ[-20].BLHCINIPJLC("Poison spikes were scattered on the ground all around ");
		}
		else
		{
			this.GIFLQINIOEQ[-13].BGBMIEJJQKC = " intends to flip up a mat and block incoming attacks!\r\n";
		}
		this.GIFLQINIOEQ[-78].BLHCINIPJLC(PlayerPrefs.GetInt("'s move was postponed!\r\n", -109).ToString());
		if (PlayerPrefs.GetInt("ability", 0) == 0)
		{
			this.GIFLQINIOEQ[4].BGBMIEJJQKC = " PM";
		}
		else
		{
			this.GIFLQINIOEQ[-114].BLHCINIPJLC("TM");
		}
		this.IFPMOEQCCFG[0].PLLQOHPCBOP(PlayerPrefs.GetFloat("Socket not connected anymore", 633f));
		this.IFPMOEQCCFG[0].PLLQOHPCBOP(PlayerPrefs.GetFloat("[/U]", 139f));
		if (DCCFQPDFBFO.OMPHLNDGKKM() != null)
		{
			DCCFQPDFBFO.DGCQMNHFQNH().NJBIMOKLDBD = this.IFPMOEQCCFG[1].HKDJGHOHBFQ();
			DCCFQPDFBFO.CLPQIKCDHPP().EEOPJMPGFME = this.IFPMOEQCCFG[0].HKDJGHOHBFQ();
		}
	}

	// Token: 0x04000DFE RID: 3582
	public GameObject MJIGLPMMDJL;

	// Token: 0x04000DFF RID: 3583
	public GameObject NFFIHJOBCLH;

	// Token: 0x04000E00 RID: 3584
	public QCPKMJONIGF[] GIFLQINIOEQ;

	// Token: 0x04000E01 RID: 3585
	public HLEKPGPJOOK[] IFPMOEQCCFG;

	// Token: 0x04000E02 RID: 3586
	public GameObject PJBDQHMDFNG;

	// Token: 0x04000E03 RID: 3587
	public GameObject[] PKBOPNPKQOG;

	// Token: 0x04000E04 RID: 3588
	public CFDMNELIJLO[] PGBLHMLDGOJ;

	// Token: 0x04000E05 RID: 3589
	public bool PCJIQBHPNEP = true;

	// Token: 0x04000E06 RID: 3590
	public bool OOJMKCLOQPD;

	// Token: 0x04000E07 RID: 3591
	public bool KGGCOFHHKEK = true;

	// Token: 0x04000E08 RID: 3592
	public bool EMFDMGHDBOC;

	// Token: 0x04000E09 RID: 3593
	public bool MLQKMBCHFLL;

	// Token: 0x04000E0A RID: 3594
	public bool MJGMICNJJBE;

	// Token: 0x04000E0B RID: 3595
	public bool PFODCGLOHFD;

	// Token: 0x04000E0C RID: 3596
	public int GMDLOGMNDCJ = 10;

	// Token: 0x04000E0D RID: 3597
	public NKHMKQEGHEE FOHEKCKHDDO;

	// Token: 0x04000E0E RID: 3598
	private bool DCPLMGJCFNP;

	// Token: 0x04000E0F RID: 3599
	private bool NPOGCMKIDKK;

	// Token: 0x04000E10 RID: 3600
	public EPIJJNOIKEK BMENEKIDBMB;

	// Token: 0x04000E11 RID: 3601
	public EPIJJNOIKEK FNMLCJDOQFK;
}

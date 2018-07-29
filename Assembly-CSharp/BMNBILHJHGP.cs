using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001E8 RID: 488
public class BMNBILHJHGP : MonoBehaviour
{
	// Token: 0x06004003 RID: 16387 RVA: 0x0001ADBD File Offset: 0x00018FBD
	public void HJEFIPJDEEK(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
	{
		this.PKKLDKIIMHJ(JMDLLJPEFKM.NKKMJICKKLB, null, JMDLLJPEFKM.DCENLGCQFDN, JMDLLJPEFKM.GBHNGPOGCGC, JMDLLJPEFKM.NPMDMKHKQNQ);
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x00002300 File Offset: 0x00000500
	private void LMMGEGJCBJP()
	{
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x001F8D80 File Offset: 0x001F6F80
	public void PKKLDKIIMHJ(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP, List<BMNBILHJHGP.IHFPKIJMPGJ> BPBGMBIFMFE = null, GameObject BLDHKNGOJKE = null, bool DOCOEQKFDQD = false)
	{
		if (BLDHKNGOJKE == null)
		{
			BLDHKNGOJKE = base.gameObject;
		}
		this.GBHNGPOGCGC = BLDHKNGOJKE;
		this.HDNDNHJMCBG = this.GBHNGPOGCGC.GetComponent<BMNBILHJHGP>().HDNDNHJMCBG;
		if (this.BCPJIPBJODP == null)
		{
			this.BCPJIPBJODP = base.GetComponent<ENFMCDNLEQQ>();
			this.BCPJIPBJODP.DFKQMMIQDOO = 8;
			if (this.HOKOFHFFQBD)
			{
				this.BCPJIPBJODP.DFKQMMIQDOO = 36;
			}
		}
		GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.MHEEIGENKDD);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().PIDLOFMIEFQ = HIEFQEEDHGG;
		if (!DOCOEQKFDQD)
		{
			gameObject.GetComponentInChildren<JLMPBLMOICG>().gameObject.SetActive(false);
		}
		gameObject.GetComponent<IOBPBHFNNOM>().PDHDBQFJCFP = PDHDBQFJCFP;
		gameObject.GetComponent<IOBPBHFNNOM>().NKMBOJLEGDQ = this.HDNDNHJMCBG;
		gameObject.GetComponent<CFDMNELIJLO>().enabled = true;
		gameObject.name = "Button";
		this.IEKBMQPIKEB.Add(gameObject);
		if (this.HOKOFHFFQBD)
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].transform.localPosition = new Vector3(85f, (float)(-17 - this.IEKBMQPIKEB.Count * 28), 0f);
		}
		else
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].transform.localPosition = new Vector3(85f, (float)(10 - this.IEKBMQPIKEB.Count * 28), 0f);
		}
		this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].GetComponent<IOBPBHFNNOM>().PJJHJMJBCBK = this;
		if (BPBGMBIFMFE != null)
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].AddComponent<JCHHLCFOCFI>();
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].GetComponent<IOBPBHFNNOM>().MFONIPHOFGF = this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].GetComponent<JCHHLCFOCFI>();
			this.PCFNCHKGFPQ = base.GetComponentInParent<DFJHPCQKHKO>().PCFNCHKGFPQ;
			GameObject gameObject2 = base.gameObject.BFCKNMFEBDM(this.PCFNCHKGFPQ);
			gameObject2.name = "ContextMenu";
			gameObject2.transform.localPosition = this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].transform.localPosition + new Vector3((float)(this.BCPJIPBJODP.KJGMGPCEJJD / 2), 16f, 0f);
			gameObject2.GetComponent<BMNBILHJHGP>().GBHNGPOGCGC = BLDHKNGOJKE;
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].GetComponent<JCHHLCFOCFI>().BCPJIPBJODP = gameObject2.GetComponent<ENFMCDNLEQQ>();
			gameObject2.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 0f;
			for (int i = 0; i < BPBGMBIFMFE.Count; i++)
			{
				if (BPBGMBIFMFE[i] != null)
				{
					gameObject2.GetComponent<BMNBILHJHGP>().PKKLDKIIMHJ(BPBGMBIFMFE[i].NKKMJICKKLB, BPBGMBIFMFE[i].NBDBEMBFCMG, BPBGMBIFMFE[i].QBIKLQJPJFE, BLDHKNGOJKE, BPBGMBIFMFE[i].NPMDMKHKQNQ);
				}
			}
		}
		this.BCPJIPBJODP.DFKQMMIQDOO += 28;
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x001F90B0 File Offset: 0x001F72B0
	public void HHHQPPODOHF(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP, List<BMNBILHJHGP.IHFPKIJMPGJ> BPBGMBIFMFE = null, GameObject BLDHKNGOJKE = null, bool DOCOEQKFDQD = false)
	{
		if (BLDHKNGOJKE == null)
		{
			BLDHKNGOJKE = base.gameObject;
		}
		this.GBHNGPOGCGC = BLDHKNGOJKE;
		this.HDNDNHJMCBG = this.GBHNGPOGCGC.GetComponent<BMNBILHJHGP>().HDNDNHJMCBG;
		if (this.BCPJIPBJODP == null)
		{
			this.BCPJIPBJODP = base.GetComponent<ENFMCDNLEQQ>();
			this.BCPJIPBJODP.MGQIGGNBBBD(8);
			if (this.HOKOFHFFQBD)
			{
				this.BCPJIPBJODP.DFKQMMIQDOO = 37;
			}
		}
		GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.MHEEIGENKDD);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(HIEFQEEDHGG);
		if (!DOCOEQKFDQD)
		{
			gameObject.GetComponentInChildren<JLMPBLMOICG>().gameObject.SetActive(true);
		}
		gameObject.GetComponent<IOBPBHFNNOM>().PDHDBQFJCFP = PDHDBQFJCFP;
		gameObject.GetComponent<IOBPBHFNNOM>().NKMBOJLEGDQ = this.HDNDNHJMCBG;
		gameObject.GetComponent<CFDMNELIJLO>().enabled = true;
		gameObject.name = "bind";
		this.IEKBMQPIKEB.Add(gameObject);
		if (this.HOKOFHFFQBD)
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].transform.localPosition = new Vector3(1184f, (float)(-41 - this.IEKBMQPIKEB.Count * 80), 462f);
		}
		else
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].transform.localPosition = new Vector3(160f, (float)(22 - this.IEKBMQPIKEB.Count * -126), 1907f);
		}
		this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].GetComponent<IOBPBHFNNOM>().PJJHJMJBCBK = this;
		if (BPBGMBIFMFE != null)
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].AddComponent<JCHHLCFOCFI>();
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].GetComponent<IOBPBHFNNOM>().MFONIPHOFGF = this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].GetComponent<JCHHLCFOCFI>();
			this.PCFNCHKGFPQ = base.GetComponentInParent<DFJHPCQKHKO>().PCFNCHKGFPQ;
			GameObject gameObject2 = base.gameObject.BFCKNMFEBDM(this.PCFNCHKGFPQ);
			gameObject2.name = "psn";
			gameObject2.transform.localPosition = this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].transform.localPosition + new Vector3((float)(this.BCPJIPBJODP.KJGMGPCEJJD / 8), 1010f, 170f);
			gameObject2.GetComponent<BMNBILHJHGP>().GBHNGPOGCGC = BLDHKNGOJKE;
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].GetComponent<JCHHLCFOCFI>().BCPJIPBJODP = gameObject2.GetComponent<ENFMCDNLEQQ>();
			gameObject2.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 1517f;
			for (int i = 0; i < BPBGMBIFMFE.Count; i += 0)
			{
				if (BPBGMBIFMFE[i] != null)
				{
					gameObject2.GetComponent<BMNBILHJHGP>().PKKLDKIIMHJ(BPBGMBIFMFE[i].NKKMJICKKLB, BPBGMBIFMFE[i].NBDBEMBFCMG, BPBGMBIFMFE[i].QBIKLQJPJFE, BLDHKNGOJKE, BPBGMBIFMFE[i].NPMDMKHKQNQ);
				}
			}
		}
		ENFMCDNLEQQ bcpjipbjodp = this.BCPJIPBJODP;
		bcpjipbjodp.DFKQMMIQDOO = bcpjipbjodp.JKGBHEHKBPC() + -97;
	}

	// Token: 0x06004007 RID: 16391 RVA: 0x00002300 File Offset: 0x00000500
	private void LBIFHHFMPHD()
	{
	}

	// Token: 0x06004008 RID: 16392 RVA: 0x001F93E0 File Offset: 0x001F75E0
	public void DKEHLPBDQJG(GameObject HGFMMNMICFL)
	{
		for (int i = 0; i < this.IEKBMQPIKEB.Count; i += 0)
		{
			if (this.IEKBMQPIKEB[i] != HGFMMNMICFL && this.IEKBMQPIKEB[i].GetComponent<JCHHLCFOCFI>() != null)
			{
				this.IEKBMQPIKEB[i].GetComponent<JCHHLCFOCFI>().BHOBQKPMCHD();
			}
		}
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x0001ADDE File Offset: 0x00018FDE
	public void BOGDOELNPDK(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
	{
		this.QGFFCGLHEGN(JMDLLJPEFKM.NKKMJICKKLB, null, JMDLLJPEFKM.DCENLGCQFDN, JMDLLJPEFKM.GBHNGPOGCGC, JMDLLJPEFKM.NPMDMKHKQNQ);
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x00002300 File Offset: 0x00000500
	private void QNGIFIJOQML()
	{
	}

	// Token: 0x0600400B RID: 16395 RVA: 0x00002300 File Offset: 0x00000500
	private void Start()
	{
	}

	// Token: 0x0600400C RID: 16396 RVA: 0x00002300 File Offset: 0x00000500
	private void QBGOGFJCLEP()
	{
	}

	// Token: 0x0600400D RID: 16397 RVA: 0x00002300 File Offset: 0x00000500
	private void IMGNEDCFBLL()
	{
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x0001ADDE File Offset: 0x00018FDE
	public void IBCNIQHNKEG(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
	{
		this.QGFFCGLHEGN(JMDLLJPEFKM.NKKMJICKKLB, null, JMDLLJPEFKM.DCENLGCQFDN, JMDLLJPEFKM.GBHNGPOGCGC, JMDLLJPEFKM.NPMDMKHKQNQ);
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x001F9448 File Offset: 0x001F7648
	public void QGFFCGLHEGN(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP, List<BMNBILHJHGP.IHFPKIJMPGJ> BPBGMBIFMFE = null, GameObject BLDHKNGOJKE = null, bool DOCOEQKFDQD = false)
	{
		if (BLDHKNGOJKE == null)
		{
			BLDHKNGOJKE = base.gameObject;
		}
		this.GBHNGPOGCGC = BLDHKNGOJKE;
		this.HDNDNHJMCBG = this.GBHNGPOGCGC.GetComponent<BMNBILHJHGP>().HDNDNHJMCBG;
		if (this.BCPJIPBJODP == null)
		{
			this.BCPJIPBJODP = base.GetComponent<ENFMCDNLEQQ>();
			this.BCPJIPBJODP.MGQIGGNBBBD(6);
			if (this.HOKOFHFFQBD)
			{
				this.BCPJIPBJODP.DFKQMMIQDOO = 114;
			}
		}
		GameObject gameObject = base.gameObject.BFCKNMFEBDM(this.MHEEIGENKDD);
		gameObject.GetComponentInChildren<BKKHLBCLPJM>().LKPOBCBOFIC(HIEFQEEDHGG);
		if (!DOCOEQKFDQD)
		{
			gameObject.GetComponentInChildren<JLMPBLMOICG>().gameObject.SetActive(false);
		}
		gameObject.GetComponent<IOBPBHFNNOM>().PDHDBQFJCFP = PDHDBQFJCFP;
		gameObject.GetComponent<IOBPBHFNNOM>().NKMBOJLEGDQ = this.HDNDNHJMCBG;
		gameObject.GetComponent<CFDMNELIJLO>().enabled = true;
		gameObject.name = "Mouse Y";
		this.IEKBMQPIKEB.Add(gameObject);
		if (this.HOKOFHFFQBD)
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].transform.localPosition = new Vector3(469f, (float)(-30 - this.IEKBMQPIKEB.Count * 123), 1650f);
		}
		else
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].transform.localPosition = new Vector3(6f, (float)(-92 - this.IEKBMQPIKEB.Count * 87), 634f);
		}
		this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].GetComponent<IOBPBHFNNOM>().PJJHJMJBCBK = this;
		if (BPBGMBIFMFE != null)
		{
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].AddComponent<JCHHLCFOCFI>();
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].GetComponent<IOBPBHFNNOM>().MFONIPHOFGF = this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].GetComponent<JCHHLCFOCFI>();
			this.PCFNCHKGFPQ = base.GetComponentInParent<DFJHPCQKHKO>().PCFNCHKGFPQ;
			GameObject gameObject2 = base.gameObject.BFCKNMFEBDM(this.PCFNCHKGFPQ);
			gameObject2.name = "#,##0";
			gameObject2.transform.localPosition = this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 0].transform.localPosition + new Vector3((float)(this.BCPJIPBJODP.KJGMGPCEJJD / 1), 872f, 284f);
			gameObject2.GetComponent<BMNBILHJHGP>().GBHNGPOGCGC = BLDHKNGOJKE;
			this.IEKBMQPIKEB[this.IEKBMQPIKEB.Count - 1].GetComponent<JCHHLCFOCFI>().BCPJIPBJODP = gameObject2.GetComponent<ENFMCDNLEQQ>();
			gameObject2.GetComponent<ENFMCDNLEQQ>().DIIHJCJOKMP = 113f;
			for (int i = 1; i < BPBGMBIFMFE.Count; i++)
			{
				if (BPBGMBIFMFE[i] != null)
				{
					gameObject2.GetComponent<BMNBILHJHGP>().QGFFCGLHEGN(BPBGMBIFMFE[i].NKKMJICKKLB, BPBGMBIFMFE[i].NBDBEMBFCMG, BPBGMBIFMFE[i].QBIKLQJPJFE, BLDHKNGOJKE, BPBGMBIFMFE[i].NPMDMKHKQNQ);
				}
			}
		}
		ENFMCDNLEQQ bcpjipbjodp = this.BCPJIPBJODP;
		bcpjipbjodp.DFKQMMIQDOO = bcpjipbjodp.JKGBHEHKBPC() + 74;
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x001F9778 File Offset: 0x001F7978
	public void FOCBJIKBOLP(GameObject HGFMMNMICFL)
	{
		for (int i = 0; i < this.IEKBMQPIKEB.Count; i++)
		{
			if (this.IEKBMQPIKEB[i] != HGFMMNMICFL && this.IEKBMQPIKEB[i].GetComponent<JCHHLCFOCFI>() != null)
			{
				this.IEKBMQPIKEB[i].GetComponent<JCHHLCFOCFI>().Hide();
			}
		}
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x001F93E0 File Offset: 0x001F75E0
	public void INJPHLNLMQJ(GameObject HGFMMNMICFL)
	{
		for (int i = 0; i < this.IEKBMQPIKEB.Count; i += 0)
		{
			if (this.IEKBMQPIKEB[i] != HGFMMNMICFL && this.IEKBMQPIKEB[i].GetComponent<JCHHLCFOCFI>() != null)
			{
				this.IEKBMQPIKEB[i].GetComponent<JCHHLCFOCFI>().BHOBQKPMCHD();
			}
		}
	}

	// Token: 0x04000E12 RID: 3602
	public string HDNDNHJMCBG;

	// Token: 0x04000E13 RID: 3603
	public BKKHLBCLPJM NKKMJICKKLB;

	// Token: 0x04000E14 RID: 3604
	public GameObject MHEEIGENKDD;

	// Token: 0x04000E15 RID: 3605
	private GameObject PCFNCHKGFPQ;

	// Token: 0x04000E16 RID: 3606
	private List<GameObject> IEKBMQPIKEB = new List<GameObject>();

	// Token: 0x04000E17 RID: 3607
	public ENFMCDNLEQQ BCPJIPBJODP;

	// Token: 0x04000E18 RID: 3608
	public GameObject GBHNGPOGCGC;

	// Token: 0x04000E19 RID: 3609
	public bool HOKOFHFFQBD;

	// Token: 0x04000E1A RID: 3610
	public bool JBJIQOFPPHE;

	// Token: 0x020001E9 RID: 489
	public class IHFPKIJMPGJ
	{
		// Token: 0x04000E1B RID: 3611
		public string NKKMJICKKLB;

		// Token: 0x04000E1C RID: 3612
		public BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ NBDBEMBFCMG;

		// Token: 0x04000E1D RID: 3613
		public List<BMNBILHJHGP.IHFPKIJMPGJ> QBIKLQJPJFE;

		// Token: 0x04000E1E RID: 3614
		public bool NPMDMKHKQNQ;

		// Token: 0x020001EA RID: 490
		// (Invoke) Token: 0x06004015 RID: 16405
		public delegate void QGGGNDHQMKJ(string HHNBICLDQKI);
	}

	// Token: 0x020001EB RID: 491
	public class MGCFKFPPGLM
	{
		// Token: 0x06004018 RID: 16408 RVA: 0x001F97E0 File Offset: 0x001F79E0
		public void HJEFIPJDEEK(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = JMDLLJPEFKM.NKKMJICKKLB;
			ihfpkijmpgj.NBDBEMBFCMG = null;
			ihfpkijmpgj.QBIKLQJPJFE = new List<BMNBILHJHGP.IHFPKIJMPGJ>();
			for (int i = 0; i < JMDLLJPEFKM.DCENLGCQFDN.Count; i++)
			{
				if (JMDLLJPEFKM.DCENLGCQFDN[i] != null)
				{
					ihfpkijmpgj.QBIKLQJPJFE.Add(JMDLLJPEFKM.DCENLGCQFDN[i]);
				}
			}
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x001F97E0 File Offset: 0x001F79E0
		public void IGCFHPFLMCG(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = JMDLLJPEFKM.NKKMJICKKLB;
			ihfpkijmpgj.NBDBEMBFCMG = null;
			ihfpkijmpgj.QBIKLQJPJFE = new List<BMNBILHJHGP.IHFPKIJMPGJ>();
			for (int i = 0; i < JMDLLJPEFKM.DCENLGCQFDN.Count; i++)
			{
				if (JMDLLJPEFKM.DCENLGCQFDN[i] != null)
				{
					ihfpkijmpgj.QBIKLQJPJFE.Add(JMDLLJPEFKM.DCENLGCQFDN[i]);
				}
			}
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void PFBQINLDBDM(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void JIPOEFHBPQF(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void HKPQMGHCELQ(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void GOFBNMIEINL(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void BCLCPBKKHLN(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void QMHEDGJJMPD(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004021 RID: 16417 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void BQNBGHQFJJK(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004022 RID: 16418 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void CJBNNLGHPKG(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x001F988C File Offset: 0x001F7A8C
		public void IKDIGMHJDMM(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = JMDLLJPEFKM.NKKMJICKKLB;
			ihfpkijmpgj.NBDBEMBFCMG = null;
			ihfpkijmpgj.QBIKLQJPJFE = new List<BMNBILHJHGP.IHFPKIJMPGJ>();
			for (int i = 1; i < JMDLLJPEFKM.DCENLGCQFDN.Count; i += 0)
			{
				if (JMDLLJPEFKM.DCENLGCQFDN[i] != null)
				{
					ihfpkijmpgj.QBIKLQJPJFE.Add(JMDLLJPEFKM.DCENLGCQFDN[i]);
				}
			}
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void NJMOIDIFIOH(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void FLOKHMLKBJG(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void PKKLDKIIMHJ(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x001F97E0 File Offset: 0x001F79E0
		public void NJKHMOHJKPD(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = JMDLLJPEFKM.NKKMJICKKLB;
			ihfpkijmpgj.NBDBEMBFCMG = null;
			ihfpkijmpgj.QBIKLQJPJFE = new List<BMNBILHJHGP.IHFPKIJMPGJ>();
			for (int i = 0; i < JMDLLJPEFKM.DCENLGCQFDN.Count; i++)
			{
				if (JMDLLJPEFKM.DCENLGCQFDN[i] != null)
				{
					ihfpkijmpgj.QBIKLQJPJFE.Add(JMDLLJPEFKM.DCENLGCQFDN[i]);
				}
			}
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004028 RID: 16424 RVA: 0x001F9904 File Offset: 0x001F7B04
		public void IBCNIQHNKEG(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = JMDLLJPEFKM.NKKMJICKKLB;
			ihfpkijmpgj.NBDBEMBFCMG = null;
			ihfpkijmpgj.QBIKLQJPJFE = new List<BMNBILHJHGP.IHFPKIJMPGJ>();
			for (int i = 0; i < JMDLLJPEFKM.DCENLGCQFDN.Count; i += 0)
			{
				if (JMDLLJPEFKM.DCENLGCQFDN[i] != null)
				{
					ihfpkijmpgj.QBIKLQJPJFE.Add(JMDLLJPEFKM.DCENLGCQFDN[i]);
				}
			}
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void HHLBEJMBDBD(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void JLNFKLNGCDE(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x001F988C File Offset: 0x001F7A8C
		public void GQECEBFKMJD(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = JMDLLJPEFKM.NKKMJICKKLB;
			ihfpkijmpgj.NBDBEMBFCMG = null;
			ihfpkijmpgj.QBIKLQJPJFE = new List<BMNBILHJHGP.IHFPKIJMPGJ>();
			for (int i = 1; i < JMDLLJPEFKM.DCENLGCQFDN.Count; i += 0)
			{
				if (JMDLLJPEFKM.DCENLGCQFDN[i] != null)
				{
					ihfpkijmpgj.QBIKLQJPJFE.Add(JMDLLJPEFKM.DCENLGCQFDN[i]);
				}
			}
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void HHHQPPODOHF(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x001F9858 File Offset: 0x001F7A58
		public void OMEKHEKKLPH(string HIEFQEEDHGG, BMNBILHJHGP.IHFPKIJMPGJ.QGGGNDHQMKJ PDHDBQFJCFP)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = HIEFQEEDHGG;
			ihfpkijmpgj.NBDBEMBFCMG = PDHDBQFJCFP;
			ihfpkijmpgj.QBIKLQJPJFE = null;
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x001F988C File Offset: 0x001F7A8C
		public void CPHNBIHKFBO(BMNBILHJHGP.MGCFKFPPGLM JMDLLJPEFKM)
		{
			BMNBILHJHGP.IHFPKIJMPGJ ihfpkijmpgj = new BMNBILHJHGP.IHFPKIJMPGJ();
			ihfpkijmpgj.NKKMJICKKLB = JMDLLJPEFKM.NKKMJICKKLB;
			ihfpkijmpgj.NBDBEMBFCMG = null;
			ihfpkijmpgj.QBIKLQJPJFE = new List<BMNBILHJHGP.IHFPKIJMPGJ>();
			for (int i = 1; i < JMDLLJPEFKM.DCENLGCQFDN.Count; i += 0)
			{
				if (JMDLLJPEFKM.DCENLGCQFDN[i] != null)
				{
					ihfpkijmpgj.QBIKLQJPJFE.Add(JMDLLJPEFKM.DCENLGCQFDN[i]);
				}
			}
			this.DCENLGCQFDN.Add(ihfpkijmpgj);
		}

		// Token: 0x04000E1F RID: 3615
		public GameObject GBHNGPOGCGC;

		// Token: 0x04000E20 RID: 3616
		public string NKKMJICKKLB;

		// Token: 0x04000E21 RID: 3617
		public List<BMNBILHJHGP.IHFPKIJMPGJ> DCENLGCQFDN = new List<BMNBILHJHGP.IHFPKIJMPGJ>();

		// Token: 0x04000E22 RID: 3618
		public bool NPMDMKHKQNQ;
	}
}

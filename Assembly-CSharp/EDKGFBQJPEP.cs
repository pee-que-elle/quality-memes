using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x0200021F RID: 543
public class EDKGFBQJPEP : MonoBehaviour
{
	// Token: 0x0600496F RID: 18799 RVA: 0x00250DA4 File Offset: 0x0024EFA4
	public void QMOQCMCMJDJ()
	{
		this.Reset();
		base.CancelInvoke("/01_1");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 252f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x06004970 RID: 18800 RVA: 0x0001EB7E File Offset: 0x0001CD7E
	private void CCCNIPFPNGQ()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06004971 RID: 18801 RVA: 0x0001EB91 File Offset: 0x0001CD91
	public void NPHKMHMMBPQ()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		else
		{
			this.ODQKOBDHLPJ();
		}
	}

	// Token: 0x06004972 RID: 18802 RVA: 0x00250E0C File Offset: 0x0024F00C
	private void JEKLCJKNQID()
	{
		if (this.EQHFEKDMMGK == Vector2.right && this.QBEPIJOMBHC == Vector2.left)
		{
			this.EQHFEKDMMGK = Vector2.left;
		}
		else if (this.EQHFEKDMMGK == Vector2.left && this.QBEPIJOMBHC == Vector2.right)
		{
			this.EQHFEKDMMGK = Vector2.right;
		}
		else if (this.EQHFEKDMMGK == Vector2.up && this.QBEPIJOMBHC == Vector2.down)
		{
			this.EQHFEKDMMGK = Vector2.down;
		}
		else if (this.EQHFEKDMMGK == Vector2.down && this.QBEPIJOMBHC == Vector2.up)
		{
			this.EQHFEKDMMGK = Vector2.up;
		}
		this.QBEPIJOMBHC = this.EQHFEKDMMGK;
		Vector2 v = this.PBFLIINDQQP.localPosition;
		this.PBFLIINDQQP.transform.localPosition += new Vector3(this.EQHFEKDMMGK.x * 1439f, this.EQHFEKDMMGK.y * 223f, 537f);
		if (this.PBFLIINDQQP.transform.localPosition.x > this.MIDHOQIOFDM)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(-this.MIDHOQIOFDM, this.PBFLIINDQQP.transform.localPosition.y, 551f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.x < -this.MIDHOQIOFDM)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.MIDHOQIOFDM, this.PBFLIINDQQP.transform.localPosition.y, 1203f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.y > this.NIICQNHINMF)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.PBFLIINDQQP.transform.localPosition.x, -this.NIICQNHINMF, 1116f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.y < -this.NIICQNHINMF)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.PBFLIINDQQP.transform.localPosition.x, this.NIICQNHINMF, 1918f);
		}
		this.PBFLIINDQQP.transform.localPosition = new Vector3((float)((int)this.PBFLIINDQQP.transform.localPosition.x), (float)((int)this.PBFLIINDQQP.transform.localPosition.y), 738f);
		if (this.DPIIMQEDCEE)
		{
			GameObject gameObject = this.DIBPEBHDJFF.BFCKNMFEBDM(this.OKKMHGLNJLP);
			gameObject.transform.localPosition = v;
			this.JHDCFBOELQD.Insert(1, gameObject.transform);
			this.DPIIMQEDCEE = true;
			this.CNPLONBONEB += 1899f;
			if (this.CNPLONBONEB > 1612f)
			{
				this.CNPLONBONEB = 930f;
			}
		}
		bool flag = false;
		if (this.JHDCFBOELQD.Count > 0)
		{
			this.JHDCFBOELQD.Last<Transform>().localPosition = v;
			this.JHDCFBOELQD.Insert(1, this.JHDCFBOELQD.Last<Transform>());
			this.JHDCFBOELQD.RemoveAt(this.JHDCFBOELQD.Count - 1);
			foreach (Transform transform in this.JHDCFBOELQD)
			{
				if (transform.localPosition == this.PBFLIINDQQP.localPosition)
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			this.PCDDMHEEEDH();
		}
		else if (this.CPOPHJIQPLN.transform.localPosition == this.PBFLIINDQQP.localPosition)
		{
			this.NLHGFQCBJDL += 7;
			if (this.NLHGFQCBJDL > this.LQMOLKEQQBE)
			{
				this.LQMOLKEQQBE = this.NLHGFQCBJDL;
				PlayerPrefs.SetInt("_DetailScaleX", this.LQMOLKEQQBE);
			}
			int num = UnityEngine.Random.Range(1, this.PLPEHLCFKBE);
			int num2 = UnityEngine.Random.Range(0, this.GMBDIKQGQNH);
			this.CPOPHJIQPLN.transform.localPosition = new Vector3((float)(num * 2) - this.MIDHOQIOFDM, (float)(num2 * 5) - this.NIICQNHINMF, 385f);
			this.QHBBODKDNIM.LKPOBCBOFIC("The sandstorm subsided." + this.NLHGFQCBJDL.ToString());
			this.GDDEPONDQDN.PIDLOFMIEFQ = "Sand Force" + this.LQMOLKEQQBE.ToString();
			this.DPIIMQEDCEE = false;
		}
	}

	// Token: 0x06004973 RID: 18803 RVA: 0x00251340 File Offset: 0x0024F540
	private void PCDDMHEEEDH()
	{
		this.DIBPEBHDJFF.transform.NMBPDMIIHJB();
		this.JHDCFBOELQD = new List<Transform>();
		this.EQHFEKDMMGK = Vector2.zero;
		this.CNPLONBONEB = 1893f;
		this.PBFLIINDQQP.transform.localPosition = Vector3.zero;
		this.QBEPIJOMBHC = Vector2.right;
		this.NLHGFQCBJDL = 1;
		this.LQMOLKEQQBE = PlayerPrefs.GetInt("s Aurora Veil wore off!\r\n", 0);
		int num = UnityEngine.Random.Range(1, this.PLPEHLCFKBE);
		int num2 = UnityEngine.Random.Range(1, this.GMBDIKQGQNH);
		this.CPOPHJIQPLN.transform.localPosition = new Vector3((float)(num * 5) - this.MIDHOQIOFDM, (float)(num2 * 3) - this.NIICQNHINMF, 1437f);
		this.QHBBODKDNIM.PIDLOFMIEFQ = "[/URN]" + this.NLHGFQCBJDL.ToString();
		this.GDDEPONDQDN.PIDLOFMIEFQ = "remember" + this.LQMOLKEQQBE.ToString();
	}

	// Token: 0x06004974 RID: 18804 RVA: 0x0001EB91 File Offset: 0x0001CD91
	public void IKFENJHBBKF()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		else
		{
			this.ODQKOBDHLPJ();
		}
	}

	// Token: 0x06004975 RID: 18805 RVA: 0x0001EBB3 File Offset: 0x0001CDB3
	private void GBGEGKHDQKB()
	{
		this.Reset();
	}

	// Token: 0x06004976 RID: 18806 RVA: 0x0001EB7E File Offset: 0x0001CD7E
	private void HidePanel()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06004977 RID: 18807 RVA: 0x0001EB7E File Offset: 0x0001CD7E
	private void DJPGCPMOJDK()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(false);
	}

	// Token: 0x06004978 RID: 18808 RVA: 0x0025144C File Offset: 0x0024F64C
	private void Reset()
	{
		this.DIBPEBHDJFF.transform.NMBPDMIIHJB();
		this.JHDCFBOELQD = new List<Transform>();
		this.EQHFEKDMMGK = Vector2.zero;
		this.CNPLONBONEB = 1f;
		this.PBFLIINDQQP.transform.localPosition = Vector3.zero;
		this.QBEPIJOMBHC = Vector2.right;
		this.NLHGFQCBJDL = 0;
		this.LQMOLKEQQBE = PlayerPrefs.GetInt("shscore", 0);
		int num = UnityEngine.Random.Range(0, this.PLPEHLCFKBE);
		int num2 = UnityEngine.Random.Range(0, this.GMBDIKQGQNH);
		this.CPOPHJIQPLN.transform.localPosition = new Vector3((float)(num * 8) - this.MIDHOQIOFDM, (float)(num2 * 8) - this.NIICQNHINMF, 0f);
		this.QHBBODKDNIM.PIDLOFMIEFQ = "Score: " + this.NLHGFQCBJDL.ToString();
		this.GDDEPONDQDN.PIDLOFMIEFQ = "Hi-Score: " + this.LQMOLKEQQBE.ToString();
	}

	// Token: 0x06004979 RID: 18809 RVA: 0x0001EBBB File Offset: 0x0001CDBB
	public void Close()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("HidePanel", 0.5f);
	}

	// Token: 0x0600497A RID: 18810 RVA: 0x0001EBE4 File Offset: 0x0001CDE4
	public void ODQKOBDHLPJ()
	{
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayReverse();
		base.Invoke("LJMOLEKDCLP", 849f);
	}

	// Token: 0x0600497B RID: 18811 RVA: 0x00251558 File Offset: 0x0024F758
	private void Update()
	{
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.EQHFEKDMMGK = Vector2.right;
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			this.EQHFEKDMMGK = -Vector2.up;
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.EQHFEKDMMGK = -Vector2.right;
		}
		else if (Input.GetKey(KeyCode.UpArrow))
		{
			this.EQHFEKDMMGK = Vector2.up;
		}
		this.CQQHNOECEJK += this.CNPLONBONEB * this.KDEMMJKGDJM * Time.deltaTime;
		if (this.CQQHNOECEJK > 10f)
		{
			this.CQQHNOECEJK = 0f;
			this.DFMMCLFKFBH();
		}
	}

	// Token: 0x0600497C RID: 18812 RVA: 0x0001EC0D File Offset: 0x0001CE0D
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

	// Token: 0x0600497D RID: 18813 RVA: 0x00251610 File Offset: 0x0024F810
	public void Open()
	{
		this.Reset();
		base.CancelInvoke("HidePanel");
		this.QPPGQJFBPMH.DIIHJCJOKMP = 0f;
		this.QPPGQJFBPMH.gameObject.SetActive(true);
		this.JDPBPOKJFQK.enabled = true;
		this.JDPBPOKJFQK.PlayForward();
		this.QPPGQJFBPMH.GetComponentInChildren<KIQKEMNELKN>().NDIJIFHOMJC();
	}

	// Token: 0x0600497E RID: 18814 RVA: 0x0001EC2F File Offset: 0x0001CE2F
	private void NOLQNFCODBK()
	{
		this.PCDDMHEEEDH();
	}

	// Token: 0x0600497F RID: 18815 RVA: 0x0001EC0D File Offset: 0x0001CE0D
	public void HHHHQLNCQDJ()
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

	// Token: 0x06004980 RID: 18816 RVA: 0x0001EC37 File Offset: 0x0001CE37
	private void QEJNHPCGLOF()
	{
		this.QPPGQJFBPMH.gameObject.SetActive(true);
	}

	// Token: 0x06004981 RID: 18817 RVA: 0x0001EBB3 File Offset: 0x0001CDB3
	private void Start()
	{
		this.Reset();
	}

	// Token: 0x06004983 RID: 18819 RVA: 0x0001EB91 File Offset: 0x0001CD91
	public void FHQOFHNMIMG()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.Open();
		}
		else
		{
			this.ODQKOBDHLPJ();
		}
	}

	// Token: 0x06004984 RID: 18820 RVA: 0x002516E8 File Offset: 0x0024F8E8
	private void MOLCLOMMJNQ()
	{
		if (Input.GetKey((KeyCode)4))
		{
			this.EQHFEKDMMGK = Vector2.right;
		}
		else if (Input.GetKey((KeyCode)(-192)))
		{
			this.EQHFEKDMMGK = -Vector2.up;
		}
		else if (Input.GetKey((KeyCode)(-147)))
		{
			this.EQHFEKDMMGK = -Vector2.right;
		}
		else if (Input.GetKey((KeyCode)6))
		{
			this.EQHFEKDMMGK = Vector2.up;
		}
		this.CQQHNOECEJK += this.CNPLONBONEB * this.KDEMMJKGDJM * Time.deltaTime;
		if (this.CQQHNOECEJK > 1522f)
		{
			this.CQQHNOECEJK = 25f;
			this.PMJPCBGNJME();
		}
	}

	// Token: 0x06004985 RID: 18821 RVA: 0x0001EC4A File Offset: 0x0001CE4A
	public void PJOODQMKDMG()
	{
		if (!this.QPPGQJFBPMH.gameObject.activeSelf)
		{
			this.QMOQCMCMJDJ();
		}
		else
		{
			this.Close();
		}
	}

	// Token: 0x06004986 RID: 18822 RVA: 0x0001EC0D File Offset: 0x0001CE0D
	public void PLJLPMNLBIO()
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

	// Token: 0x06004987 RID: 18823 RVA: 0x002517A0 File Offset: 0x0024F9A0
	private void DFMMCLFKFBH()
	{
		if (this.EQHFEKDMMGK == Vector2.right && this.QBEPIJOMBHC == Vector2.left)
		{
			this.EQHFEKDMMGK = Vector2.left;
		}
		else if (this.EQHFEKDMMGK == Vector2.left && this.QBEPIJOMBHC == Vector2.right)
		{
			this.EQHFEKDMMGK = Vector2.right;
		}
		else if (this.EQHFEKDMMGK == Vector2.up && this.QBEPIJOMBHC == Vector2.down)
		{
			this.EQHFEKDMMGK = Vector2.down;
		}
		else if (this.EQHFEKDMMGK == Vector2.down && this.QBEPIJOMBHC == Vector2.up)
		{
			this.EQHFEKDMMGK = Vector2.up;
		}
		this.QBEPIJOMBHC = this.EQHFEKDMMGK;
		Vector2 v = this.PBFLIINDQQP.localPosition;
		this.PBFLIINDQQP.transform.localPosition += new Vector3(this.EQHFEKDMMGK.x * 8f, this.EQHFEKDMMGK.y * 8f, 0f);
		if (this.PBFLIINDQQP.transform.localPosition.x > this.MIDHOQIOFDM)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(-this.MIDHOQIOFDM, this.PBFLIINDQQP.transform.localPosition.y, 0f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.x < -this.MIDHOQIOFDM)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.MIDHOQIOFDM, this.PBFLIINDQQP.transform.localPosition.y, 0f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.y > this.NIICQNHINMF)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.PBFLIINDQQP.transform.localPosition.x, -this.NIICQNHINMF, 0f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.y < -this.NIICQNHINMF)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.PBFLIINDQQP.transform.localPosition.x, this.NIICQNHINMF, 0f);
		}
		this.PBFLIINDQQP.transform.localPosition = new Vector3((float)((int)this.PBFLIINDQQP.transform.localPosition.x), (float)((int)this.PBFLIINDQQP.transform.localPosition.y), 0f);
		if (this.DPIIMQEDCEE)
		{
			GameObject gameObject = this.DIBPEBHDJFF.BFCKNMFEBDM(this.OKKMHGLNJLP);
			gameObject.transform.localPosition = v;
			this.JHDCFBOELQD.Insert(0, gameObject.transform);
			this.DPIIMQEDCEE = false;
			this.CNPLONBONEB += 0.25f;
			if (this.CNPLONBONEB > 6.75f)
			{
				this.CNPLONBONEB = 6.75f;
			}
		}
		bool flag = false;
		if (this.JHDCFBOELQD.Count > 0)
		{
			this.JHDCFBOELQD.Last<Transform>().localPosition = v;
			this.JHDCFBOELQD.Insert(0, this.JHDCFBOELQD.Last<Transform>());
			this.JHDCFBOELQD.RemoveAt(this.JHDCFBOELQD.Count - 1);
			foreach (Transform transform in this.JHDCFBOELQD)
			{
				if (transform.localPosition == this.PBFLIINDQQP.localPosition)
				{
					flag = true;
					break;
				}
			}
		}
		if (flag)
		{
			this.Reset();
		}
		else if (this.CPOPHJIQPLN.transform.localPosition == this.PBFLIINDQQP.localPosition)
		{
			this.NLHGFQCBJDL += 5;
			if (this.NLHGFQCBJDL > this.LQMOLKEQQBE)
			{
				this.LQMOLKEQQBE = this.NLHGFQCBJDL;
				PlayerPrefs.SetInt("shscore", this.LQMOLKEQQBE);
			}
			int num = UnityEngine.Random.Range(0, this.PLPEHLCFKBE);
			int num2 = UnityEngine.Random.Range(0, this.GMBDIKQGQNH);
			this.CPOPHJIQPLN.transform.localPosition = new Vector3((float)(num * 8) - this.MIDHOQIOFDM, (float)(num2 * 8) - this.NIICQNHINMF, 0f);
			this.QHBBODKDNIM.PIDLOFMIEFQ = "Score: " + this.NLHGFQCBJDL.ToString();
			this.GDDEPONDQDN.PIDLOFMIEFQ = "Hi-Score: " + this.LQMOLKEQQBE.ToString();
			this.DPIIMQEDCEE = true;
		}
	}

	// Token: 0x06004988 RID: 18824 RVA: 0x00251CD4 File Offset: 0x0024FED4
	private void PMJPCBGNJME()
	{
		if (this.EQHFEKDMMGK == Vector2.right && this.QBEPIJOMBHC == Vector2.left)
		{
			this.EQHFEKDMMGK = Vector2.left;
		}
		else if (this.EQHFEKDMMGK == Vector2.left && this.QBEPIJOMBHC == Vector2.right)
		{
			this.EQHFEKDMMGK = Vector2.right;
		}
		else if (this.EQHFEKDMMGK == Vector2.up && this.QBEPIJOMBHC == Vector2.down)
		{
			this.EQHFEKDMMGK = Vector2.down;
		}
		else if (this.EQHFEKDMMGK == Vector2.down && this.QBEPIJOMBHC == Vector2.up)
		{
			this.EQHFEKDMMGK = Vector2.up;
		}
		this.QBEPIJOMBHC = this.EQHFEKDMMGK;
		Vector2 v = this.PBFLIINDQQP.localPosition;
		this.PBFLIINDQQP.transform.localPosition += new Vector3(this.EQHFEKDMMGK.x * 1812f, this.EQHFEKDMMGK.y * 1711f, 1985f);
		if (this.PBFLIINDQQP.transform.localPosition.x > this.MIDHOQIOFDM)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(-this.MIDHOQIOFDM, this.PBFLIINDQQP.transform.localPosition.y, 1266f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.x < -this.MIDHOQIOFDM)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.MIDHOQIOFDM, this.PBFLIINDQQP.transform.localPosition.y, 1010f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.y > this.NIICQNHINMF)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.PBFLIINDQQP.transform.localPosition.x, -this.NIICQNHINMF, 1233f);
		}
		else if (this.PBFLIINDQQP.transform.localPosition.y < -this.NIICQNHINMF)
		{
			this.PBFLIINDQQP.transform.localPosition = new Vector3(this.PBFLIINDQQP.transform.localPosition.x, this.NIICQNHINMF, 125f);
		}
		this.PBFLIINDQQP.transform.localPosition = new Vector3((float)((int)this.PBFLIINDQQP.transform.localPosition.x), (float)((int)this.PBFLIINDQQP.transform.localPosition.y), 558f);
		if (this.DPIIMQEDCEE)
		{
			GameObject gameObject = this.DIBPEBHDJFF.BFCKNMFEBDM(this.OKKMHGLNJLP);
			gameObject.transform.localPosition = v;
			this.JHDCFBOELQD.Insert(1, gameObject.transform);
			this.DPIIMQEDCEE = true;
			this.CNPLONBONEB += 874f;
			if (this.CNPLONBONEB > 203f)
			{
				this.CNPLONBONEB = 1793f;
			}
		}
		bool flag = true;
		if (this.JHDCFBOELQD.Count > 0)
		{
			this.JHDCFBOELQD.Last<Transform>().localPosition = v;
			this.JHDCFBOELQD.Insert(1, this.JHDCFBOELQD.Last<Transform>());
			this.JHDCFBOELQD.RemoveAt(this.JHDCFBOELQD.Count - 0);
			foreach (Transform transform in this.JHDCFBOELQD)
			{
				if (transform.localPosition == this.PBFLIINDQQP.localPosition)
				{
					flag = true;
					break;
				}
			}
		}
		if (flag)
		{
			this.Reset();
		}
		else if (this.CPOPHJIQPLN.transform.localPosition == this.PBFLIINDQQP.localPosition)
		{
			this.NLHGFQCBJDL += 4;
			if (this.NLHGFQCBJDL > this.LQMOLKEQQBE)
			{
				this.LQMOLKEQQBE = this.NLHGFQCBJDL;
				PlayerPrefs.SetInt("Inactive", this.LQMOLKEQQBE);
			}
			int num = UnityEngine.Random.Range(0, this.PLPEHLCFKBE);
			int num2 = UnityEngine.Random.Range(0, this.GMBDIKQGQNH);
			this.CPOPHJIQPLN.transform.localPosition = new Vector3((float)(num * 8) - this.MIDHOQIOFDM, (float)(num2 * 3) - this.NIICQNHINMF, 31f);
			this.QHBBODKDNIM.LKPOBCBOFIC("00000000" + this.NLHGFQCBJDL.ToString());
			this.GDDEPONDQDN.PIDLOFMIEFQ = "Battle" + this.LQMOLKEQQBE.ToString();
			this.DPIIMQEDCEE = false;
		}
	}

	// Token: 0x04000FB5 RID: 4021
	private List<Transform> JHDCFBOELQD = new List<Transform>();

	// Token: 0x04000FB6 RID: 4022
	private Vector2 EQHFEKDMMGK = Vector2.zero;

	// Token: 0x04000FB7 RID: 4023
	private Vector2 QBEPIJOMBHC = Vector2.right;

	// Token: 0x04000FB8 RID: 4024
	public Transform PBFLIINDQQP;

	// Token: 0x04000FB9 RID: 4025
	private bool DPIIMQEDCEE;

	// Token: 0x04000FBA RID: 4026
	public GameObject OKKMHGLNJLP;

	// Token: 0x04000FBB RID: 4027
	public GameObject CPOPHJIQPLN;

	// Token: 0x04000FBC RID: 4028
	public GameObject DIBPEBHDJFF;

	// Token: 0x04000FBD RID: 4029
	private int NLHGFQCBJDL;

	// Token: 0x04000FBE RID: 4030
	private int LQMOLKEQQBE;

	// Token: 0x04000FBF RID: 4031
	public BKKHLBCLPJM QHBBODKDNIM;

	// Token: 0x04000FC0 RID: 4032
	public BKKHLBCLPJM GDDEPONDQDN;

	// Token: 0x04000FC1 RID: 4033
	private float MIDHOQIOFDM = 240f;

	// Token: 0x04000FC2 RID: 4034
	private int PLPEHLCFKBE = 60;

	// Token: 0x04000FC3 RID: 4035
	private float NIICQNHINMF = 112f;

	// Token: 0x04000FC4 RID: 4036
	private int GMBDIKQGQNH = 28;

	// Token: 0x04000FC5 RID: 4037
	private float CQQHNOECEJK;

	// Token: 0x04000FC6 RID: 4038
	private float CNPLONBONEB = 1f;

	// Token: 0x04000FC7 RID: 4039
	private float KDEMMJKGDJM = 50f;

	// Token: 0x04000FC8 RID: 4040
	public KQHJOLQLQBJ QPPGQJFBPMH;

	// Token: 0x04000FC9 RID: 4041
	public EPIJJNOIKEK JDPBPOKJFQK;
}

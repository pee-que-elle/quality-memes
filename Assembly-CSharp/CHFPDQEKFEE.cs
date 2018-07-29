using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000296 RID: 662
public class CHFPDQEKFEE : MonoBehaviour
{
	// Token: 0x06005C58 RID: 23640 RVA: 0x002F6630 File Offset: 0x002F4830
	private void MJPQJHEEPMD()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.HKGFNLMJOJM = eulerAngles.y;
		this.CQLNCICHEQG = eulerAngles.x;
		this.QIGFKEKPKIM = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
	}

	// Token: 0x06005C59 RID: 23641 RVA: 0x00002300 File Offset: 0x00000500
	private void HHIBFNMNEBJ()
	{
	}

	// Token: 0x06005C5A RID: 23642 RVA: 0x002F6674 File Offset: 0x002F4874
	private IEnumerator QQJEILCGELC(string KEQMEGEHFIK)
	{
		CHFPDQEKFEE.OBICHFPKIBK obichfpkibk = new CHFPDQEKFEE.OBICHFPKIBK();
		obichfpkibk.KEQMEGEHFIK = KEQMEGEHFIK;
		obichfpkibk.QNDQJMNKFNN = this;
		return obichfpkibk;
	}

	// Token: 0x06005C5B RID: 23643 RVA: 0x00024403 File Offset: 0x00022603
	public void HIFOEDLHLDO(string BGBMIEJJQKC)
	{
		this.MKDMNPCBDHL = BGBMIEJJQKC;
		if (this.MCIKNBGQGEB != null)
		{
			base.StopCoroutine(this.MCIKNBGQGEB);
		}
		this.MCIKNBGQGEB = base.StartCoroutine(this.QQJEILCGELC(this.MKDMNPCBDHL));
	}

	// Token: 0x06005C5C RID: 23644 RVA: 0x00024438 File Offset: 0x00022638
	public string QEQFFEDKJGI()
	{
		return this.MKDMNPCBDHL;
	}

	// Token: 0x06005C5D RID: 23645 RVA: 0x00024440 File Offset: 0x00022640
	public static CHFPDQEKFEE CFGIOIGOIFQ()
	{
		return CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06005C5E RID: 23646 RVA: 0x00024447 File Offset: 0x00022647
	public static float MONKDECPPEK(float MPNNMHJBOPN, float LCELGLKMPFN, float MJGGCLOGKFL)
	{
		if (MPNNMHJBOPN < 1556f)
		{
			MPNNMHJBOPN += 1018f;
		}
		if (MPNNMHJBOPN > 625f)
		{
			MPNNMHJBOPN -= 514f;
		}
		return Mathf.Clamp(MPNNMHJBOPN, LCELGLKMPFN, MJGGCLOGKFL);
	}

	// Token: 0x06005C5F RID: 23647 RVA: 0x002F6698 File Offset: 0x002F4898
	private Vector3 FDOLIPJPICD(Vector3 ILJPENJCKOB, Vector3 QODMGICELOG, float OQJFBJQJEFG)
	{
		float x = Mathf.LerpAngle(ILJPENJCKOB.x, QODMGICELOG.x, OQJFBJQJEFG);
		float y = Mathf.LerpAngle(ILJPENJCKOB.y, QODMGICELOG.y, OQJFBJQJEFG);
		float z = Mathf.LerpAngle(ILJPENJCKOB.z, QODMGICELOG.z, OQJFBJQJEFG);
		Vector3 result = new Vector3(x, y, z);
		return result;
	}

	// Token: 0x06005C60 RID: 23648 RVA: 0x00024473 File Offset: 0x00022673
	private void OFLEOHNLPCB()
	{
		base.StartCoroutine(this.ENGQNHDIOOL());
	}

	// Token: 0x06005C61 RID: 23649 RVA: 0x00024482 File Offset: 0x00022682
	private void Awake()
	{
		CHFPDQEKFEE.QOQONHOOLNE = this;
	}

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x06005C6F RID: 23663 RVA: 0x00024440 File Offset: 0x00022640
	// (set) Token: 0x06005C62 RID: 23650 RVA: 0x0002448A File Offset: 0x0002268A
	public static CHFPDQEKFEE QOQONHOOLNE { get; private set; }

	// Token: 0x06005C63 RID: 23651 RVA: 0x002F66F0 File Offset: 0x002F48F0
	private IEnumerator NEJCCCDHKEB()
	{
		if (this.DJQDMBNLQDI != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
		}
		AssetBundleRequest assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(DNFENPQLICQ.QOQONHOOLNE.MCPQEOLLKNH) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		UnityEngine.Object asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, this.ILBCCCBJNCL.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		SkinnedMeshRenderer[] componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_15C;
		IL_12A:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_15C:
		if (num < componentsInChildren.Length)
		{
			goto IL_12A;
		}
		yield break;
	}

	// Token: 0x06005C64 RID: 23652 RVA: 0x00024492 File Offset: 0x00022692
	private void HBJBLMLMEBD()
	{
		base.StartCoroutine(this.DHOJGCMFLMO());
	}

	// Token: 0x06005C65 RID: 23653 RVA: 0x00024440 File Offset: 0x00022640
	public static CHFPDQEKFEE IECKOKEPENM()
	{
		return CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06005C66 RID: 23654 RVA: 0x002F670C File Offset: 0x002F490C
	private void OPLBLLCBIBJ()
	{
		if (!Input.GetKey(KeyCode.Semicolon) && !Input.GetKey((KeyCode)(-130)))
		{
			this.QIGFKEKPKIM.velocity = Vector3.Lerp(this.QIGFKEKPKIM.velocity, Vector3.zero, Time.fixedDeltaTime * this.LLPEMNIPJBO);
			this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, Quaternion.Euler(1514f, this.ILBCCCBJNCL.eulerAngles.y, this.ILBCCCBJNCL.eulerAngles.z), Time.fixedDeltaTime * 1436f);
			if (!CNCJKLNHQBH.BJLGEDCPENQ().GJECFKPGQQF)
			{
				bool flag = true;
				if (!Input.GetKey((KeyCode)(-87)) && !Input.GetKey((KeyCode)(-199)))
				{
					if (Input.GetKey((KeyCode)65) || Input.GetKey((KeyCode)198))
					{
						flag = true;
						this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.right * 7f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.right * 1291f;
					flag = true;
				}
				if (Input.GetKey((KeyCode)(-38)) || Input.GetKey((KeyCode)154))
				{
					if (flag)
					{
						this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.forward * 248f;
					}
					else
					{
						this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.forward * 1481f;
					}
				}
				if (Input.GetKey((KeyCode)7))
				{
					this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 1545f;
				}
				else if (Input.GetKey((KeyCode)5))
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 990f;
				}
				if (Input.GetKey((KeyCode)(-44)) || Input.GetKey((KeyCode)7))
				{
					this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 603f);
				}
			}
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
		{
			if (Input.GetMouseButton(1) && CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME != Vector2.zero)
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 727f);
			}
			else if (Input.GetKey((KeyCode)(-100)) || Input.GetKey(KeyCode.Hash))
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1448f);
			}
			this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.forward * 841f;
			if (!Input.GetMouseButton(1))
			{
				if (!Input.GetKey((KeyCode)(-2)) && !Input.GetKey((KeyCode)10))
				{
					if (Input.GetKey((KeyCode)(-18)) || Input.GetKey((KeyCode)(-159)))
					{
						this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.right * 1721f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.right * 1235f;
				}
			}
			if (Input.GetKey((KeyCode)(-80)))
			{
				this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 776f;
			}
			else if (Input.GetKey((KeyCode)196))
			{
				this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 1564f;
			}
		}
	}

	// Token: 0x06005C67 RID: 23655 RVA: 0x00024473 File Offset: 0x00022673
	private void NEBJBQOMHDI()
	{
		base.StartCoroutine(this.ENGQNHDIOOL());
	}

	// Token: 0x06005C68 RID: 23656 RVA: 0x00024473 File Offset: 0x00022673
	private void INFMNHJJDCD()
	{
		base.StartCoroutine(this.ENGQNHDIOOL());
	}

	// Token: 0x06005C69 RID: 23657 RVA: 0x0002448A File Offset: 0x0002268A
	private static void HPMHCELHODL(CHFPDQEKFEE BGBMIEJJQKC)
	{
		CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06005C6A RID: 23658 RVA: 0x002F6674 File Offset: 0x002F4874
	private IEnumerator QPPHFLCLGFQ(string KEQMEGEHFIK)
	{
		CHFPDQEKFEE.OBICHFPKIBK obichfpkibk = new CHFPDQEKFEE.OBICHFPKIBK();
		obichfpkibk.KEQMEGEHFIK = KEQMEGEHFIK;
		obichfpkibk.QNDQJMNKFNN = this;
		return obichfpkibk;
	}

	// Token: 0x06005C6B RID: 23659 RVA: 0x002F66F0 File Offset: 0x002F48F0
	private IEnumerator DHOJGCMFLMO()
	{
		if (this.DJQDMBNLQDI != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
		}
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(DNFENPQLICQ.QOQONHOOLNE.MCPQEOLLKNH) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, this.ILBCCCBJNCL.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		num = 0;
		goto IL_15C;
		IL_12A:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_15C:
		if (num < componentsInChildren.Length)
		{
			goto IL_12A;
		}
		yield break;
	}

	// Token: 0x06005C6C RID: 23660 RVA: 0x000244A1 File Offset: 0x000226A1
	public static float IIJDCJIPHMF(float MPNNMHJBOPN, float LCELGLKMPFN, float MJGGCLOGKFL)
	{
		if (MPNNMHJBOPN < -360f)
		{
			MPNNMHJBOPN += 360f;
		}
		if (MPNNMHJBOPN > 360f)
		{
			MPNNMHJBOPN -= 360f;
		}
		return Mathf.Clamp(MPNNMHJBOPN, LCELGLKMPFN, MJGGCLOGKFL);
	}

	// Token: 0x06005C6D RID: 23661 RVA: 0x00024438 File Offset: 0x00022638
	public string IKKMOCQMQQL()
	{
		return this.MKDMNPCBDHL;
	}

	// Token: 0x06005C6E RID: 23662 RVA: 0x002F66F0 File Offset: 0x002F48F0
	private IEnumerator CQFKNMNMQLN()
	{
		if (this.DJQDMBNLQDI != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
		}
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(DNFENPQLICQ.QOQONHOOLNE.MCPQEOLLKNH) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, this.ILBCCCBJNCL.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		num = 0;
		goto IL_15C;
		IL_12A:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_15C:
		if (num < componentsInChildren.Length)
		{
			goto IL_12A;
		}
		yield break;
	}

	// Token: 0x06005C70 RID: 23664 RVA: 0x002F66F0 File Offset: 0x002F48F0
	private IEnumerator ENGQNHDIOOL()
	{
		if (this.DJQDMBNLQDI != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
		}
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(DNFENPQLICQ.QOQONHOOLNE.MCPQEOLLKNH) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, this.ILBCCCBJNCL.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		num = 0;
		goto IL_15C;
		IL_12A:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_15C:
		if (num < componentsInChildren.Length)
		{
			goto IL_12A;
		}
		yield break;
	}

	// Token: 0x06005C71 RID: 23665 RVA: 0x00024482 File Offset: 0x00022682
	private void OEOJDKBDNMJ()
	{
		CHFPDQEKFEE.QOQONHOOLNE = this;
	}

	// Token: 0x06005C72 RID: 23666 RVA: 0x000244CD File Offset: 0x000226CD
	private void BCEKGNDIIOE()
	{
		CHFPDQEKFEE.BFJJJGBICJK(this);
	}

	// Token: 0x06005C73 RID: 23667 RVA: 0x000244D5 File Offset: 0x000226D5
	public void QPBLHDQDGCB(string BGBMIEJJQKC)
	{
		this.MKDMNPCBDHL = BGBMIEJJQKC;
		if (this.MCIKNBGQGEB != null)
		{
			base.StopCoroutine(this.MCIKNBGQGEB);
		}
		this.MCIKNBGQGEB = base.StartCoroutine(this.EGOEFQBGBNL(this.MKDMNPCBDHL));
	}

	// Token: 0x06005C74 RID: 23668 RVA: 0x002F6630 File Offset: 0x002F4830
	private void QNGIFIJOQML()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.HKGFNLMJOJM = eulerAngles.y;
		this.CQLNCICHEQG = eulerAngles.x;
		this.QIGFKEKPKIM = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
	}

	// Token: 0x06005C75 RID: 23669 RVA: 0x0002450A File Offset: 0x0002270A
	private void PHEMLIPBHOJ()
	{
		base.StartCoroutine(this.NEJCCCDHKEB());
	}

	// Token: 0x06005C76 RID: 23670 RVA: 0x002F6698 File Offset: 0x002F4898
	private Vector3 NBNIOQHODBG(Vector3 ILJPENJCKOB, Vector3 QODMGICELOG, float OQJFBJQJEFG)
	{
		float x = Mathf.LerpAngle(ILJPENJCKOB.x, QODMGICELOG.x, OQJFBJQJEFG);
		float y = Mathf.LerpAngle(ILJPENJCKOB.y, QODMGICELOG.y, OQJFBJQJEFG);
		float z = Mathf.LerpAngle(ILJPENJCKOB.z, QODMGICELOG.z, OQJFBJQJEFG);
		Vector3 result = new Vector3(x, y, z);
		return result;
	}

	// Token: 0x06005C77 RID: 23671 RVA: 0x002F6630 File Offset: 0x002F4830
	private void GJLLCMLLEQF()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.HKGFNLMJOJM = eulerAngles.y;
		this.CQLNCICHEQG = eulerAngles.x;
		this.QIGFKEKPKIM = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
	}

	// Token: 0x06005C78 RID: 23672 RVA: 0x00024438 File Offset: 0x00022638
	public string IJFBPLMMMDQ()
	{
		return this.MKDMNPCBDHL;
	}

	// Token: 0x06005C79 RID: 23673 RVA: 0x00024519 File Offset: 0x00022719
	public static float MOHDNOLHEMD(float MPNNMHJBOPN, float LCELGLKMPFN, float MJGGCLOGKFL)
	{
		if (MPNNMHJBOPN < 968f)
		{
			MPNNMHJBOPN += 1525f;
		}
		if (MPNNMHJBOPN > 1895f)
		{
			MPNNMHJBOPN -= 1599f;
		}
		return Mathf.Clamp(MPNNMHJBOPN, LCELGLKMPFN, MJGGCLOGKFL);
	}

	// Token: 0x06005C7A RID: 23674 RVA: 0x002F6B30 File Offset: 0x002F4D30
	private void HLMNLNPDLOJ()
	{
		if (!Input.GetKey((KeyCode)(-69)) && !Input.GetKey(KeyCode.P))
		{
			this.QIGFKEKPKIM.velocity = Vector3.Lerp(this.QIGFKEKPKIM.velocity, Vector3.zero, Time.fixedDeltaTime * this.LLPEMNIPJBO);
			this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, Quaternion.Euler(1453f, this.ILBCCCBJNCL.eulerAngles.y, this.ILBCCCBJNCL.eulerAngles.z), Time.fixedDeltaTime * 1023f);
			if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
			{
				bool flag = true;
				if (!Input.GetKey((KeyCode)(-92)) && !Input.GetKey(KeyCode.Alpha8))
				{
					if (Input.GetKey(KeyCode.Pause) || Input.GetKey((KeyCode)(-165)))
					{
						flag = true;
						this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.right * 1785f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.right * 987f;
					flag = true;
				}
				if (Input.GetKey(KeyCode.RightParen) || Input.GetKey((KeyCode)(-99)))
				{
					if (flag)
					{
						this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.forward * 911f;
					}
					else
					{
						this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.forward * 89f;
					}
				}
				if (Input.GetKey((KeyCode)14))
				{
					this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 761f;
				}
				else if (Input.GetKey((KeyCode)(-187)))
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 993f;
				}
				if (Input.GetKey((KeyCode)(-109)) || Input.GetKey((KeyCode)66))
				{
					this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 783f);
				}
			}
		}
		else if (!CNCJKLNHQBH.BJLGEDCPENQ().GJECFKPGQQF)
		{
			if (Input.GetMouseButton(1) && CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME != Vector2.zero)
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 298f);
			}
			else if (Input.GetKey((KeyCode)69) || Input.GetKey((KeyCode)126))
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1210f);
			}
			this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.forward * 767f;
			if (!Input.GetMouseButton(0))
			{
				if (!Input.GetKey((KeyCode)(-28)) && !Input.GetKey(KeyCode.Alpha0))
				{
					if (Input.GetKey(KeyCode.M) || Input.GetKey((KeyCode)178))
					{
						this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.right * 30f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.right * 1982f;
				}
			}
			if (Input.GetKey(KeyCode.Pause))
			{
				this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 1435f;
			}
			else if (Input.GetKey((KeyCode)(-96)))
			{
				this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 1768f;
			}
		}
	}

	// Token: 0x06005C7B RID: 23675 RVA: 0x002F6F54 File Offset: 0x002F5154
	private void LJJEENLPKHE()
	{
		if (!Input.GetKey(KeyCode.U) && !Input.GetKey((KeyCode)(-95)))
		{
			this.QIGFKEKPKIM.velocity = Vector3.Lerp(this.QIGFKEKPKIM.velocity, Vector3.zero, Time.fixedDeltaTime * this.LLPEMNIPJBO);
			this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, Quaternion.Euler(1416f, this.ILBCCCBJNCL.eulerAngles.y, this.ILBCCCBJNCL.eulerAngles.z), Time.fixedDeltaTime * 945f);
			if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
			{
				bool flag = true;
				if (!Input.GetKey((KeyCode)(-34)) && !Input.GetKey((KeyCode)14))
				{
					if (Input.GetKey(KeyCode.DoubleQuote) || Input.GetKey((KeyCode)15))
					{
						flag = false;
						this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.right * 366f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.right * 1765f;
					flag = false;
				}
				if (Input.GetKey((KeyCode)(-97)) || Input.GetKey((KeyCode)(-67)))
				{
					if (flag)
					{
						this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.forward * 1972f;
					}
					else
					{
						this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.forward * 505f;
					}
				}
				if (Input.GetKey((KeyCode)(-82)))
				{
					this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 756f;
				}
				else if (Input.GetKey((KeyCode)(-56)))
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 1756f;
				}
				if (Input.GetKey((KeyCode)126) || Input.GetKey((KeyCode)(-44)))
				{
					this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1471f);
				}
			}
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
		{
			if (Input.GetMouseButton(0) && CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME != Vector2.zero)
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1626f);
			}
			else if (Input.GetKey((KeyCode)21) || Input.GetKey((KeyCode)65))
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1879f);
			}
			this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.forward * 1555f;
			if (!Input.GetMouseButton(0))
			{
				if (!Input.GetKey((KeyCode)37) && !Input.GetKey((KeyCode)29))
				{
					if (Input.GetKey((KeyCode)(-41)) || Input.GetKey(KeyCode.Alpha7))
					{
						this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.right * 652f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.right * 323f;
				}
			}
			if (Input.GetKey(KeyCode.Quote))
			{
				this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 158f;
			}
			else if (Input.GetKey((KeyCode)(-33)))
			{
				this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 1035f;
			}
		}
	}

	// Token: 0x06005C7C RID: 23676 RVA: 0x002F7378 File Offset: 0x002F5578
	private void FixedUpdate()
	{
		if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.UpArrow))
		{
			this.QIGFKEKPKIM.velocity = Vector3.Lerp(this.QIGFKEKPKIM.velocity, Vector3.zero, Time.fixedDeltaTime * this.LLPEMNIPJBO);
			this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, Quaternion.Euler(10f, this.ILBCCCBJNCL.eulerAngles.y, this.ILBCCCBJNCL.eulerAngles.z), Time.fixedDeltaTime * 2f);
			if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
			{
				bool flag = false;
				if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow))
				{
					if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
					{
						flag = true;
						this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.right * 10f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.right * 10f;
					flag = true;
				}
				if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
				{
					if (flag)
					{
						this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.forward * 10f;
					}
					else
					{
						this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.forward * 10f;
					}
				}
				if (Input.GetKey(KeyCode.Space))
				{
					this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 2f;
				}
				else if (Input.GetKey(KeyCode.LeftShift))
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 2f;
				}
				if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
				{
					this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 4f);
				}
			}
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
		{
			if (Input.GetMouseButton(1) && CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME != Vector2.zero)
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 4f);
			}
			else if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E))
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 4f);
			}
			this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.forward * 26f;
			if (!Input.GetMouseButton(1))
			{
				if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow))
				{
					if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
					{
						this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.right * 10f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.right * 10f;
				}
			}
			if (Input.GetKey(KeyCode.Space))
			{
				this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 10f;
			}
			else if (Input.GetKey(KeyCode.LeftShift))
			{
				this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 10f;
			}
		}
	}

	// Token: 0x06005C7D RID: 23677 RVA: 0x0002448A File Offset: 0x0002268A
	private static void GPEHBGGGNOE(CHFPDQEKFEE BGBMIEJJQKC)
	{
		CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06005C7E RID: 23678 RVA: 0x0002448A File Offset: 0x0002268A
	private static void BFJJJGBICJK(CHFPDQEKFEE BGBMIEJJQKC)
	{
		CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06005C7F RID: 23679 RVA: 0x00024545 File Offset: 0x00022745
	public void IBNMNNKELIF()
	{
		if (base.gameObject.activeInHierarchy)
		{
			base.StartCoroutine(this.JENPEDOOLBI());
		}
	}

	// Token: 0x06005C80 RID: 23680 RVA: 0x002F6674 File Offset: 0x002F4874
	private IEnumerator HIHQNJKLLIK(string KEQMEGEHFIK)
	{
		CHFPDQEKFEE.OBICHFPKIBK obichfpkibk = new CHFPDQEKFEE.OBICHFPKIBK();
		obichfpkibk.KEQMEGEHFIK = KEQMEGEHFIK;
		obichfpkibk.QNDQJMNKFNN = this;
		return obichfpkibk;
	}

	// Token: 0x06005C81 RID: 23681 RVA: 0x00024545 File Offset: 0x00022745
	public void NDKBBCKLMDO()
	{
		if (base.gameObject.activeInHierarchy)
		{
			base.StartCoroutine(this.JENPEDOOLBI());
		}
	}

	// Token: 0x06005C82 RID: 23682 RVA: 0x00002300 File Offset: 0x00000500
	private void Update()
	{
	}

	// Token: 0x06005C83 RID: 23683 RVA: 0x00024438 File Offset: 0x00022638
	public string INOHOHJDJIM()
	{
		return this.MKDMNPCBDHL;
	}

	// Token: 0x06005C84 RID: 23684 RVA: 0x00024561 File Offset: 0x00022761
	public void DEDIPJDEHJG()
	{
		if (base.gameObject.activeInHierarchy)
		{
			base.StartCoroutine(this.ENGQNHDIOOL());
		}
	}

	// Token: 0x06005C85 RID: 23685 RVA: 0x002F6698 File Offset: 0x002F4898
	private Vector3 JGFELIOEDEO(Vector3 ILJPENJCKOB, Vector3 QODMGICELOG, float OQJFBJQJEFG)
	{
		float x = Mathf.LerpAngle(ILJPENJCKOB.x, QODMGICELOG.x, OQJFBJQJEFG);
		float y = Mathf.LerpAngle(ILJPENJCKOB.y, QODMGICELOG.y, OQJFBJQJEFG);
		float z = Mathf.LerpAngle(ILJPENJCKOB.z, QODMGICELOG.z, OQJFBJQJEFG);
		Vector3 result = new Vector3(x, y, z);
		return result;
	}

	// Token: 0x06005C86 RID: 23686 RVA: 0x002F6698 File Offset: 0x002F4898
	private Vector3 NDNHDNKGBQB(Vector3 ILJPENJCKOB, Vector3 QODMGICELOG, float OQJFBJQJEFG)
	{
		float x = Mathf.LerpAngle(ILJPENJCKOB.x, QODMGICELOG.x, OQJFBJQJEFG);
		float y = Mathf.LerpAngle(ILJPENJCKOB.y, QODMGICELOG.y, OQJFBJQJEFG);
		float z = Mathf.LerpAngle(ILJPENJCKOB.z, QODMGICELOG.z, OQJFBJQJEFG);
		Vector3 result = new Vector3(x, y, z);
		return result;
	}

	// Token: 0x06005C87 RID: 23687 RVA: 0x00002300 File Offset: 0x00000500
	private void EQIMMIBMQGP()
	{
	}

	// Token: 0x06005C88 RID: 23688 RVA: 0x0002457D File Offset: 0x0002277D
	public void MCHMMNBMHHC()
	{
		if (base.gameObject.activeInHierarchy)
		{
			base.StartCoroutine(this.HCNEOFKGDGP());
		}
	}

	// Token: 0x06005C89 RID: 23689 RVA: 0x00024599 File Offset: 0x00022799
	private void OnEnable()
	{
		base.StartCoroutine(this.HCNEOFKGDGP());
	}

	// Token: 0x06005C8A RID: 23690 RVA: 0x00002300 File Offset: 0x00000500
	private void QFFJMIOJENJ()
	{
	}

	// Token: 0x06005C8B RID: 23691 RVA: 0x000245A8 File Offset: 0x000227A8
	public void IBILNGMJFKF()
	{
		if (base.gameObject.activeInHierarchy)
		{
			base.StartCoroutine(this.DHOJGCMFLMO());
		}
	}

	// Token: 0x06005C8C RID: 23692 RVA: 0x0002448A File Offset: 0x0002268A
	private static void QIJENCEFEJP(CHFPDQEKFEE BGBMIEJJQKC)
	{
		CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06005C8D RID: 23693 RVA: 0x00024440 File Offset: 0x00022640
	public static CHFPDQEKFEE CKQHNOIQNQJ()
	{
		return CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06005C8E RID: 23694 RVA: 0x0002448A File Offset: 0x0002268A
	private static void PKOFNBCLFJC(CHFPDQEKFEE BGBMIEJJQKC)
	{
		CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField = BGBMIEJJQKC;
	}

	// Token: 0x06005C8F RID: 23695 RVA: 0x00002300 File Offset: 0x00000500
	private void GCQNFNBMMPQ()
	{
	}

	// Token: 0x06005C90 RID: 23696 RVA: 0x002F779C File Offset: 0x002F599C
	private void QFQFMDLCIED()
	{
		if (!Input.GetKey((KeyCode)28) && !Input.GetKey((KeyCode)(-171)))
		{
			this.QIGFKEKPKIM.velocity = Vector3.Lerp(this.QIGFKEKPKIM.velocity, Vector3.zero, Time.fixedDeltaTime * this.LLPEMNIPJBO);
			this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, Quaternion.Euler(1624f, this.ILBCCCBJNCL.eulerAngles.y, this.ILBCCCBJNCL.eulerAngles.z), Time.fixedDeltaTime * 1828f);
			if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
			{
				bool flag = false;
				if (!Input.GetKey((KeyCode)(-1)) && !Input.GetKey((KeyCode)(-35)))
				{
					if (Input.GetKey((KeyCode)(-10)) || Input.GetKey((KeyCode)(-8)))
					{
						flag = true;
						this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.right * 1478f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.right * 104f;
					flag = true;
				}
				if (Input.GetKey((KeyCode)(-54)) || Input.GetKey((KeyCode)148))
				{
					if (flag)
					{
						this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.forward * 771f;
					}
					else
					{
						this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.forward * 522f;
					}
				}
				if (Input.GetKey(KeyCode.S))
				{
					this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 181f;
				}
				else if (Input.GetKey((KeyCode)143))
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 877f;
				}
				if (Input.GetKey((KeyCode)(-86)) || Input.GetKey((KeyCode)(-122)))
				{
					this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 188f);
				}
			}
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
		{
			if (Input.GetMouseButton(1) && CNCJKLNHQBH.MOGQNGEPCEO().OPMMEOJEBME != Vector2.zero)
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 323f);
			}
			else if (Input.GetKey((KeyCode)(-3)) || Input.GetKey((KeyCode)(-80)))
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1806f);
			}
			this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.forward * 1303f;
			if (!Input.GetMouseButton(0))
			{
				if (!Input.GetKey((KeyCode)81) && !Input.GetKey((KeyCode)(-4)))
				{
					if (Input.GetKey((KeyCode)(-35)) || Input.GetKey((KeyCode)124))
					{
						this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.right * 560f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.right * 1636f;
				}
			}
			if (Input.GetKey((KeyCode)(-65)))
			{
				this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 862f;
			}
			else if (Input.GetKey((KeyCode)179))
			{
				this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 1565f;
			}
		}
	}

	// Token: 0x06005C91 RID: 23697 RVA: 0x000244D5 File Offset: 0x000226D5
	public void JCOKDEILJQL(string BGBMIEJJQKC)
	{
		this.MKDMNPCBDHL = BGBMIEJJQKC;
		if (this.MCIKNBGQGEB != null)
		{
			base.StopCoroutine(this.MCIKNBGQGEB);
		}
		this.MCIKNBGQGEB = base.StartCoroutine(this.EGOEFQBGBNL(this.MKDMNPCBDHL));
	}

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x06005C92 RID: 23698 RVA: 0x00024438 File Offset: 0x00022638
	// (set) Token: 0x06005C9A RID: 23706 RVA: 0x000244D5 File Offset: 0x000226D5
	public string JLOPEJDKCIO
	{
		get
		{
			return this.MKDMNPCBDHL;
		}
		set
		{
			this.MKDMNPCBDHL = value;
			if (this.MCIKNBGQGEB != null)
			{
				base.StopCoroutine(this.MCIKNBGQGEB);
			}
			this.MCIKNBGQGEB = base.StartCoroutine(this.EGOEFQBGBNL(this.MKDMNPCBDHL));
		}
	}

	// Token: 0x06005C93 RID: 23699 RVA: 0x00024473 File Offset: 0x00022673
	private void HQMLEGGKFNF()
	{
		base.StartCoroutine(this.ENGQNHDIOOL());
	}

	// Token: 0x06005C94 RID: 23700 RVA: 0x002F66F0 File Offset: 0x002F48F0
	private IEnumerator HCNEOFKGDGP()
	{
		if (this.DJQDMBNLQDI != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
		}
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(DNFENPQLICQ.QOQONHOOLNE.MCPQEOLLKNH) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, this.ILBCCCBJNCL.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		num = 0;
		goto IL_15C;
		IL_12A:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_15C:
		if (num < componentsInChildren.Length)
		{
			goto IL_12A;
		}
		yield break;
	}

	// Token: 0x06005C95 RID: 23701 RVA: 0x002F7BC0 File Offset: 0x002F5DC0
	private void KFOHBBFQBII()
	{
		if (this.ILBCCCBJNCL)
		{
			bool flag = true;
			if (Input.GetKey((KeyCode)(-74)) || Input.GetKey(KeyCode.BackQuote))
			{
				flag = true;
			}
			if (!Input.GetKey((KeyCode)87) && !Input.GetKey((KeyCode)199))
			{
				if (!CNCJKLNHQBH.BJLGEDCPENQ().GJECFKPGQQF)
				{
					if (!Input.GetKey((KeyCode)81) && !Input.GetKey((KeyCode)(-134)))
					{
						if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Quote))
						{
							flag = true;
						}
					}
					else
					{
						flag = false;
					}
					if (Input.GetKey((KeyCode)(-79)) || Input.GetKey((KeyCode)(-151)))
					{
						flag = false;
					}
				}
				if (this.HPIMMEFNKJH != null)
				{
					this.HPIMMEFNKJH.CrossFade("'.");
				}
			}
			else
			{
				if (!CNCJKLNHQBH.BJLGEDCPENQ().GJECFKPGQQF)
				{
					flag = false;
				}
				if (this.HPIMMEFNKJH != null)
				{
					this.HPIMMEFNKJH.CrossFade("5");
				}
			}
			if (!flag)
			{
				GGQKBGDGNJN.QOQONHOOLNE.DMDJFOJGKPI();
			}
			else
			{
				GGQKBGDGNJN.QOQONHOOLNE.PJDBLJPLJPK();
			}
			if ((Input.GetMouseButton(1) || Input.GetMouseButton(1)) && CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME != Vector2.zero)
			{
				this.LLQHIFJLDGI += this.PLGMJJEQJDI * Input.GetAxis("deltrastream") * 350f;
				this.MLLGNOLPGJF += this.QNMGEEKIIGB * Input.GetAxis("OnDragOut") * 916f;
				if (Cursor.visible)
				{
					Cursor.visible = true;
					Cursor.lockState = CursorLockMode.None;
				}
			}
			else if (!Cursor.visible)
			{
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.None;
			}
			if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
			{
				if (Input.GetKey((KeyCode)(-80)))
				{
					this.LLQHIFJLDGI = -this.PLGMJJEQJDI * 1944f;
				}
				else if (Input.GetKey((KeyCode)(-37)))
				{
					this.LLQHIFJLDGI = this.PLGMJJEQJDI * 273f;
				}
			}
			this.HKGFNLMJOJM += this.LLQHIFJLDGI;
			this.CQLNCICHEQG -= this.MLLGNOLPGJF;
			this.CQLNCICHEQG = CHFPDQEKFEE.IIJDCJIPHMF(this.CQLNCICHEQG, this.PFNEGQPQPNC, this.NQQQLJKCCCH);
			Quaternion quaternion = Quaternion.Euler(this.CQLNCICHEQG, this.HKGFNLMJOJM, 1522f);
			Quaternion rotation = quaternion;
			if (CNCJKLNHQBH.BJLGEDCPENQ().LKHOCPNQIMB != 1309f)
			{
				this.NMOIEEGJCOK = Mathf.Clamp(this.NMOIEEGJCOK - Input.GetAxis("_Dissolve") * 351f, this.HMDNNPFDELM, this.DOPBDBLJNOO);
			}
			this.FKDGEKNHQFB = Mathf.Lerp(this.FKDGEKNHQFB, this.NMOIEEGJCOK, Time.deltaTime * 1786f);
			Vector3 point = new Vector3(1661f, 759f, -this.FKDGEKNHQFB);
			this.BDBBEMKFGPI = rotation * point + this.ILBCCCBJNCL.position;
			base.transform.rotation = rotation;
			base.transform.position = this.BDBBEMKFGPI;
			this.LLQHIFJLDGI = Mathf.Lerp(this.LLQHIFJLDGI, 369f, Time.deltaTime * this.EHFBEOOFPOQ);
			this.MLLGNOLPGJF = Mathf.Lerp(this.MLLGNOLPGJF, 1568f, Time.deltaTime * this.EHFBEOOFPOQ);
		}
		CNCJKLNHQBH.QOQONHOOLNE.LKHOCPNQIMB = 921f;
	}

	// Token: 0x06005C96 RID: 23702 RVA: 0x000245C4 File Offset: 0x000227C4
	private void KMQPMGPDPEC()
	{
		CHFPDQEKFEE.PKOFNBCLFJC(this);
	}

	// Token: 0x06005C97 RID: 23703 RVA: 0x000245CC File Offset: 0x000227CC
	public void IOHKJGPBQLD()
	{
		if (base.gameObject.activeInHierarchy)
		{
			base.StartCoroutine(this.CQFKNMNMQLN());
		}
	}

	// Token: 0x06005C98 RID: 23704 RVA: 0x000245E8 File Offset: 0x000227E8
	public void FMHEHHDGPNG(string BGBMIEJJQKC)
	{
		this.MKDMNPCBDHL = BGBMIEJJQKC;
		if (this.MCIKNBGQGEB != null)
		{
			base.StopCoroutine(this.MCIKNBGQGEB);
		}
		this.MCIKNBGQGEB = base.StartCoroutine(this.HIHQNJKLLIK(this.MKDMNPCBDHL));
	}

	// Token: 0x06005C99 RID: 23705 RVA: 0x002F6630 File Offset: 0x002F4830
	private void HCHIDEKMEBB()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.HKGFNLMJOJM = eulerAngles.y;
		this.CQLNCICHEQG = eulerAngles.x;
		this.QIGFKEKPKIM = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
	}

	// Token: 0x06005C9B RID: 23707 RVA: 0x002F6674 File Offset: 0x002F4874
	[DebuggerHidden]
	private IEnumerator EGOEFQBGBNL(string KEQMEGEHFIK)
	{
		CHFPDQEKFEE.OBICHFPKIBK obichfpkibk = new CHFPDQEKFEE.OBICHFPKIBK();
		obichfpkibk.KEQMEGEHFIK = KEQMEGEHFIK;
		obichfpkibk.QNDQJMNKFNN = this;
		return obichfpkibk;
	}

	// Token: 0x06005C9D RID: 23709 RVA: 0x002F66F0 File Offset: 0x002F48F0
	private IEnumerator JENPEDOOLBI()
	{
		if (this.DJQDMBNLQDI != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DJQDMBNLQDI);
		}
		assetBundleRequest = GGQKBGDGNJN.HGBFNDILJLQ.LoadAssetAsync("Assets/AssetBundles/Fly Pokemon/" + EMLOFJDOMKH.QOQONHOOLNE.COHGNMFDCJC(DNFENPQLICQ.QOQONHOOLNE.MCPQEOLLKNH) + "/Model.prefab");
		yield return assetBundleRequest;
		return 1;
		yield return new WaitForFixedUpdate();
		return 1;
		asset = assetBundleRequest.asset;
		this.DJQDMBNLQDI = (UnityEngine.Object.Instantiate(asset, this.ILBCCCBJNCL.transform) as GameObject);
		this.HPIMMEFNKJH = this.DJQDMBNLQDI.GetComponent<Animation>();
		componentsInChildren = this.DJQDMBNLQDI.GetComponentsInChildren<SkinnedMeshRenderer>();
		num = 0;
		goto IL_15C;
		IL_12A:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_15C:
		if (num < componentsInChildren.Length)
		{
			goto IL_12A;
		}
		yield break;
	}

	// Token: 0x06005C9E RID: 23710 RVA: 0x002F7F8C File Offset: 0x002F618C
	private void LateUpdate()
	{
		if (this.ILBCCCBJNCL)
		{
			bool flag = false;
			if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.LeftShift))
			{
				flag = true;
			}
			if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.UpArrow))
			{
				if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
				{
					if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftArrow))
					{
						if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
					if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
					{
						flag = true;
					}
				}
				if (this.HPIMMEFNKJH != null)
				{
					this.HPIMMEFNKJH.CrossFade("300");
				}
			}
			else
			{
				if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
				{
					flag = true;
				}
				if (this.HPIMMEFNKJH != null)
				{
					this.HPIMMEFNKJH.CrossFade("301");
				}
			}
			if (!flag)
			{
				GGQKBGDGNJN.QOQONHOOLNE.IMBHCMGGLNO();
			}
			else
			{
				GGQKBGDGNJN.QOQONHOOLNE.NNBLMCDNKHM();
			}
			if ((Input.GetMouseButton(1) || Input.GetMouseButton(0)) && CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME != Vector2.zero)
			{
				this.LLQHIFJLDGI += this.PLGMJJEQJDI * Input.GetAxis("Mouse X") * 0.02f;
				this.MLLGNOLPGJF += this.QNMGEEKIIGB * Input.GetAxis("Mouse Y") * 0.02f;
				if (Cursor.visible)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
			}
			else if (!Cursor.visible)
			{
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
			if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
			{
				if (Input.GetKey(KeyCode.Q))
				{
					this.LLQHIFJLDGI = -this.PLGMJJEQJDI * 0.02f;
				}
				else if (Input.GetKey(KeyCode.E))
				{
					this.LLQHIFJLDGI = this.PLGMJJEQJDI * 0.02f;
				}
			}
			this.HKGFNLMJOJM += this.LLQHIFJLDGI;
			this.CQLNCICHEQG -= this.MLLGNOLPGJF;
			this.CQLNCICHEQG = CHFPDQEKFEE.IIJDCJIPHMF(this.CQLNCICHEQG, this.PFNEGQPQPNC, this.NQQQLJKCCCH);
			Quaternion quaternion = Quaternion.Euler(this.CQLNCICHEQG, this.HKGFNLMJOJM, 0f);
			Quaternion rotation = quaternion;
			if (CNCJKLNHQBH.QOQONHOOLNE.LKHOCPNQIMB != 0f)
			{
				this.NMOIEEGJCOK = Mathf.Clamp(this.NMOIEEGJCOK - Input.GetAxis("Mouse ScrollWheel") * 6f, this.HMDNNPFDELM, this.DOPBDBLJNOO);
			}
			this.FKDGEKNHQFB = Mathf.Lerp(this.FKDGEKNHQFB, this.NMOIEEGJCOK, Time.deltaTime * 4f);
			Vector3 point = new Vector3(0f, 0f, -this.FKDGEKNHQFB);
			this.BDBBEMKFGPI = rotation * point + this.ILBCCCBJNCL.position;
			base.transform.rotation = rotation;
			base.transform.position = this.BDBBEMKFGPI;
			this.LLQHIFJLDGI = Mathf.Lerp(this.LLQHIFJLDGI, 0f, Time.deltaTime * this.EHFBEOOFPOQ);
			this.MLLGNOLPGJF = Mathf.Lerp(this.MLLGNOLPGJF, 0f, Time.deltaTime * this.EHFBEOOFPOQ);
		}
		CNCJKLNHQBH.QOQONHOOLNE.LKHOCPNQIMB = 0f;
	}

	// Token: 0x06005C9F RID: 23711 RVA: 0x0002461D File Offset: 0x0002281D
	public static float HKLQHCGICOB(float MPNNMHJBOPN, float LCELGLKMPFN, float MJGGCLOGKFL)
	{
		if (MPNNMHJBOPN < 1533f)
		{
			MPNNMHJBOPN += 762f;
		}
		if (MPNNMHJBOPN > 17f)
		{
			MPNNMHJBOPN -= 701f;
		}
		return Mathf.Clamp(MPNNMHJBOPN, LCELGLKMPFN, MJGGCLOGKFL);
	}

	// Token: 0x06005CA0 RID: 23712 RVA: 0x000245C4 File Offset: 0x000227C4
	private void QIKFOCKCGKL()
	{
		CHFPDQEKFEE.PKOFNBCLFJC(this);
	}

	// Token: 0x06005CA1 RID: 23713 RVA: 0x00024438 File Offset: 0x00022638
	public string IMNBBJEQOKQ()
	{
		return this.MKDMNPCBDHL;
	}

	// Token: 0x06005CA2 RID: 23714 RVA: 0x00024440 File Offset: 0x00022640
	public static CHFPDQEKFEE JPMOJGDNKNC()
	{
		return CHFPDQEKFEE.<BILMJGJHOMC>k__BackingField;
	}

	// Token: 0x06005CA3 RID: 23715 RVA: 0x00002300 File Offset: 0x00000500
	private void IDFIBQLDDPP()
	{
	}

	// Token: 0x06005CA4 RID: 23716 RVA: 0x002F82CC File Offset: 0x002F64CC
	private void CHDIKKIEBPG()
	{
		if (!Input.GetKey((KeyCode)(-11)) && !Input.GetKey((KeyCode)171))
		{
			this.QIGFKEKPKIM.velocity = Vector3.Lerp(this.QIGFKEKPKIM.velocity, Vector3.zero, Time.fixedDeltaTime * this.LLPEMNIPJBO);
			this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, Quaternion.Euler(835f, this.ILBCCCBJNCL.eulerAngles.y, this.ILBCCCBJNCL.eulerAngles.z), Time.fixedDeltaTime * 838f);
			if (!CNCJKLNHQBH.MOGQNGEPCEO().GJECFKPGQQF)
			{
				bool flag = false;
				if (!Input.GetKey((KeyCode)(-90)) && !Input.GetKey(KeyCode.Dollar))
				{
					if (Input.GetKey((KeyCode)70) || Input.GetKey(KeyCode.Delete))
					{
						flag = true;
						this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.right * 1169f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.right * 1849f;
					flag = true;
				}
				if (Input.GetKey((KeyCode)(-111)) || Input.GetKey((KeyCode)(-154)))
				{
					if (flag)
					{
						this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.forward * 542f;
					}
					else
					{
						this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.forward * 387f;
					}
				}
				if (Input.GetKey(KeyCode.D))
				{
					this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 1781f;
				}
				else if (Input.GetKey((KeyCode)(-50)))
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 1631f;
				}
				if (Input.GetKey((KeyCode)(-37)) || Input.GetKey((KeyCode)(-60)))
				{
					this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 75f);
				}
			}
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
		{
			if (Input.GetMouseButton(1) && CNCJKLNHQBH.MOGQNGEPCEO().OPMMEOJEBME != Vector2.zero)
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1934f);
			}
			else if (Input.GetKey((KeyCode)30) || Input.GetKey((KeyCode)(-1)))
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 686f);
			}
			this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.forward * 626f;
			if (!Input.GetMouseButton(1))
			{
				if (!Input.GetKey((KeyCode)(-127)) && !Input.GetKey((KeyCode)72))
				{
					if (Input.GetKey((KeyCode)37) || Input.GetKey((KeyCode)(-155)))
					{
						this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.right * 1424f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.right * 1441f;
				}
			}
			if (Input.GetKey((KeyCode)(-68)))
			{
				this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 1688f;
			}
			else if (Input.GetKey((KeyCode)(-199)))
			{
				this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 1739f;
			}
		}
	}

	// Token: 0x06005CA5 RID: 23717 RVA: 0x002F86F0 File Offset: 0x002F68F0
	private void EKQIGMPMGHN()
	{
		if (!Input.GetKey(KeyCode.Alpha5) && !Input.GetKey((KeyCode)(-150)))
		{
			this.QIGFKEKPKIM.velocity = Vector3.Lerp(this.QIGFKEKPKIM.velocity, Vector3.zero, Time.fixedDeltaTime * this.LLPEMNIPJBO);
			this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, Quaternion.Euler(1472f, this.ILBCCCBJNCL.eulerAngles.y, this.ILBCCCBJNCL.eulerAngles.z), Time.fixedDeltaTime * 1557f);
			if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
			{
				bool flag = false;
				if (!Input.GetKey((KeyCode)(-128)) && !Input.GetKey((KeyCode)2))
				{
					if (Input.GetKey((KeyCode)(-64)) || Input.GetKey(KeyCode.Alpha2))
					{
						flag = true;
						this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.right * 1272f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.right * 928f;
					flag = true;
				}
				if (Input.GetKey((KeyCode)76) || Input.GetKey((KeyCode)(-29)))
				{
					if (flag)
					{
						this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.forward * 1348f;
					}
					else
					{
						this.QIGFKEKPKIM.velocity = -this.ILBCCCBJNCL.forward * 26f;
					}
				}
				if (Input.GetKey((KeyCode)(-54)))
				{
					this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 99f;
				}
				else if (Input.GetKey(KeyCode.Plus))
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 141f;
				}
				if (Input.GetKey((KeyCode)85) || Input.GetKey((KeyCode)(-29)))
				{
					this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1741f);
				}
			}
		}
		else if (!CNCJKLNHQBH.QOQONHOOLNE.GJECFKPGQQF)
		{
			if (Input.GetMouseButton(0) && CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME != Vector2.zero)
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1520f);
			}
			else if (Input.GetKey((KeyCode)11) || Input.GetKey((KeyCode)76))
			{
				this.QIGFKEKPKIM.rotation = Quaternion.Lerp(this.QIGFKEKPKIM.rotation, base.transform.rotation, Time.fixedDeltaTime * 1826f);
			}
			this.QIGFKEKPKIM.velocity = this.ILBCCCBJNCL.forward * 1373f;
			if (!Input.GetMouseButton(1))
			{
				if (!Input.GetKey((KeyCode)78) && !Input.GetKey((KeyCode)(-163)))
				{
					if (Input.GetKey(KeyCode.Q) || Input.GetKey((KeyCode)172))
					{
						this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.right * 33f;
					}
				}
				else
				{
					this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.right * 265f;
				}
			}
			if (Input.GetKey((KeyCode)(-70)))
			{
				this.QIGFKEKPKIM.velocity += this.ILBCCCBJNCL.up * 1138f;
			}
			else if (Input.GetKey((KeyCode)(-130)))
			{
				this.QIGFKEKPKIM.velocity += -this.ILBCCCBJNCL.up * 1400f;
			}
		}
	}

	// Token: 0x06005CA6 RID: 23718 RVA: 0x002F6630 File Offset: 0x002F4830
	private void Start()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.HKGFNLMJOJM = eulerAngles.y;
		this.CQLNCICHEQG = eulerAngles.x;
		this.QIGFKEKPKIM = this.ILBCCCBJNCL.GetComponent<Rigidbody>();
	}

	// Token: 0x040013ED RID: 5101
	private string MKDMNPCBDHL;

	// Token: 0x040013EE RID: 5102
	public MKOENKCLJGF ECCMOCKGMIK;

	// Token: 0x040013EF RID: 5103
	private Coroutine MCIKNBGQGEB;

	// Token: 0x040013F0 RID: 5104
	public QHQFGHKIMMF CBHFDIPMMQG;

	// Token: 0x040013F1 RID: 5105
	public CFDMNELIJLO FPGMCKCDHGQ;

	// Token: 0x040013F2 RID: 5106
	public BKKHLBCLPJM CPOCLQDPQFO;

	// Token: 0x040013F3 RID: 5107
	public Transform ILBCCCBJNCL;

	// Token: 0x040013F4 RID: 5108
	private Rigidbody QIGFKEKPKIM;

	// Token: 0x040013F5 RID: 5109
	public float LNIPLLDBJDI = 1f;

	// Token: 0x040013F6 RID: 5110
	public float LLPEMNIPJBO = 1f;

	// Token: 0x040013F7 RID: 5111
	public float NMOIEEGJCOK = 12f;

	// Token: 0x040013F8 RID: 5112
	public float FKDGEKNHQFB = 12f;

	// Token: 0x040013F9 RID: 5113
	public float PLGMJJEQJDI = 20f;

	// Token: 0x040013FA RID: 5114
	public float QNMGEEKIIGB = 180f;

	// Token: 0x040013FB RID: 5115
	public float PFNEGQPQPNC = -30f;

	// Token: 0x040013FC RID: 5116
	public float NQQQLJKCCCH = 75f;

	// Token: 0x040013FD RID: 5117
	public float HMDNNPFDELM = 12f;

	// Token: 0x040013FE RID: 5118
	public float DOPBDBLJNOO = 18f;

	// Token: 0x040013FF RID: 5119
	public float EHFBEOOFPOQ = 2f;

	// Token: 0x04001400 RID: 5120
	private float HKGFNLMJOJM;

	// Token: 0x04001401 RID: 5121
	private float CQLNCICHEQG;

	// Token: 0x04001402 RID: 5122
	private float LLQHIFJLDGI;

	// Token: 0x04001403 RID: 5123
	private float MLLGNOLPGJF;

	// Token: 0x04001404 RID: 5124
	private Animation HPIMMEFNKJH;

	// Token: 0x04001405 RID: 5125
	private Vector3 BDBBEMKFGPI;

	// Token: 0x04001406 RID: 5126
	private GameObject DJQDMBNLQDI;
}

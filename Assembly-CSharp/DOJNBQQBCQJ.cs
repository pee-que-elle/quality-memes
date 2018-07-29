using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200021B RID: 539
public class DOJNBQQBCQJ : MonoBehaviour
{
	// Token: 0x06004920 RID: 18720 RVA: 0x0024CD7C File Offset: 0x0024AF7C
	private void EMKNGMHNOGD(GameObject CGHIENBIHCO)
	{
		CGHIENBIHCO.AddComponent<MeshFilter>();
		CGHIENBIHCO.AddComponent<MeshCollider>();
		MeshFilter[] componentsInChildren = CGHIENBIHCO.GetComponentsInChildren<MeshFilter>();
		CombineInstance[] array = new CombineInstance[componentsInChildren.Length - 1];
		int num = 0;
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (!(componentsInChildren[i].sharedMesh == null))
			{
				array[num].mesh = componentsInChildren[i].sharedMesh;
				array[num++].transform = componentsInChildren[i].transform.localToWorldMatrix;
			}
		}
		CGHIENBIHCO.GetComponent<MeshFilter>().mesh.CombineMeshes(array);
		CGHIENBIHCO.GetComponent<MeshCollider>().sharedMesh = null;
		CGHIENBIHCO.GetComponent<MeshCollider>().sharedMesh = CGHIENBIHCO.GetComponent<MeshFilter>().mesh;
	}

	// Token: 0x06004921 RID: 18721 RVA: 0x0024CE30 File Offset: 0x0024B030
	private void HOGENCGGBNJ(GameObject CGHIENBIHCO)
	{
		CGHIENBIHCO.AddComponent<MeshFilter>();
		CGHIENBIHCO.AddComponent<MeshCollider>();
		MeshFilter[] componentsInChildren = CGHIENBIHCO.GetComponentsInChildren<MeshFilter>();
		CombineInstance[] array = new CombineInstance[componentsInChildren.Length - 0];
		int num = 0;
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (!(componentsInChildren[i].sharedMesh == null))
			{
				array[num].mesh = componentsInChildren[i].sharedMesh;
				CombineInstance[] array2 = array;
				int num2 = num;
				num = num2 + 0;
				array2[num2].transform = componentsInChildren[i].transform.localToWorldMatrix;
			}
		}
		CGHIENBIHCO.GetComponent<MeshFilter>().mesh.CombineMeshes(array);
		CGHIENBIHCO.GetComponent<MeshCollider>().sharedMesh = null;
		CGHIENBIHCO.GetComponent<MeshCollider>().sharedMesh = CGHIENBIHCO.GetComponent<MeshFilter>().mesh;
	}

	// Token: 0x06004922 RID: 18722 RVA: 0x0001E994 File Offset: 0x0001CB94
	[CompilerGenerated]
	private static bool FNJLHCHPPJH(GameObject DGKOIGOLHDM)
	{
		return DGKOIGOLHDM != null;
	}

	// Token: 0x06004924 RID: 18724 RVA: 0x0024CEE4 File Offset: 0x0024B0E4
	public void ONEFMPQECIL(MeshFilter[] KGINGOOIIDI)
	{
		CombineInstance[] array = new CombineInstance[KGINGOOIIDI.Length];
		for (int i = 1; i < KGINGOOIIDI.Length; i++)
		{
			array[i].mesh = KGINGOOIIDI[i].sharedMesh;
			array[i].transform = KGINGOOIIDI[i].transform.localToWorldMatrix;
			KGINGOOIIDI[i].gameObject.SetActive(true);
		}
		GameObject gameObject = this.GFLKJKFQOGB("[33ccff]Lv. ", Vector3.zero, Vector3.zero);
		gameObject.GetComponent<MeshFilter>().mesh = new Mesh();
		gameObject.GetComponent<MeshFilter>().mesh.CombineMeshes(array);
		DOJNBQQBCQJ.OHDCLOLEQFH(gameObject.GetComponent<MeshFilter>().sharedMesh, 332f, 1316f);
		gameObject.gameObject.SetActive(false);
	}

	// Token: 0x06004925 RID: 18725 RVA: 0x0024CFA0 File Offset: 0x0024B1A0
	public GameObject GFLKJKFQOGB(string PFKILQKEPOL, Vector3 NDPKIFIQFCP, Vector3 FPGJCGNPEFC)
	{
		try
		{
			IEnumerable<GameObject> lpecebegmbq = this.LPECEBEGMBQ;
			if (DOJNBQQBCQJ.HNCJFHJNHDN == null)
			{
				DOJNBQQBCQJ.HNCJFHJNHDN = new Func<GameObject, bool>(DOJNBQQBCQJ.FNJLHCHPPJH);
			}
			this.LPECEBEGMBQ = lpecebegmbq.Where(DOJNBQQBCQJ.HNCJFHJNHDN).ToList<GameObject>();
			GameObject gameObject = null;
			bool flag = false;
			if (this.LPECEBEGMBQ.Count > 0)
			{
				for (int i = 0; i < this.LPECEBEGMBQ.Count; i++)
				{
					if (this.LPECEBEGMBQ[i] != null && this.LPECEBEGMBQ[i].name == PFKILQKEPOL)
					{
						flag = true;
						gameObject = UnityEngine.Object.Instantiate<GameObject>(this.LPECEBEGMBQ[i], NDPKIFIQFCP, Quaternion.identity);
						break;
					}
				}
			}
			if (!flag)
			{
				if (PFKILQKEPOL.IBJHJDHKJKL())
				{
					if (PFKILQKEPOL == "PrimitiveFront")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.FrontSide, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveLeftCorner")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.LeftCorner, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveRightCorner")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.RightCorner, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveRight")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.RightSide, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveLeft")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.LeftSide, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveRearRightCorner")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.RearRightCorner, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveRearLeftCorner")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.RearLeftCorner, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveRear")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.RearSide, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveInnerRight")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.InnerFrontRight, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveInnerLeft")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.InnerFrontLeft, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveInnerRearRight")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.InnerRearRight, Vector3.zero);
					}
					if (PFKILQKEPOL == "PrimitiveInnerRearLeft")
					{
						gameObject = this.ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK.InnerRearLeft, Vector3.zero);
					}
				}
				else
				{
					if (DOJNBQQBCQJ.IFEJNKQEDOO == null)
					{
						DOJNBQQBCQJ.IFEJNKQEDOO = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "mdata"));
					}
					if (DOJNBQQBCQJ.DFCHKJIMPIK == null)
					{
						DOJNBQQBCQJ.DFCHKJIMPIK = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, "mdata2"));
					}
					GameObject gameObject2 = (GameObject)DOJNBQQBCQJ.DFCHKJIMPIK.LoadAsset("Assets/AssetBundles/MapAssets2/ModelPrefabs/" + PFKILQKEPOL + ".prefab");
					if (gameObject2 == null)
					{
						gameObject2 = (GameObject)DOJNBQQBCQJ.IFEJNKQEDOO.LoadAsset("Assets/AssetBundles/MapAssets/ModelPrefabs/" + PFKILQKEPOL + ".prefab");
					}
					gameObject = UnityEngine.Object.Instantiate<GameObject>(gameObject2, Vector3.zero, Quaternion.identity);
				}
				gameObject.name = PFKILQKEPOL;
				this.LPECEBEGMBQ.Add(gameObject);
			}
			if (gameObject != null)
			{
				if (!PFKILQKEPOL.IBJHJDHKJKL())
				{
					gameObject.transform.eulerAngles += new Vector3(0f, 180f, 0f) + FPGJCGNPEFC;
					gameObject.transform.localScale = new Vector3(0.0602409f, 0.0602409f, 0.0602409f);
				}
				if (gameObject.tag == "DontScale")
				{
					gameObject.transform.localScale = Vector3.one;
				}
				if (gameObject.GetComponent<DoorAnimator>())
				{
					this.PQFDCJHGHOB.Add(gameObject.GetComponent<DoorAnimator>());
				}
				gameObject.transform.position = NDPKIFIQFCP;
				gameObject.transform.parent = this.IDOEFMCFOBH;
				return gameObject;
			}
		}
		catch (Exception ex)
		{
			Debug.Log(ex.Message + "\n" + PFKILQKEPOL);
		}
		return null;
	}

	// Token: 0x06004926 RID: 18726 RVA: 0x0001E9BB File Offset: 0x0001CBBB
	public static DOJNBQQBCQJ JJCONJJNDQN()
	{
		return DOJNBQQBCQJ.HBFFCJHOCPE;
	}

	// Token: 0x06004927 RID: 18727 RVA: 0x0024D364 File Offset: 0x0024B564
	private GameObject DMCFNPFDHMH(DOJNBQQBCQJ.GQGJQHKJGGK DPQFDCNLLPC, Vector3 NKKGPNPGDEM)
	{
		GameObject gameObject = new GameObject();
		gameObject.AddComponent<MeshCollider>();
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
		gameObject.GetComponent<MeshRenderer>().material = this.IJHHLKJIBJN;
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		this.BHBLHPMEIHM(list, DPQFDCNLLPC);
		this.FHCQCLBGBFN(list2, DPQFDCNLLPC);
		mesh.Clear();
		mesh.vertices = list.ToArray();
		mesh.triangles = list2.ToArray();
		mesh.RecalculateNormals();
		gameObject.GetComponent<MeshCollider>().sharedMesh = mesh;
		gameObject.layer = 24;
		return gameObject;
	}

	// Token: 0x06004928 RID: 18728 RVA: 0x0024D400 File Offset: 0x0024B600
	private GameObject KOOIBMJENOC(DOJNBQQBCQJ.GQGJQHKJGGK DPQFDCNLLPC, Vector3 NKKGPNPGDEM)
	{
		GameObject gameObject = new GameObject();
		gameObject.AddComponent<MeshCollider>();
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
		gameObject.GetComponent<MeshRenderer>().material = this.IJHHLKJIBJN;
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		this.BHBLHPMEIHM(list, DPQFDCNLLPC);
		this.FHCQCLBGBFN(list2, DPQFDCNLLPC);
		mesh.Clear();
		mesh.vertices = list.ToArray();
		mesh.triangles = list2.ToArray();
		mesh.RecalculateNormals();
		gameObject.GetComponent<MeshCollider>().sharedMesh = mesh;
		gameObject.layer = -83;
		return gameObject;
	}

	// Token: 0x06004929 RID: 18729 RVA: 0x0024D49C File Offset: 0x0024B69C
	private void BHBLHPMEIHM(List<Vector3> NGDBDCQFDHI, DOJNBQQBCQJ.GQGJQHKJGGK QONOKDQLJNG)
	{
		if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.FrontSide)
		{
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, -1f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RearSide)
		{
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.4f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RightSide)
		{
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, 0f));
		}
		if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.LeftSide)
		{
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, 0f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RearLeftCorner)
		{
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, -1f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RearRightCorner)
		{
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, -1f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.LeftCorner)
		{
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, -1f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RightCorner)
		{
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, 0f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.InnerFrontRight)
		{
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, -1f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.InnerRearRight)
		{
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0f, 0f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.4f, 0.7f, 0f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.InnerRearLeft)
		{
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.4f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, 0f));
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.InnerFrontLeft)
		{
			NGDBDCQFDHI.Add(new Vector3(1f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0.7f, -0.6f));
			NGDBDCQFDHI.Add(new Vector3(1f, 0f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, 0f));
			NGDBDCQFDHI.Add(new Vector3(0.6f, 0.7f, -1f));
			NGDBDCQFDHI.Add(new Vector3(0f, 1f, -1f));
		}
	}

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x0600492A RID: 18730 RVA: 0x0001E9BB File Offset: 0x0001CBBB
	public static DOJNBQQBCQJ QOQONHOOLNE
	{
		get
		{
			return DOJNBQQBCQJ.HBFFCJHOCPE;
		}
	}

	// Token: 0x0600492B RID: 18731 RVA: 0x0024E234 File Offset: 0x0024C434
	private GameObject LLQCBBDCNQI(DOJNBQQBCQJ.GQGJQHKJGGK DPQFDCNLLPC, Vector3 NKKGPNPGDEM)
	{
		GameObject gameObject = new GameObject();
		gameObject.AddComponent<MeshCollider>();
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
		gameObject.GetComponent<MeshRenderer>().material = this.IJHHLKJIBJN;
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		this.BHBLHPMEIHM(list, DPQFDCNLLPC);
		this.FHCQCLBGBFN(list2, DPQFDCNLLPC);
		mesh.Clear();
		mesh.vertices = list.ToArray();
		mesh.triangles = list2.ToArray();
		mesh.RecalculateNormals();
		gameObject.GetComponent<MeshCollider>().sharedMesh = mesh;
		gameObject.layer = -58;
		return gameObject;
	}

	// Token: 0x0600492C RID: 18732 RVA: 0x0024E2D0 File Offset: 0x0024C4D0
	public GameObject FELDOGIGBFP(Vector3 NDPKIFIQFCP)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.DKNJPPPJOFO, NDPKIFIQFCP, Quaternion.identity);
		gameObject.transform.position = NDPKIFIQFCP;
		gameObject.transform.parent = this.IDOEFMCFOBH;
		return gameObject;
	}

	// Token: 0x0600492D RID: 18733 RVA: 0x0024E310 File Offset: 0x0024C510
	public void HNJPONLKPPB(MeshFilter[] KGINGOOIIDI)
	{
		CombineInstance[] array = new CombineInstance[KGINGOOIIDI.Length];
		for (int i = 1; i < KGINGOOIIDI.Length; i++)
		{
			array[i].mesh = KGINGOOIIDI[i].sharedMesh;
			array[i].transform = KGINGOOIIDI[i].transform.localToWorldMatrix;
			KGINGOOIIDI[i].gameObject.SetActive(true);
		}
		GameObject gameObject = this.GFLKJKFQOGB("_AdditiveReflection", Vector3.zero, Vector3.zero);
		gameObject.GetComponent<MeshFilter>().mesh = new Mesh();
		gameObject.GetComponent<MeshFilter>().mesh.CombineMeshes(array);
		DOJNBQQBCQJ.OHDCLOLEQFH(gameObject.GetComponent<MeshFilter>().sharedMesh, 962f, 1769f);
		gameObject.gameObject.SetActive(true);
	}

	// Token: 0x0600492E RID: 18734 RVA: 0x0024E3CC File Offset: 0x0024C5CC
	public static void OHDCLOLEQFH(Mesh NFOOEHBKFMG, float PILPCIGMDCG, float LKLIDDPGJOI)
	{
		Vector3[] vertices = NFOOEHBKFMG.vertices;
		Vector3[] array = new Vector3[vertices.Length];
		int[] array2 = new int[vertices.Length];
		int num = 0;
		Vector3 vector = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
		Vector3 vector2 = new Vector3(float.MinValue, float.MinValue, float.MinValue);
		for (int i = 0; i < vertices.Length; i++)
		{
			if (vertices[i].x < vector.x)
			{
				vector.x = vertices[i].x;
			}
			if (vertices[i].y < vector.y)
			{
				vector.y = vertices[i].y;
			}
			if (vertices[i].z < vector.z)
			{
				vector.z = vertices[i].z;
			}
			if (vertices[i].x > vector2.x)
			{
				vector2.x = vertices[i].x;
			}
			if (vertices[i].y > vector2.y)
			{
				vector2.y = vertices[i].y;
			}
			if (vertices[i].z > vector2.z)
			{
				vector2.z = vertices[i].z;
			}
		}
		int num2 = Mathf.FloorToInt((vector2.x - vector.x) / LKLIDDPGJOI) + 1;
		int num3 = Mathf.FloorToInt((vector2.y - vector.y) / LKLIDDPGJOI) + 1;
		int num4 = Mathf.FloorToInt((vector2.z - vector.z) / LKLIDDPGJOI) + 1;
		List<int>[,,] array3 = new List<int>[num2, num3, num4];
		int j = 0;
		IL_2EC:
		while (j < vertices.Length)
		{
			int num5 = Mathf.FloorToInt((vertices[j].x - vector.x) / LKLIDDPGJOI);
			int num6 = Mathf.FloorToInt((vertices[j].y - vector.y) / LKLIDDPGJOI);
			int num7 = Mathf.FloorToInt((vertices[j].z - vector.z) / LKLIDDPGJOI);
			if (array3[num5, num6, num7] == null)
			{
				array3[num5, num6, num7] = new List<int>();
			}
			for (int k = 0; k < array3[num5, num6, num7].Count; k++)
			{
				Vector3 vector3 = array[array3[num5, num6, num7][k]] - vertices[j];
				if (Vector3.SqrMagnitude(vector3) < PILPCIGMDCG)
				{
					array2[j] = array3[num5, num6, num7][k];
					IL_2E6:
					j++;
					goto IL_2EC;
				}
			}
			array[num] = vertices[j];
			array3[num5, num6, num7].Add(num);
			array2[j] = num;
			num++;
			goto IL_2E6;
		}
		int[] triangles = NFOOEHBKFMG.triangles;
		int[] array4 = new int[triangles.Length];
		for (int l = 0; l < triangles.Length; l++)
		{
			array4[l] = array2[triangles[l]];
		}
		Vector3[] array5 = new Vector3[num];
		for (int m = 0; m < num; m++)
		{
			array5[m] = array[m];
		}
		NFOOEHBKFMG.Clear();
		NFOOEHBKFMG.vertices = array5;
		NFOOEHBKFMG.triangles = array4;
		NFOOEHBKFMG.RecalculateNormals();
	}

	// Token: 0x0600492F RID: 18735 RVA: 0x0024E750 File Offset: 0x0024C950
	private void FHCQCLBGBFN(List<int> NGDBDCQFDHI, DOJNBQQBCQJ.GQGJQHKJGGK QONOKDQLJNG)
	{
		if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.FrontSide)
		{
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(5);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RightSide)
		{
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(5);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.LeftSide)
		{
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(5);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RearSide)
		{
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(5);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.LeftCorner)
		{
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(5);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(8);
			NGDBDCQFDHI.Add(10);
			NGDBDCQFDHI.Add(9);
			NGDBDCQFDHI.Add(11);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RightCorner)
		{
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(5);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(8);
			NGDBDCQFDHI.Add(10);
			NGDBDCQFDHI.Add(9);
			NGDBDCQFDHI.Add(11);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RearLeftCorner)
		{
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(5);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(8);
			NGDBDCQFDHI.Add(10);
			NGDBDCQFDHI.Add(9);
			NGDBDCQFDHI.Add(11);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.RearRightCorner)
		{
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(5);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(8);
			NGDBDCQFDHI.Add(10);
			NGDBDCQFDHI.Add(9);
			NGDBDCQFDHI.Add(11);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.InnerFrontLeft)
		{
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(5);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(8);
			NGDBDCQFDHI.Add(9);
			NGDBDCQFDHI.Add(10);
			NGDBDCQFDHI.Add(11);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.InnerFrontRight)
		{
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(5);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(8);
			NGDBDCQFDHI.Add(9);
			NGDBDCQFDHI.Add(10);
			NGDBDCQFDHI.Add(11);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.InnerRearLeft)
		{
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(5);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(8);
			NGDBDCQFDHI.Add(9);
			NGDBDCQFDHI.Add(10);
			NGDBDCQFDHI.Add(11);
		}
		else if (QONOKDQLJNG == DOJNBQQBCQJ.GQGJQHKJGGK.InnerRearRight)
		{
			NGDBDCQFDHI.Add(0);
			NGDBDCQFDHI.Add(1);
			NGDBDCQFDHI.Add(2);
			NGDBDCQFDHI.Add(3);
			NGDBDCQFDHI.Add(4);
			NGDBDCQFDHI.Add(5);
			NGDBDCQFDHI.Add(6);
			NGDBDCQFDHI.Add(7);
			NGDBDCQFDHI.Add(8);
			NGDBDCQFDHI.Add(9);
			NGDBDCQFDHI.Add(10);
			NGDBDCQFDHI.Add(11);
		}
	}

	// Token: 0x06004930 RID: 18736 RVA: 0x0024E2D0 File Offset: 0x0024C4D0
	public GameObject PMGPIBCGFDN(Vector3 NDPKIFIQFCP)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.DKNJPPPJOFO, NDPKIFIQFCP, Quaternion.identity);
		gameObject.transform.position = NDPKIFIQFCP;
		gameObject.transform.parent = this.IDOEFMCFOBH;
		return gameObject;
	}

	// Token: 0x06004931 RID: 18737 RVA: 0x0024E2D0 File Offset: 0x0024C4D0
	public GameObject PPCPFFMMKED(Vector3 NDPKIFIQFCP)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.DKNJPPPJOFO, NDPKIFIQFCP, Quaternion.identity);
		gameObject.transform.position = NDPKIFIQFCP;
		gameObject.transform.parent = this.IDOEFMCFOBH;
		return gameObject;
	}

	// Token: 0x06004932 RID: 18738 RVA: 0x0001E9C2 File Offset: 0x0001CBC2
	private void Awake()
	{
		DOJNBQQBCQJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06004933 RID: 18739 RVA: 0x0024EBCC File Offset: 0x0024CDCC
	private GameObject ONMFQGQFIJJ(DOJNBQQBCQJ.GQGJQHKJGGK DPQFDCNLLPC, Vector3 NKKGPNPGDEM)
	{
		GameObject gameObject = new GameObject();
		gameObject.AddComponent<MeshCollider>();
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
		gameObject.GetComponent<MeshRenderer>().material = this.IJHHLKJIBJN;
		List<Vector3> list = new List<Vector3>();
		List<int> list2 = new List<int>();
		this.BHBLHPMEIHM(list, DPQFDCNLLPC);
		this.FHCQCLBGBFN(list2, DPQFDCNLLPC);
		mesh.Clear();
		mesh.vertices = list.ToArray();
		mesh.triangles = list2.ToArray();
		mesh.RecalculateNormals();
		gameObject.GetComponent<MeshCollider>().sharedMesh = mesh;
		gameObject.layer = 15;
		return gameObject;
	}

	// Token: 0x06004934 RID: 18740 RVA: 0x0024EC68 File Offset: 0x0024CE68
	public void NOGMMEBDNLH(MeshFilter[] KGINGOOIIDI)
	{
		CombineInstance[] array = new CombineInstance[KGINGOOIIDI.Length];
		for (int i = 0; i < KGINGOOIIDI.Length; i++)
		{
			array[i].mesh = KGINGOOIIDI[i].sharedMesh;
			array[i].transform = KGINGOOIIDI[i].transform.localToWorldMatrix;
			KGINGOOIIDI[i].gameObject.SetActive(false);
		}
		GameObject gameObject = this.GFLKJKFQOGB("PrimitiveFront", Vector3.zero, Vector3.zero);
		gameObject.GetComponent<MeshFilter>().mesh = new Mesh();
		gameObject.GetComponent<MeshFilter>().mesh.CombineMeshes(array);
		DOJNBQQBCQJ.OHDCLOLEQFH(gameObject.GetComponent<MeshFilter>().sharedMesh, 0.1f, 1f);
		gameObject.gameObject.SetActive(true);
	}

	// Token: 0x06004935 RID: 18741 RVA: 0x0001E9C2 File Offset: 0x0001CBC2
	private void HLHPCLEMCKI()
	{
		DOJNBQQBCQJ.HBFFCJHOCPE = this;
	}

	// Token: 0x04000F94 RID: 3988
	private static DOJNBQQBCQJ HBFFCJHOCPE;

	// Token: 0x04000F95 RID: 3989
	public GameObject DKNJPPPJOFO;

	// Token: 0x04000F96 RID: 3990
	private List<GameObject> LPECEBEGMBQ = new List<GameObject>();

	// Token: 0x04000F97 RID: 3991
	public Transform IDOEFMCFOBH;

	// Token: 0x04000F98 RID: 3992
	public List<DoorAnimator> PQFDCJHGHOB = new List<DoorAnimator>();

	// Token: 0x04000F99 RID: 3993
	public static AssetBundle IFEJNKQEDOO;

	// Token: 0x04000F9A RID: 3994
	public static AssetBundle DFCHKJIMPIK;

	// Token: 0x04000F9B RID: 3995
	public Material IJHHLKJIBJN;

	// Token: 0x04000F9C RID: 3996
	[CompilerGenerated]
	private static Func<GameObject, bool> HNCJFHJNHDN;

	// Token: 0x0200021C RID: 540
	public enum GQGJQHKJGGK
	{
		// Token: 0x04000F9E RID: 3998
		FrontSide,
		// Token: 0x04000F9F RID: 3999
		LeftCorner,
		// Token: 0x04000FA0 RID: 4000
		RightCorner,
		// Token: 0x04000FA1 RID: 4001
		LeftSide,
		// Token: 0x04000FA2 RID: 4002
		RightSide,
		// Token: 0x04000FA3 RID: 4003
		RearSide,
		// Token: 0x04000FA4 RID: 4004
		RearLeftCorner,
		// Token: 0x04000FA5 RID: 4005
		RearRightCorner,
		// Token: 0x04000FA6 RID: 4006
		InnerFrontLeft,
		// Token: 0x04000FA7 RID: 4007
		InnerFrontRight,
		// Token: 0x04000FA8 RID: 4008
		InnerRearRight,
		// Token: 0x04000FA9 RID: 4009
		InnerRearLeft
	}
}

using NUnit.Framework;
using UnityEngine;

public class VotarparamenuTest
{
  [Test]
  public void LoadS_DoesNotThrow_ForUnknownSceneName()
  {
    var go = new GameObject("testObj");
    var comp = go.AddComponent<Votarparamenu>();
    Assert.DoesNotThrow(() => comp.LoadS("ThisSceneDoesNotExist_ForTest_12345"));
    Object.DestroyImmediate(go);
  }

  [Test]
  public void LoadS_DoesNotThrow_ForEmptyString()
  {
    var go = new GameObject("testObj");
    var comp = go.AddComponent<Votarparamenu>();
    Assert.DoesNotThrow(() => comp.LoadS(string.Empty));
    Object.DestroyImmediate(go);
  }
}

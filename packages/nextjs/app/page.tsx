"use client";

// import Link from "next/link";
import type { NextPage } from "next";
import { Unity } from "react-unity-webgl";
import { useUnityContext } from "react-unity-webgl";

const Home: NextPage = () => {
  const { unityProvider } = useUnityContext({
    loaderUrl: "unityBuild/test.loader.js",
    dataUrl: "unityBuild/test.data",
    frameworkUrl: "unityBuild/test.framework.js",
    codeUrl: "unityBuild/test.wasm",
  });

  return (
    <div className="flex justify-center m-4">
      <Unity
        unityProvider={unityProvider}
        style={{
          width: "432px",
          height: "768px",
        }}
      />
    </div>
  );
};

export default Home;

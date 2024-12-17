"use client";

// import Link from "next/link";
import type { NextPage } from "next";
import { Unity } from "react-unity-webgl";
import { useUnityContext } from "react-unity-webgl";

const Home: NextPage = () => {
  const { unityProvider } = useUnityContext({
    loaderUrl: "Build/test.loader.js",
    dataUrl: "Build/test.data",
    frameworkUrl: "Build/test.framework.js",
    codeUrl: "Build/test.wasm",
  });

  return (
    <div className="flex justify-center m-4">
      <Unity className="w-[330px] h-[614px] md:w-[432px] md:h-[768px]" unityProvider={unityProvider} />
    </div>
  );
};

export default Home;

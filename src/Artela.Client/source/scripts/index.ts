(window as any).splash = {
    show: (): void => {
        document.getElementById("splash")?.classList.remove("hidden");
    },
    hide: (): void => {
        document.getElementById("splash")?.classList.add("hidden");
    }
};
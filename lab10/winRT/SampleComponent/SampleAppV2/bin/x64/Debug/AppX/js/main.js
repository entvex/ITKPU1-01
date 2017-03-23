// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509

(function () {


    var resultAsync;
    function asyncRun() {
        document.getElementById('output').innerHTML = "Retrieving prime numbers.";
        btnAsync.disabled = "disabled";
        btnCancel.disabled = "";

        resultAsync = SampleComponent.Example.getPrimesInRangeAsync(10000000000001, 2500).then(
            function (primes) {
                for (i = 0; i < primes.length; i++)
                    document.getElementById('output').innerHTML += " " + primes[i];

                btnCancel.disabled = "disabled";
                btnAsync.disabled = "";
            },
            function () {
                document.getElementById('output').innerHTML += " -- getPrimesInRangeAsync was canceled. -- ";

                btnCancel.disabled = "disabled";
                btnAsync.disabled = "";
            },
            function (prog) {
                document.getElementById('primeProg').value = prog;
            }
        );
    }

    function asyncCancel() {
        resultAsync.cancel();
    }

    var ev;

    function events1() {
        ev = new SampleComponent.Eventful();
        ev.addEventListener("test", function (e) {
            document.getElementById('output').innerHTML = e.value1;
            document.getElementById('output').innerHTML += "<br/>" + e.value2;
        });
        ev.onTest("Number of feet in a mile:", 5280);
    }


    var names;

    function returns1() {
        names = SampleComponent.Example.getMapOfNames();
        document.getElementById('output').innerHTML = showMap(names);
    }

    var ct = 7;

    function returns2() {
        if (!names.hasKey(17)) {
            names.insert(43, "forty-three");
            names.insert(17, "seventeen");
        }
        else {
            var err = names.insert("7", ct++);
            names.insert("forty", "forty");
        }
        document.getElementById('output').innerHTML = showMap(names);
    }

    function showMap(map) {
        var item = map.first();
        var retval = "<ul>";

        for (var i = 0, len = map.size; i < len; i++) {
            retval += "<li>" + item.current.key + ": " + item.current.value + "</li>";
            item.moveNext();
        }
        return retval + "</ul>";
    }


    var propertysetstats;

    function runtime2() {
        try {
            propertysetstats.addMore();
        }
        catch (ex) {
            document.getElementById('output').innerHTML +=
               "<br/><b>" + ex + "<br/>";
        }

        document.getElementById('output').innerHTML +=
            propertysetstats.displayStats();
    }


    function runtime1() {
        document.getElementById('output').innerHTML = "";

        propertysetstats = new SampleComponent.PropertySetStats();
        var propertyset = propertysetstats.propertySet;
        propertyset.addEventListener("mapchanged", onMapChanged);
        propertyset.insert("FirstProperty", "First property value");
        propertyset.insert("SuperfluousProperty", "Unnecessary property value");
        propertyset.insert("AnotherProperty", "A property value");

        propertyset.insert("SuperfluousProperty", "Altered property value");
        propertyset.remove("SuperfluousProperty");

        document.getElementById('output').innerHTML +=
            propertysetstats.displayStats();
    }

    function onMapChanged(change) {
        var result;
        switch (change.collectionChange) {
            case Windows.Foundation.Collections.CollectionChange.reset:
                result = "All properties cleared";
                break;
            case Windows.Foundation.Collections.CollectionChange.itemInserted:
                result = "Inserted " + change.key + ": '" +
                    change.target.lookup(change.key) + "'";
                break;
            case Windows.Foundation.Collections.CollectionChange.itemRemoved:
                result = "Removed " + change.key;
                break;
            case Windows.Foundation.Collections.CollectionChange.itemChanged:
                result = "Changed " + change.key + " to '" +
                    change.target.lookup(change.key) + "'";
                break;
            default:
                break;
        }

        document.getElementById('output').innerHTML +=
            "<br/>" + result;
    }


    var ex;

    function basics1() {
        document.getElementById('output').innerHTML =
             SampleComponent.Example.getAnswer();

        ex = new SampleComponent.Example();

        document.getElementById('output').innerHTML += "<br/>" +
            ex.sampleProperty;

    }

    function basics2() {
        ex.sampleProperty += 1;
        document.getElementById('output').innerHTML += "<br/>" +
            ex.sampleProperty;
    }


    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;
    var isFirstActivation = true;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.voiceCommand) {
            // TODO: Handle relevant ActivationKinds. For example, if your app can be started by voice commands,
            // this is a good place to decide whether to populate an input field or choose a different initial view.
        }
        else if (args.detail.kind === activation.ActivationKind.launch) {
            // A Launch activation happens when the user launches your app via the tile
            // or invokes a toast notification by clicking or tapping on the body.
            if (args.detail.arguments) {
                // TODO: If the app supports toasts, use this value from the toast payload to determine where in the app
                // to take the user in response to them invoking a toast notification.
            }
            else if (args.detail.previousExecutionState === activation.ApplicationExecutionState.terminated) {
                // TODO: This application had been suspended and was then terminated to reclaim memory.
                // To create a smooth user experience, restore application state here so that it looks like the app never stopped running.
                // Note: You may want to record the time when the app was last suspended and only restore state if they've returned after a short period.
            }
        }

        if (!args.detail.prelaunchActivated) {
            // TODO: If prelaunchActivated were true, it would mean the app was prelaunched in the background as an optimization.
            // In that case it would be suspended shortly thereafter.
            // Any long-running operations (like expensive network or disk I/O) or changes to user state which occur at launch
            // should be done here (to avoid doing them in the prelaunch case).
            // Alternatively, this work can be done in a resume or visibilitychanged handler.
        }

        if (isFirstActivation) {
            // TODO: The app was activated and had not been running. Do general startup initialization here.
            document.addEventListener("visibilitychange", onVisibilityChanged);
            args.setPromise(WinJS.UI.processAll().then(function () {
                var button1 = document.getElementById("button1");
                button1.addEventListener("click", basics1, false);
                var button2 = document.getElementById("button2");
                button2.addEventListener("click", basics2, false);

                var runtimeButton1 = document.getElementById("runtimeButton1");
                runtimeButton1.addEventListener("click", runtime1, false);
                var runtimeButton2 = document.getElementById("runtimeButton2");
                runtimeButton2.addEventListener("click", runtime2, false);

                var returnsButton1 = document.getElementById("returnsButton1");
                returnsButton1.addEventListener("click", returns1, false);
                var returnsButton2 = document.getElementById("returnsButton2");
                returnsButton2.addEventListener("click", returns2, false);

                var events1Button = document.getElementById("events1Button");
                events1Button.addEventListener("click", events1, false);

                var btnAsync = document.getElementById("btnAsync");
                btnAsync.addEventListener("click", asyncRun, false);
                var btnCancel = document.getElementById("btnCancel");
                btnCancel.addEventListener("click", asyncCancel, false);
            }));
        }

        isFirstActivation = false;
    };

    function onVisibilityChanged(args) {
        if (!document.hidden) {
            // TODO: The app just became visible. This may be a good time to refresh the view.
        }
    }

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state that needs to persist across suspensions here.
        // You might use the WinJS.Application.sessionState object, which is automatically saved and restored across suspension.
        // If you need to complete an asynchronous operation before your application is suspended, call args.setPromise().
    };

    app.start();

})();
